using System;

namespace Conference.Model
{
	public class Speaker : Registrant, IModelGuid
	{
		public Guid Id { get; set; }
	}
}
