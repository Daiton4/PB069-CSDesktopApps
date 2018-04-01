using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer.MainInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using DataLayer.Entities;

namespace DataLayer.MainInterface.Tests
{
	/// <summary>
	/// quick tests used to debug functionality during development
	/// </summary>
	[TestClass()]
	public class TaskManagerTests
	{
		private Task testTask;
		private TaskManager Tmanager;
		private Guid taskGuid;

		[TestInitialize()]
		public void TestInit()
		{
			Tmanager = new TaskManager();
			testTask = new Task
			{
				UserId = Guid.NewGuid(),
				Prerequisities = false,
				Name = "TestTask"
			};
			testTask.SetTime(TimeSpan.FromTicks(66));
		}

		[TestCleanup]
		public void TestClean()
		{
			var connection = new SqlConnection(TsDbContext.ConnectionString);
			connection.Open();
			using (connection)
			{
				connection.Execute("Delete from " + TableNames.Tasks + " Where Time=@Time", new {Time = TimeSpan.FromTicks(66)});
			}
		}

		[TestMethod()]
		[Timeout(5000)]
		public void AddAndGetTaskTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			Task returnedTask = Tmanager.GeTaskById(taskGuid);
			Assert.IsTrue(returnedTask.CompareStoredProperties(testTask));
		}

		[TestMethod()]
		public void UpdateTaskTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			Task returnedTask = Tmanager.GeTaskById(taskGuid);
			returnedTask.Name = "Edited";
			bool success = Tmanager.UpdateTask(returnedTask);
			returnedTask = Tmanager.GeTaskById(taskGuid);
			Assert.IsTrue(success && returnedTask.Name.Equals("Edited"));
		}

		[TestMethod()]
		public void RemoveTaskTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			Task taskToRemove = Tmanager.GeTaskById(taskGuid);
			bool success = Tmanager.RemoveTask(taskToRemove);
			taskToRemove = Tmanager.GeTaskById(taskGuid);
			Assert.IsTrue(success && taskToRemove == null);
		}
		
		[TestMethod()]
		public void GetTasksForUserTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			List<Task> returnedList = Tmanager.GetTasksForUser(testTask.UserId);
			Assert.IsTrue(returnedList.First().Id.Equals(taskGuid));
		}

		[TestMethod()]
		public void SearchTasksByNameTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			testTask.Name = "NestTask";
			taskGuid = Tmanager.AddTask(testTask);
			testTask.Name = "Nesffffsk";
			taskGuid = Tmanager.AddTask(testTask);
			List<Task> taskList = Tmanager.SearchTasksByName("estTa");
			var test = taskList
				.Select(task => task.Name)
				.Count(name => name.Equals("TestTask") || name.Equals("NestTask"));
			Assert.IsTrue(test == 2);
		}

		[TestMethod()]
		public void GetTasksWithLengthTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			var ret = Tmanager.GetTasksWithLength(TimeSpan.FromTicks(60), TimeSpan.FromTicks(70)).First();
			Assert.IsTrue(testTask.CompareStoredProperties(ret));
		}

		[TestMethod()]
		public void GetPrerequisitiesForTaskTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			testTask.Name = "prer1";
			Guid prer1Guid = Tmanager.AddTask(testTask);
			testTask.Name = "prer2";
			Guid prer2Guid = Tmanager.AddTask(testTask);
			Prerequisity prerequisity = new Prerequisity();
			prerequisity.TaskId = taskGuid;
			prerequisity.PrerequisityId = prer1Guid;
			prerequisity.PrerequisityId = prer2Guid;
			Tmanager.AddPrerequisityForTask(taskGuid, prer1Guid);
			Tmanager.AddPrerequisityForTask(taskGuid, prer2Guid);
			var ret = Tmanager
				.GetPrerequisitiesForTask(taskGuid)
				.Where(task => task.Name == "prer1" || task.Name == "prer2")
				.Count(task => task.Id == prer1Guid || task.Id == prer2Guid);
			Assert.IsTrue(ret == 2);

		}

		[TestMethod()]
		public void GetPrerequisitiesIdForTaskTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			testTask.Name = "prer1";
			Guid prer1Guid = Tmanager.AddTask(testTask);
			testTask.Name = "prer2";
			Guid prer2Guid = Tmanager.AddTask(testTask);
			Prerequisity prerequisity = new Prerequisity();
			prerequisity.TaskId = taskGuid;
			prerequisity.PrerequisityId = prer1Guid;
			prerequisity.PrerequisityId = prer2Guid;
			Tmanager.AddPrerequisityForTask(taskGuid, prer1Guid);
			Tmanager.AddPrerequisityForTask(taskGuid, prer2Guid);
			var ret = Tmanager
				.GetPrerequisitiesForTask(taskGuid)
				.Count(task => task.Id == prer1Guid || task.Id == prer2Guid);
			Assert.IsTrue(ret == 2);
		}

		[TestMethod()]
		public void AddPrerequisityForTaskTest()
		{
			taskGuid = Tmanager.AddTask(testTask);
			testTask.Name = "prer1";
			Guid prer1Guid = Tmanager.AddTask(testTask);
			Prerequisity prerequisity = new Prerequisity();
			prerequisity.TaskId = taskGuid;
			prerequisity.PrerequisityId = prer1Guid;
			Tmanager.AddPrerequisityForTask(taskGuid, prer1Guid);
			Assert.IsTrue(Tmanager.GetPrerequisitiesIdForTask(taskGuid).First().Equals(prer1Guid));
		}
	}
}