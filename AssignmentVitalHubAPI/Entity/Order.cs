using AssignmentVitalHubAPI.Entity.BaseEntity;

namespace AssignmentVitalHubAPI.Model.Entity
{
	public class Order : AggregateRoot<int>
	{
		public int? CustomerPhoneNo { get; set; }
		public int? DeliveryPersonPhoneNo { get; set; }

		public OrderThrough? OrderThroughId { get; set; }
		public OrderType? OrderTypeId { get; set; }
		public OrderStatus? OrderStatusId { get; set; }

		public virtual ICollection<OrderItem> OrderItems { get; set; }

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
