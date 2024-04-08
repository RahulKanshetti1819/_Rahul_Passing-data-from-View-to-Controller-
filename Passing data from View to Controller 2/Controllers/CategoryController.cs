using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Passing_data_from_View_to_Controller_2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            // List of Category
            //Lst we can Retrieve from Database

            List<Category> Category =
                new List<Category>()
                {
                    new Category(){Id=1, Name="Shirt",Rating=4},
                    new Category(){Id=2, Name="Shoes",Rating=5},
                    new Category(){Id=3, Name="Mobile",Rating=8},
                    new Category(){Id=4, Name="Balls",Rating=2}
                };


            return View(Category);
        }
    }
}