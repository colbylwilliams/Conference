using System;

namespace Conference.Model
{
	public interface IStartEnd
	{
		DateTimeOffset Start { get; set; }

		DateTimeOffset End { get; set; }
	}
}
