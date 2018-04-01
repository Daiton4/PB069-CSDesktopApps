using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
	/// <summary>
	/// represents user in system
	/// </summary>
	public class User : IEntity
	{
		public Guid Id { get; set; }
		
		public string TableName { get; } = nameof(TableNames.Users);
		
		public string Name { get; set; }
		
		public string EMail { get; set; }
		
		//in database only md5 hashes of passwords are stored, password in text passing through system should be avoided
		public string PasswordHash { get; set; }

		//signals administration rights of user
		public bool IsAdmin { get; set; }

		//same as in Task
		public bool compareStoredProperties(User comparedUser)
		{
			return Name.Equals(comparedUser.Name) &&
			       EMail.Equals(comparedUser.EMail) && 
			       PasswordHash.Equals(comparedUser.PasswordHash) &&
			       IsAdmin.Equals(comparedUser.IsAdmin);
		}

		public override string ToString()
		{
			return Name.PadRight(20) + ", " + EMail.PadRight(20) + ", " + (IsAdmin ? "Admin" : "Normie");
		}

		public override bool Equals(object obj)
		{
			if (obj == null || obj.GetType() != this.GetType()) return false;
			User tst = (User)obj;
			return tst.Id.Equals(this.Id);
		}
	}
}