using Microsoft.EntityFrameworkCore;
using RetailInventoryex1.Data;

using var context = new AppDbContext();

// Retrieve all products
var products = await context.Products.ToListAsync();

Console.WriteLine("All Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// Find product by ID
var product = await context.Products.FindAsync(1);

Console.WriteLine();
Console.WriteLine($"Found Product: {product?.Name}");

// First product with price greater than 50000
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive Product: {expensive?.Name}");