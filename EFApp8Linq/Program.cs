using EFApp8Linq.Data;
using EFApp8Linq.Models;
using Microsoft.EntityFrameworkCore;

namespace EFApp8Linq;

public class Program
{
    public static void Main()
    {
        DataDbContext data = new DataDbContext();
        var Products = data.Products;
        
        // Products.Add(new Product()
        // {
        //     Name = "Iphone 13 pro",
        //     Price = 240000
        // });
        // data.SaveChanges();

        // var products_where = Products.Where(x => x.Price > 230000).ToList();
 
        var products_select = Products.Select(x => new
        {
            Id=x.Id,
            Name=x.Name,
            Price=x.Price-30000
        });

        // var product_order = Products.OrderByDescending(x=>x.Name);

        var delete = Products.SingleOrDefault(x => x.Id == 2);
        {
            if (delete != null)
            {
                Products.Remove(delete);
            }
        }
        data.SaveChanges(); 
        
        foreach (var c in Products)
        {
            Console.WriteLine($"Id:{c.Id}\tName:{c.Name}\tPrice:{c.Price}");
        }
    }
}