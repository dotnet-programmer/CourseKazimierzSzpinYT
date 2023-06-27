using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Bookstore.ConsoleApp;

internal class AppDbContext : DbContext
{
	public DbSet<Book> Books { get; set; }
	public DbSet<Category> Categories { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
		var config = builder.Build();
		optionsBuilder.UseSqlServer(config["ConnectionString"]);
	}
}
