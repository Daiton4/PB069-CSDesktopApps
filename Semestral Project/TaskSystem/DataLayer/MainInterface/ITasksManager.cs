using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer.Entities;

namespace DataLayer.MainInterface
{
	/// <summary>
	/// Methods implementing work with database for Task and Prerequisity Entities
	/// </summary>
	public interface ITasksManager
	{
		Guid AddTask(Task newTask);

		bool UpdateTask(Task newTask);

		bool RemoveTask(Task task);

		Task GeTaskById(Guid id);

		List<Task> GetTasksForUser(Guid id);

		//name represents string to be matched by SQL %name% format
		List<Task> SearchTasksByName(string name);

		List<Task> GetTasksWithLength(TimeSpan minSpan, TimeSpan maxSpan);

		List<Task> GetPrerequisitiesForTask(Guid id);

		List<Guid> GetPrerequisitiesIdForTask(Guid id);

		bool AddPrerequisityForTask(Guid task, Guid prerequisity);

		void RemovePrerequisityFortask(Guid task, Guid prerequisity);
	}
}