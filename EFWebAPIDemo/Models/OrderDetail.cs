namespace EFWebAPIDemo.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        //link  this orderdetail to an order id
        public int OrderId { get; set; }
        //link this orderdetail to the book 
        public int BookId { get; set; }

        //navigate 
        //virtual keyword means that entities will be lazy loaded 
        //versus eager and explicit loading.
        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}