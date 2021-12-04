using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookReadingEvent.Models;

namespace BookReadingEvent.Controllers
{
    public class ProductsController : Controller
    {
        BOOKDBEntities dbObj = new BOOKDBEntities();

        ProductsContext db = new ProductsContext();
        // GET: Products
        public ViewResult Index()
        {
            return View();
        }

       
        
    }
}