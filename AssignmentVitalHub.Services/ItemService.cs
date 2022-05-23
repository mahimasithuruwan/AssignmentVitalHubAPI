using AssignmentVitalHubAPI.Data;
using AssignmentVitalHubAPI.DTO;
using Microsoft.EntityFrameworkCore;

namespace AssignmentVitalHub.Services
{
	public class ItemService : IItemService
	{
		private readonly DataContext _context;
		public ItemService(DataContext context)
		{
			_context = context;
		}

		public List<ItemDTO> GetAll()
		{
			throw new NotImplementedException();
		}
		//public async Task<List<ItemDTO>> GetAll()
		//{
		//var items = await _context.Items.ToListAsync();
		//return items;
		//}
	}
}
