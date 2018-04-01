using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
	/// <summary>
	/// Represents connection between two Tasks as one has to be completed to complete other.
	/// </summary>
	public class Prerequisity : IEntity
	{
		public Guid Id { get; set; }

		public string TableName { get; } = nameof(TableNames.Prerequisities);
		
		public Guid TaskId { get; set; }
		
		public Guid PrerequisityId { get; set; }
	}
}