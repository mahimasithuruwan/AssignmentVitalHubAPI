
using AssignmentVitalHubAPI.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace AssignmentVitalHubAPI.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Item> Items { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
	}
}
