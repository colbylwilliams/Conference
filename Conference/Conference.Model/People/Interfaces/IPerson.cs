namespace Conference.Model
{
	public interface IPerson : IPersonName, IJobRole, IPhoto, IEmails
	{
		string Bio { get; set; }
	}
}
