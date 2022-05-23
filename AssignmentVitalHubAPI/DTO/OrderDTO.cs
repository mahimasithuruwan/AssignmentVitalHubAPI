namespace AssignmentVitalHubAPI.DTO
{
	public class OrderDTO
	{
		public int? Id { get; set; }
		public DateTimeOffset? CreatedDateTime { get; set; }

		public DateTimeOffset? UpdatedDateTime { get; set; }
		public byte[]? RowVersion { get; set; }

		public bool? IsDeleted { get; set; }

		public int? CustomerPhoneNo { get; set; }
		public int? DeliveryPersonPhoneNo { get; set; }

		public OrderThrough? OrderThrougheId { get; set; }
		public OrderType? OrderTypeId { get; set; }
		public OrderStatus? OrderStatusId { get; set; }
	}
	public enum OrderThrough
	{
		Online = 1,
		POS = 2
	}

	public enum OrderType
	{
		DineIn = 1,
		TakeAway = 2
	}
	public enum OrderStatus
	{
		InQueue = 1,
		Preparing = 2,
		OrderReady = 3,
		PickedUp = 4,
		Cancelled = 5
	}
}
