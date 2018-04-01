using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using DataLayer.Entities;

namespace DataLayer.MainInterface
{
	public class UserManager : IUsersManager
	{
		private SqlConnection _connection;

		//connection is reused for easier usage of manager
		private void OpenConnection()
		{
			_connection = new SqlConnection(TsDbContext.ConnectionString);
			_connection.Open();
		}

		public Guid AddUser(User newUser)
		{
			using (_connection)
			{
				try
				{
					OpenConnection();
					return _connection.Query<Guid>("Insert Into " + newUser.TableName + " (Id,Name,Email,PasswordHash,IsAdmin)" +
					                               "Output Inserted.Id " +
					                               "Values (NEWID(),@Name,@Email,@PasswordHash,@IsAdmin);", newUser)
						.First();
				}
				catch (SqlException)
				{
					return Guid.Empty;
				}
			}
		}

		public bool UpdateUser(User newUser)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Execute("Update " + newUser.TableName + " " +
				                           "Set Name=@Name, Email=@Email, PasswordHash=@PasswordHash, IsAdmin=@IsAdmin " +
				                           "Where Id=@Id", newUser) > 0;
			}
		}

		public bool RemoveUser(User user)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Execute("Delete From " + user.TableName + " Where Id=@Id", user) > 0;
			}
		}

		public User GetUserById(Guid id)
		{
			try
			{
				using (_connection)
				{
					OpenConnection();
					return _connection.Query<User>("Select * from " + TableNames.Users +
					                               " Where id=@getId", new { getId = id })
						.First();
				}
			}
			catch (InvalidOperationException)
			{
				return null;
			}
		}

		public User GetUserByName(string name)
		{
			using (_connection)
			{
				OpenConnection();
				var ret = _connection.Query<User>("Select * from " + TableNames.Users +
				                               " Where Name=@name", new {name = name}).ToList();
				return ret.Count > 0 ? ret.First() : null;
			}
		}

		public User GetUserByEMail(string email)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<User>("Select * from " + TableNames.Users +
				                               " Where Email=@Email", new { Email = email })
					.First();
			}
		}

		public List<User> SearchUsersByName(string name)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<User>("Select * from " + TableNames.Users +
				                               " Where Name Like @name", new { name = "%" + name + "%" })
					.ToList();
			}
		}

		public string GetPasswordHashForUser(Guid id)
		{
			try
			{
				using (_connection)
				{
					OpenConnection();
					return _connection.Query<string>("Select PasswordHash from " + TableNames.Users +
					                               " Where id=@getId", new { getId = id })
						.First();
				}
			}
			catch (SqlException)
			{
				return null;
			}
		}

		public List<User> SearchUsersByEMail(string mail)
		{
			using (_connection)
			{
				OpenConnection();
				return _connection.Query<User>("Select * from " + TableNames.Users +
				                               " Where Email Like @Email", new { Email = "%" + mail + "%" })
					.ToList();
			}
		}
	}
}