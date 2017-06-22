namespace Conference.Model
{
	public interface IJobRole
	{
		string OrganizationName { get; set; }

		string DepartmentName { get; set; }

		string JobTitle { get; set; }

		string RoleTitle { get; set; }
	}
}
