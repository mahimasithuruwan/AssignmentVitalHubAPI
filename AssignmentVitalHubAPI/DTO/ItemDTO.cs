namespace AssignmentVitalHubAPI.DTO
{
	public class ItemDTO
	{
		public int? Id { get; set; }
		public DateTimeOffset? CreatedDateTime { get; set; }

		public DateTimeOffset? UpdatedDateTime { get; set; }
		public byte[]? RowVersion { get; set; }

		public bool? IsDeleted { get; set; }

		public string Code { get; set; }
		public string Description { get; set; }
		public PortionSize? PortionSizeId { get; set; }
		public int Price { get; set; }

	}
	public enum PortionSize
	{
		S = 1,
		M = 2,
		L = 3
	}
}
