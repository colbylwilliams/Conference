using System;

namespace Conference.Model
{
	public class Attendee : Registrant, IModelGuid
	{
		public Guid Id { get; set; }
	}
}
