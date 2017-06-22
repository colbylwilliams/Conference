using System.Collections.Generic;

namespace Conference.Model
{
	public abstract class Organization : IOrganization
	{
		// IName

		public string Name { get; set; }


		// IDescription

		public string Description { get; set; }


		// IEmails

		public List<string> Emails { get; set; }


		// IPhoto

		public string Photo { get; set; }


		// IPostalAddress

		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string PostalCode { get; set; }

		public string Country { get; set; }

		public string IsoCountryCode { get; set; }
	}
}
