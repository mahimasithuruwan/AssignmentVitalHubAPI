using AssignmentVitalHubAPI.Entity.BaseEntity;


namespace AssignmentVitalHubAPI.Model.Entity
{
	public class OrderItem : AggregateRoot<int>
	{
		public int OrderId { get; set; }
		public Order Orders { get; set; }
		public int ItemId { get; set; }
		public Item Items { get; set; }
		public int Quantity { get; set; }
	}
}
