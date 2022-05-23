namespace AssignmentVitalHubAPI.DTO
{
	public class OrderItemDTO
	{
		public int? Id { get; set; }
		public DateTimeOffset? CreatedDateTime { get; set; }

		public DateTimeOffset? UpdatedDateTime { get; set; }
		public byte[]? RowVersion { get; set; }

		public bool? IsDeleted { get; set; }
		public int? OrderId { get; set; }
		public OrderDTO Orders { get; set; }
		public int? ItemId { get; set; }
		public virtual ICollection<ItemDTO> Items { get; set; }
		public int Quantity { get; set; }
	}
}
