using AssignmentVitalHubAPI.DTO;

namespace AssignmentVitalHub.Services
{
	public interface IOrderItemService
	{
		bool AddOrderItem(OrderItemDTO order);
	}
}
