namespace Conference.Model
{
	public interface IPhysicalSpace
	{
		int Capacity { get; set; }

		bool Outdoors { get; set; }
	}
}
