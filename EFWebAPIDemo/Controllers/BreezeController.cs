using Breeze.ContextProvider;
using Breeze.WebApi2;
using EFWebAPIDemo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EFWebAPIDemo.Controllers
{
    [BreezeController]
    public class BreezeController : ApiController
    {
        IRepository repo;

        public BreezeController(IRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public string Metadata()
        {
            return repo.MetaData;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return repo.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<Book> Books()
        {
            return repo.Books();
        }

        [HttpGet]
        public IQueryable<Order> Orders()
        {
            return repo.Orders();
        }
    }
}