using System;
using System.Collections.Generic;
using DataLayer.Entities;
using DataLayer.MainInterface;
using System.Security.Cryptography;
using System.Text;

namespace TaskSystem
{
	public class TaskSystem : ITaskSystem
	{
		//system holds information about user who manipulates its data and holds managers to modify data
		public User ActualUser { get; set; } = null;
		private readonly IUsersManager _usersManager = new UserManager();
		private readonly ITasksManager _tasksManager = new TaskManager();

		public bool VerifyUser(string name, string password)
		{
			var user = _usersManager.GetUserByName(name);
			if (user == null) return false;
			if (

				user.PasswordHash.Equals(CalculateMd5Hash(password))) 
			{
				ActualUser = user;
				return true;
			};
			return false;
		}

		public bool PasswordChange(User admin, User user, string password)
		{
			user.PasswordHash = CalculateMd5Hash(password);
			return EditUser(admin,user);
		}

		public string CalculateMd5Hash(string input)

		{
			MD5 md5 = System.Security.Cryptography.MD5.Create();

			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

			byte[] hash = md5.ComputeHash(inputBytes);

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < hash.Length; i++)

			{

				sb.Append(hash[i].ToString("X2"));

			}

			return sb.ToString();

		}

		public bool AddTask(string name, TimeSpan time)
		{
			var task = new Task()
			{
				Name = name,
				Prerequisities = false,
				Time = time,
				User = ActualUser,
				UserId = ActualUser.Id
			};
			task.SetTime(time);
			_tasksManager.AddTask(task);
			return true;
		}

		public bool EditTask(Task task)
		{
			return _tasksManager.UpdateTask(task);
		}

		public bool RemoveTask(Task task)
		{
			return _tasksManager.RemoveTask(task);
		}

		public List<Task> GetTaskList()
		{
			return _tasksManager.GetTasksForUser(ActualUser.Id);
		}

		public List<Task> GetPrerequisityList(Task task)
		{
			return _tasksManager.GetPrerequisitiesForTask(task.Id);
		}

		public bool AddPrerequisity(Task task,Task prerequisity)
		{
			if (!task.Prerequisities)
			{
				task.Prerequisities = true;
				_tasksManager.UpdateTask(task);
				return _tasksManager.AddPrerequisityForTask(task.Id, prerequisity.Id);
			}

			return _tasksManager.AddPrerequisityForTask(task.Id, prerequisity.Id);
		}

		public bool EditUser(User admin, User user)
		{
			return admin.IsAdmin ? _usersManager.UpdateUser(user) : false;
		}

		public bool RemoveUser(User admin, User user)
		{
			return admin.IsAdmin ? _usersManager.RemoveUser(user) : false;
		}
		
		public bool AddUser(User admin, User addedUser)
		{
			addedUser.PasswordHash = CalculateMd5Hash(addedUser.PasswordHash);
			return admin.IsAdmin ? (_usersManager.AddUser(addedUser) != Guid.Empty) : false;
		}

		public void RemovePrerequisity(Task task, Task prer)
		{
			if (_tasksManager.GetPrerequisitiesIdForTask(task.Id).Count == 1)
			{
				task.Prerequisities = false;
				_tasksManager.UpdateTask(task);
			}
			_tasksManager.RemovePrerequisityFortask(task.Id,prer.Id);
		}

		public List<User> GetUsersByName(User user, string search)
		{
			return user.IsAdmin ? _usersManager.SearchUsersByName(search) : new List<User>();
		}

		public List<User> GetUsersByEMail(User user, string search)
		{
			return user.IsAdmin ? _usersManager.SearchUsersByEMail(search) : new List<User>();
		}
	}
}