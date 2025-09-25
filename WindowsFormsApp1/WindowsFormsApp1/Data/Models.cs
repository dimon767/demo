namespace WindowsFormsApp1.Data
{
	public class Partner
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int PartnerTypeId { get; set; }
		public string PartnerTypeName { get; set; }
		public string DirectorName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string LegalAddress { get; set; }
		public string Inn { get; set; }
		public int Rating { get; set; }
	}

	public class ServiceHistoryItem
	{
		public string ServiceName { get; set; }
		public int Quantity { get; set; }
		public System.DateTime PerformedAt { get; set; }
	}
}


