using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.MainInterface;

namespace TaskSystem.Tests
{
	[TestClass()]
	public class TaskSystemTests
	{
		[TestMethod()]
		public void VerifyUserTest()
		{
			var system = new TaskSystem();
			var usrmgr = new UserManager();
			var testUser = new User()
			{
				EMail = "test@User.com",
				IsAdmin = true,
				Name = "TestUser",
				PasswordHash = system.CalculateMd5Hash("password")
			};
			testUser.Id = usrmgr.AddUser(testUser);
			Assert.IsTrue(system.VerifyUser(testUser.Name,"password"));
			usrmgr.RemoveUser(testUser);
		}
	}
}