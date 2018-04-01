using System;

namespace DataLayer.Entities
{
	/// <summary>
	/// represents base for entities in system
	/// </summary>
	public interface IEntity
	{
		//identificator necessary for database, not used very often in system
		Guid Id { get; set; }

		//Name of database table in which entity is stored...used mostly for faster refactoring
		string TableName { get;}
	}
}