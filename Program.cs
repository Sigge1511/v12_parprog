using Microsoft.EntityFrameworkCore;

namespace v12_parprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consolemanager = new ConsoleManager();
            consolemanager.Run();

            //var tandkräm = new Product();
            //tandkräm.ProductName = "Tandkräm";
            //var Customer1 = new Customer() 
            //{ 
            //    Name = "Maja Sigfeldt"            
            //};
            //var Order1 = new Order()
            //{
            //    Customer = dbctx.Customers.Single<Customer>(c => c.CustomerId == 1),
            //    Date = DateTime.Today,
            //    TotalPrice = 56987.64
            //};
            //var row1 = new OrderRow() 
            //{
            //    Order = dbctx.Orders.Single<Order>(o => o.OrderId == 1),
            //    Product = dbctx.Products.Single<Product>(o => o.ProductId == 2),
            //    Amount = 2,
            //    UnitPrice = 20,
            //    RowPrice = 40
            //};
            //dbctx.Add(row1);
            //var row2 = new OrderRow()
            //{
            //    Order = dbctx.Orders.Single<Order>(o=>o.OrderId==1),
            //    Product = dbctx.Products.Single<Product>(o => o.ProductId == 1),
            //    Amount = 3,
            //    UnitPrice = 19.90,
            //    RowPrice = 59.70
            //};
            //dbctx.Add(row2);
            //var row3 = new OrderRow()
            //{

            //};


            //dbctx.Add(row3);
            //dbctx.SaveChanges();


            //Denna bråkar då kan inte kan nestla loopar på detta sätt,
            //readern vill bara göra en sak från databasen åt gången och inte be om något nytt mitt i en foreachloop 
            //foreach (var c in dbctx.Customers
            //    .Include(c => c.Orders)
            //    .ThenInclude(c=>c.OrderRows))
            //{
            //    Console.WriteLine($"Kundnamn: {c.Name}");
            //    foreach (var o in dbctx.Orders) 
            //    {
            //        Console.WriteLine($"  Ordernummer: {o.OrderId}, totalpris {o.TotalPrice}");

            //        foreach (var p in dbctx.OrderRows) 
            //        {
            //            Console.WriteLine(p.Product.ProductName);
            //        }
            //    }
            //}


            //Genom att lägga till ToList() efter min db query så sparas det
            //lokalt i minnet och jag kan nestla loopar med frågor - YAY!
            //foreach (var c in dbctx.Customers
            //    .Include(c => c.Orders)
            //    .ThenInclude(c => c.OrderRows)
            //    .ThenInclude(c=>c.Product)
            //    .ToList())
            //{
            //    Console.WriteLine($"Kundnamn: {c.Name}");

            //    //loopa inte igenom context, nestlad loop använder lilla lokala variablen, tex "c"
            //    foreach (var o in c.Orders.ToList())
            //    {
            //        Console.WriteLine($"  Ordernummer: {o.OrderId}\nTotalpris {o.TotalPrice} kronor.");
            //        Console.WriteLine("\nVaror:");
            //        foreach (var p in o.OrderRows) 
            //        {
            //            Console.WriteLine(p.Product.ProductName);
            //        }
            //    }
            //}



        }
    }
}
