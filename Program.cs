using Microsoft.EntityFrameworkCore;

namespace v12_parprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbctx = new ShopCntxt();

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

            foreach (var c in dbctx.Customers) 
            {
                Console.WriteLine($"Kundnamn: {c.Name}");
                foreach (var o in dbctx.Orders) 
                {
                    Console.WriteLine($"ID: {o.OrderId}, totalpris {o.TotalPrice}");
                }
            }



        }
    }
}
