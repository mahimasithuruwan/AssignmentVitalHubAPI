using AssignmentVitalHubAPI.Entity.BaseEntity;

namespace AssignmentVitalHubAPI.Model.Entity

{
	public class Item : AggregateRoot<int>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public PortionSize? PortionSizeId { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
    public enum PortionSize
    {
        S = 1,
        M = 2,
        L = 3
    }
}
