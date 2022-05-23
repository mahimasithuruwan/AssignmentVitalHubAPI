using AssignmentVitalHubAPI.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentVitalHubAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : ControllerBase
	{

		private readonly ILogger<ItemController> _logger;
		private readonly DataContext _context;
		public OrderController(DataContext context)
		{
			_context = context;
		}

		//public ItemController(ILogger<ItemController> logger)
		//{
		//	_logger = logger;
		//}

		[HttpGet]
		public async Task<ActionResult<List<Order>>> Get()
		{
			return Ok(await _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Items).ToListAsync());
		}
	}
}