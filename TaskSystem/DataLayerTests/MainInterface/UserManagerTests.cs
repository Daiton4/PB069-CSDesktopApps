using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer.MainInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataLayer.Entities;

namespace DataLayer.MainInterface.Tests
{
	/// <summary>
	/// quick tests used to debug functionality during development
	/// </summary>
	[TestClass()]
	public class UserManagerTests
	{
		private User testUser;
		private UserManager userManager;

		[TestInitialize]
		public void TestInit()
		{
			testUser = new User
			{
				Name = "TestUser",
				EMail = "user@test.com",
				PasswordHash = "455584568SMHS"
			};
			userManager = new UserManager();
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			var connection = new SqlConnection(TsDbContext.ConnectionString);
			connection.Open();
			using (connection)
			{
				connection.Execute("Delete from " + TableNames.Users + " Where PasswordHash=@pswd", new { pswd = "455584568SMHS" });
			}
		}

		[TestMethod()]
		public void AddAndGetUserTest()
		{
			Guid newGuid = userManager.AddUser(testUser);
			User retUser = userManager.GetUserById(newGuid);
			Assert.IsTrue(testUser.compareStoredProperties(retUser));
		}

		[TestMethod()]
		public void UpdateUserTest()
		{

			Guid newGuid = userManager.AddUser(testUser);
			testUser.Name = "updated";
			testUser.Id = newGuid;
			userManager.UpdateUser(testUser);
			User retUser = userManager.GetUserById(newGuid);
			Assert.IsTrue(retUser.Name.Equals("updated"));
		}

		[TestMethod()]
		public void RemoveUserTest()
		{
			Guid newGuid = userManager.AddUser(testUser);
			testUser.Id = newGuid;
			userManager.RemoveUser(testUser);
			User retUser = userManager.GetUserById(newGuid);
			Assert.IsTrue(retUser == null);
		}

		[TestMethod()]
		public void GetUserByNameTest()
		{
			userManager.AddUser(testUser);
			User retUser = userManager.GetUserByName(testUser.Name);
			Assert.IsTrue(testUser.compareStoredProperties(retUser));
		}

		[TestMethod()]
		public void GetUserByEMailTest()
		{
			userManager.AddUser(testUser);
			User retUser = userManager.GetUserByEMail(testUser.EMail);
			Assert.IsTrue(testUser.compareStoredProperties(retUser));
		}

		[TestMethod()]
		public void SearchUsersByNameTest()
		{
			userManager.AddUser(testUser);
			testUser.Name = "festUsken";
			userManager.AddUser(testUser);
			var ret = userManager.SearchUsersByName("stUs")
				.Count(user => user.Name.Equals("festUsken") || user.Name.Equals("TestUser"));
			Assert.IsTrue(ret == 2);
		}

		[TestMethod()]
		public void GetPasswordHashForUserTest()
		{
			Guid newGuid = userManager.AddUser(testUser);
			string hash = userManager.GetPasswordHashForUser(newGuid);
			Assert.IsTrue(hash.Equals(testUser.PasswordHash));
		}

		[TestMethod()]
		public void SearchUsersByEMailTest()
		{
			userManager.AddUser(testUser);
			testUser.EMail = "mortimer@temno.com";
			userManager.AddUser(testUser);
			var ret = userManager.SearchUsersByEMail("er@te")
				.Count(user => user.EMail.Equals("mortimer@temno.com") || user.EMail.Equals("user@test.com"));
			Assert.IsTrue(ret == 2);
		}
	}
}