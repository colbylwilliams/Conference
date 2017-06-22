namespace Conference.Model
{
	public interface IPersonName : IName
	{
		string NamePrifix { get; set; }

		string GivenName { get; set; }

		string MiddleName { get; set; }

		string FamilyName { get; set; }

		string NmeSuffix { get; set; }
	}
}
