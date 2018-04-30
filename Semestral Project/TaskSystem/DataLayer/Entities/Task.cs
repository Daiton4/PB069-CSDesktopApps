using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace DataLayer.Entities
{
	/// <summary>
	/// Representation of Task in system
	/// </summary>
	public class Task : IEntity
	{
		public Guid Id { get; set; }
		
		public string TableName { get; } = nameof(TableNames.Tasks);
		
		//User owner of Task
		public Guid UserId { get; set; }

		//User object reference is mostly unused in system as it is now but it can be added later
		public virtual User User { get; set; }

		//signals wether Task has prerequisities
		public bool Prerequisities { get; set; }
		
		public string Name { get; set; }

		//Amount of Time ncessary to complete the task, Has to be Set through SetTime method
		public TimeSpan Time { get; set; }

		public void SetTime(TimeSpan time)
		{
			Time = time.Ticks < TimeSpan.TicksPerDay ? time : TimeSpan.FromTicks(TimeSpan.TicksPerDay - 100);
		}

		//compares properties of two tasks, used for testing of proper database requests
		public bool CompareStoredProperties(Task testTask)
		{
			return this.Prerequisities.Equals(testTask.Prerequisities) &&
			       this.Name.Equals(testTask.Name) &&
			       this.Time.Equals(testTask.Time) &&
			       this.UserId.Equals(testTask.UserId);
		}

		public override string ToString()
		{
			return Name.ToString().PadRight(20) + ", " + Time.Hours.ToString().PadRight(3) + "h " + ((Time.TotalHours % 1) * 60).ToString("N2").PadRight(5) + "m";
		}

		//objects are considered same if they share the Id
		public override bool Equals(object obj)
		{
			if (obj.GetType() != this.GetType()) return false;
			Task tst = (Task) obj;
			return tst.Id.Equals(this.Id);
		}
	}
}