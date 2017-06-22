namespace Conference.Model
{
	public interface IPostalAddress
	{
		string Address1 { get; set; }

		string Address2 { get; set; }

		string City { get; set; }

		string State { get; set; }

		string PostalCode { get; set; }

		string Country { get; set; }

		string IsoCountryCode { get; set; }
	}
}
