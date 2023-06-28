using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Bookstore.ConsoleApp;

internal class AppDbContext : DbContext
{
	// public static readonly ILoggerFactory _loggerFactory = new NLogLoggerFactory();

	public DbSet<Book> Books { get; set; }
	public DbSet<Category> Categories { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
		var config = builder.Build();
		optionsBuilder
			// .UseLoggerFactory(_loggerFactory)
			.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
			.EnableSensitiveDataLogging()
			.UseSqlServer(config["ConnectionString"]);
	}
}