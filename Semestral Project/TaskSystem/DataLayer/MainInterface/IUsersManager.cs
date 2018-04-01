using System;
using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.MainInterface
{
	/// <summary>
	/// Database operations over User Entity
	/// </summary>
	public interface IUsersManager
	{
		Guid AddUser(User newUser);

		bool UpdateUser(User newUser);

		bool RemoveUser(User user);

		User GetUserById(Guid id);

		//Get methods are looking for one occourence of string, if more have been found, first is returned
		User GetUserByName(string name);

		User GetUserByEMail(string email);

		//search methods use SQLs LIKE %string% matching to return collection od results
		List<User> SearchUsersByName(string name);

		string GetPasswordHashForUser(Guid id);

		List<User> SearchUsersByEMail(string mail);
	}
}