using AssignmentVitalHubAPI.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentVitalHubAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ItemController : ControllerBase
	{

		private readonly ILogger<ItemController> _logger;
		private readonly DataContext _context;

		public ItemController(DataContext context)
		{
			_context = context; 
		}

		//public ItemController(ILogger<ItemController> logger)
		//{
		//	_logger = logger;
		//}

		[HttpGet]
		public async Task<ActionResult<List<Item>>> Get()
		{
			return Ok(await _context.Items.ToListAsync()); 

		}
	}
}