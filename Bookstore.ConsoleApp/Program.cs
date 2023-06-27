using Bookstore.ConsoleApp;
using Microsoft.EntityFrameworkCore;

List<Book> books = new();

var book = new Book { Name = "Książka 1", Price = 10 };
using (AppDbContext context = new())
{
	await context.Books.AddAsync(book);
	await context.SaveChangesAsync();
	books = await context.Books.ToListAsync();
}

foreach (var item in books)
{
    Console.WriteLine($"Id: {item.Id}. Książka: {item.Name} - {item.Price:0.00} PLN.");
}

using (AppDbContext context = new())
{
	var bookToUpdate = await context.Books.FindAsync(35009);
	bookToUpdate.Price = 99;
	await context.SaveChangesAsync();
	books = await context.Books.ToListAsync();
}

foreach (var item in books)
{
	Console.WriteLine($"Id: {item.Id}. Książka: {item.Name} - {item.Price:0.00} PLN.");
}

using (AppDbContext context = new())
{
	context.Books.Remove(new Book { Id = 35010 });
	await context.SaveChangesAsync();
	books = await context.Books.ToListAsync();
}

foreach (var item in books)
{
	Console.WriteLine($"Id: {item.Id}. Książka: {item.Name} - {item.Price:0.00} PLN.");
}