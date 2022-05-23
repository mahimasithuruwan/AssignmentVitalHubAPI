using AssignmentVitalHubAPI.DTO;

namespace AssignmentVitalHub.Services
{
	public interface IOrderService
	{
		List<OrderDTO> GetAll();

		bool AddOrder(OrderDTO order);

		bool UpdateOrder(OrderDTO order);
	}
}
