using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using DataLayer;
using DataLayer.Entities;

namespace TaskSystem
{
	/// <summary>
	/// Small interface for manual testing of program backend
	/// </summary>
	class Program
	{
		private static ITaskSystem _system = new TaskSystem();
		private static List<User> users;
		private static List<Task> tasks;
		private static User originalUser;

		static void Main(string[] args)
		{
			
			while(true)
			{
				if (_system.ActualUser == null)
				{
					Console.WriteLine("Login");
					var login = Console.ReadLine();
					Console.WriteLine("password");
					var password = Console.ReadLine();
					if (!_system.VerifyUser(login, password)) continue;
				}

				var input = Console.ReadLine().Split(' ');
				switch (input[0])
				{
					case "ShowUsers":
						ShowUsers();
						break;
					case "AddUser":
						AddUser(input);
						break;
					case "ShowTasksFor":
						ShowTasksFor(input);
						break;
					case "AddTaskFor":
						AddTasksFor(input);
						break;
					case "AddPrerequisityFor":
						AddPrerequisityFor(input);
						break;
					case "ShowPrerequisitiesForTask":
						ShowPrerequisitiesForTask(input);
						break;
					case "Exit":
						Environment.Exit(0);
						break;
				}
			}
		}

		private static void ShowPrerequisitiesForTask(string[] input)
		{
			int.TryParse(input[1], out var taskIndex);
			var prereqs = _system.GetPrerequisityList(tasks[taskIndex]);
			foreach (var task in prereqs)
			{
				Console.WriteLine(prereqs.IndexOf(task) + "  | " + task);
			}
		}

		private static void AddPrerequisityFor(string[] input)
		{
			int.TryParse(input[1], out var taskIndex);
			int.TryParse(input[2], out var prereqIndex);
			_system.AddPrerequisity(tasks[taskIndex], tasks[prereqIndex]);
			var prereqs = _system.GetPrerequisityList(tasks[taskIndex]);
			foreach (var task in prereqs)
			{
				Console.WriteLine(prereqs.IndexOf(task) + "  | " + task);
			}
		}

		private static void AddTasksFor(string[] input)
		{
			int.TryParse(input[1], out var index);
			int.TryParse(input[3], out var time);
			var given = users[index];
			if (originalUser == null) originalUser = _system.ActualUser;
			_system.ActualUser = given;
			_system.AddTask(input[2], TimeSpan.FromHours(time));
			var tasks = _system.GetTaskList();
			foreach (var task in tasks)
			{
				Console.WriteLine(tasks.IndexOf(task) + "  | " + task);
			}
		}

		private static void ShowTasksFor(string[] input)
		{
			int.TryParse(input[1], out var index);
			var given = users[index];
			if(originalUser == null) originalUser = _system.ActualUser;
			_system.ActualUser = given;
			tasks = _system.GetTaskList();
			foreach (var task in tasks)
			{
				Console.WriteLine(tasks.IndexOf(task) + "  | " + task);
			}
		}

		private static void AddUser(string[] input)
		{
			var newUser = new User()
			{
				Name = input[1],
				EMail = input[2],
				PasswordHash = input[4]
			};
			newUser.IsAdmin = input[3].Equals("Yes");
			_system.AddUser(_system.ActualUser, newUser);
		}

		private static void ShowUsers()
		{
			users = _system.GetUsersByName(_system.ActualUser, "");
			foreach (var user in users)
			{
				Console.WriteLine(users.IndexOf(user) + "  | " +
				                  user);
			}
		}
	}
}
