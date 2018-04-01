using System;
using System.Collections.Generic;
using DataLayer.Entities;

namespace TaskSystem
{
	/// <summary>
	/// main interfece to by used for implementation of UI for task system
	/// many methods in system ended up to be unused right now
	/// in future system should be edited in such way that no types from lover tiers will be used
	/// </summary>
	public interface ITaskSystem
	{
		User ActualUser { get; set; }

		bool VerifyUser(string name, string password);

		bool PasswordChange(User admin, User user, string password);

		bool AddTask(string name, TimeSpan time);

		bool EditTask( Task task);

		bool RemoveTask( Task task);

		List<Task> GetTaskList();

		List<Task> GetPrerequisityList(Task task);

		bool AddPrerequisity(Task task, Task prerequisity);

		bool RemoveUser(User admin, User user);

		List<User> GetUsersByName(User user, string search);

		List<User> GetUsersByEMail(User user, string search);

		bool AddUser(User admin, User addedUser);

		bool EditUser(User admin, User user);

		void RemovePrerequisity(Task task, Task prer);
	}
}