using System.Collections.Generic;

namespace Conference.Model
{
	public class Session : ITitle, IDescription
	{
		public string Code { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string TargetAudience { get; set; }

		public string Outcomes { get; set; }

		public List<Speaker> Speakers { get; set; }
	}
}
