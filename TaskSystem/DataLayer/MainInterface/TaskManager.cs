using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using Dapper;
using DataLayer.Entities;

namespace DataLayer.MainInterface
{
	public class TaskManager : ITasksManager
	{
		private SqlConnection _connection;

		//connection is reused for easier usage of manager
		private void OpenConnection()
		{
			_connection = new SqlConnection(TsDbContext.ConnectionString);
			_connection.Open();
		}

		public Guid AddTask(Task newTask)
		{
			using (_connection)
			{
				try
				{
					OpenConnection();
					return _connection.Query<Guid>("Insert into " + newTask.TableName +
					                               " (Id,UserId,Prerequisities,Name,Time)" +
					                               " OUTPUT INSERTED.ID " +
					                               "values (NEWID(), @UserId, @Prerequisities, @Name, @Time)", newTask)
						.First();
				}
				catch (SqlException)
				{
					return Guid.Empty;
				}
			}
		}

		public bool UpdateTask(Task newTask)
		{
			using (_connection)
			{
				OpenConnection();
				var ret = _connection.Execute("Update " + newTask.TableName + " " +
											 "Set UserId=@UserId, Prerequisities=@Prerequisities, Name=@Name, Time=@Time " +
				                             "Where Id=@Id", newTask);
				return ret > 0;
			}
		}

		public bool RemoveTask(Task task)
		{
			using (_connection)
			{
				OpenConnection();
				var ret = _connection.Execute("Delete From " + task.TableName + " " +
				                             "Where Id=@Id", task);
				if (ret > 0)
				{
					_connection.Execute("Delete From " + TableNames.Prerequisities + " " +
					                    "Where TaskId=@Id", task);
				}
				return ret > 0;
			}
		}

		public Task GeTaskById(Guid id)
		{
			try
			{
				using (_connection)
				{
					OpenConnection();
					return _connection.Query<Task>("Select * from " + TableNames.Tasks + 
					                               " Where id=@getId", new {getId = id})
						.First();
				}
			}
			catch (InvalidOperationException exception)
			{
				return null;
			}
		}

		public List<Task> GetTasksForUser(Guid id)
		{
			try
			{
				using (_connection)
				{
					OpenConnection();
					return _connection.Query<Task>("Select * from " + TableNames.Tasks + 
					                               " Where UserId=@UserId", new { UserId = id })
						.ToList();
				}
			}
			catch (InvalidOperationException )
			{
				return null;
			}
		}

		public List<Task> SearchTasksByName(string name)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<Task>("Select * from " + TableNames.Tasks + 
				                               " Where Name Like '%" + name + "%'")
					.ToList();
			}
		}

		public List<Task> GetTasksWithLength(TimeSpan minSpan, TimeSpan maxSpan)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<Task>("Select * from " + TableNames.Tasks + 
				                               " Where (Time >= @min And Time <= @max)"
											   , new { min = minSpan, max = maxSpan})
					.ToList();
			}
		}

		public List<Task> GetPrerequisitiesForTask(Guid id)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<Task>("Select t.Id,t.Name,t.Prerequisities,t.Time,t.UserId " +
				                                  "from TaskSystemDb.dbo.Prerequisities p inner join TaskSystemDb.dbo.Tasks t " +
				                                  "on p.PrerequisityId=t.Id where p.TaskId=@id", new { id = id}).ToList();
			}
		}

		public List<Guid> GetPrerequisitiesIdForTask(Guid id)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<Guid>("Select PrerequisityId from " + TableNames.Prerequisities + " " +
				                               "Where TaskId=@id", new { id = id }).ToList();
			}
		}

		public bool AddPrerequisityForTask(Guid task, Guid prerequisity)
		{
			using (_connection)
			{
				OpenConnection();//get string vlozeny, prehodit vyssie
				int ret = _connection.Execute("Insert Into " + TableNames.Prerequisities + 
				                              "(Id,TaskId,PrerequisityId) " +
				                              "Values (NEWID(),@task,@prer);", new {task = task, prer = prerequisity});
				return ret > 0;
			}
		}

		public void RemovePrerequisityFortask(Guid task, Guid prerequisity)
		{
			using (_connection)
			{
				OpenConnection();
				_connection.Execute("Delete from " + TableNames.Prerequisities + " " +
				                    "Where TaskId=@tid And PrerequisityId=@pid", new {tid = task, pid = prerequisity});
			}
		}
	}
}