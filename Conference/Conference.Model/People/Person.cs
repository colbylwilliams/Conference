using System.Collections.Generic;

namespace Conference.Model
{
	public abstract class Person : IPerson
	{
		// IPerson

		public string Bio { get; set; }


		// IName

		public string Name { get; set; }


		// IPersonName

		public string NamePrifix { get; set; }

		public string GivenName { get; set; }

		public string MiddleName { get; set; }

		public string FamilyName { get; set; }

		public string NmeSuffix { get; set; }


		// IJobRole

		public string OrganizationName { get; set; }

		public string DepartmentName { get; set; }

		public string JobTitle { get; set; }

		public string RoleTitle { get; set; }


		// IPhoto

		public string Photo { get; set; }


		// IEmails

		public List<string> Emails { get; set; }
	}
}
