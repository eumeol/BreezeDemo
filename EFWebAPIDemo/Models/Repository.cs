using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using Breeze.ContextProvider.EF6;

namespace EFWebAPIDemo.Models
{
    public class Repository : IRepository
    {
        EFContextProvider<EFWebAPIDemoContext> BreezeCtxProvider
            = new EFContextProvider<EFWebAPIDemoContext>();    

        public string MetaData
        {
            get
            {
                return BreezeCtxProvider.Metadata();
            }
        
        }

        public IQueryable<Book> Books()
        {
            return BreezeCtxProvider.Context.Books;
        }

        public IQueryable<Order> Orders()
        {
            return BreezeCtxProvider.Context.Orders;
        }

        public SaveResult SaveChanges(JObject saveBundle)
        {
            return BreezeCtxProvider.SaveChanges(saveBundle);
        }
    }
}