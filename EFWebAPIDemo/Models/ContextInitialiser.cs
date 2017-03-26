using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFWebAPIDemo.Models
{
    public class ContextInitialiser : DropCreateDatabaseAlways<EFWebAPIDemoContext>
    {
        protected override void Seed(EFWebAPIDemoContext context)
        {
            var books = new List<Book>
            {
                new Book() { Name="War and Peace", Author="Tolstoy", Price=19.00m, Id=1},
                new Book() { Name="Catch-22", Author="Heller", Price=189.00m, Id=2},
                new Book() { Name="Cather in the Rye", Author="Salinger", Price=59.00m, Id=3},
                new Book() { Name="Tess D'uvervilles", Author="Hardy", Price=189.00m, Id=4},
                new Book() { Name="Oliver", Author="Dickens", Price=89.00m, Id=5},
                new Book() { Name="Generation X", Author="Coupland", Price=19.00m, Id=6},
                new Book() { Name="Harry Potter", Author="Rowling", Price=139.00m, Id=7},
                new Book() { Name="Dracula", Author="Stoker", Price=139.00m, Id=8}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            //first order
            var order = new Order() { Customer = "John", OrderDate = DateTime.Now};
            var details = new List<OrderDetail>()
            {
                new OrderDetail() { Book=books[0], Quantity=3,Order=order},
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[3], Quantity=4,Order=order}
            };

            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            //second order
            order = new Order() { Customer = "Mark", OrderDate = DateTime.Now };
            details = new List<OrderDetail>()
            {
                new OrderDetail() { Book=books[0], Quantity=3,Order=order},
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[3], Quantity=4,Order=order}
            };

            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            //third order
            order = new Order() { Customer = "Eugene", OrderDate = DateTime.Now };
            details = new List<OrderDetail>()
            {                
                new OrderDetail() { Book=books[4], Quantity=1,Order=order},
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[1], Quantity=4,Order=order}
            };

            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            //fourth order
            order = new Order() { Customer = "Ortiz", OrderDate = DateTime.Now };
            details = new List<OrderDetail>()
            {                
                new OrderDetail() { Book=books[3], Quantity=1,Order=order},
                new OrderDetail() { Book=books[4], Quantity=4,Order=order}
            };

            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            //fifth order
            order = new Order() { Customer = "Lazarte", OrderDate = DateTime.Now };
            details = new List<OrderDetail>()
            {
                new OrderDetail() { Book=books[5], Quantity=1,Order=order},
                new OrderDetail() { Book=books[6], Quantity=1,Order=order},
                new OrderDetail() { Book=books[5], Quantity=1,Order=order}
            };

            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));


            base.Seed(context); 
        }

    }
}