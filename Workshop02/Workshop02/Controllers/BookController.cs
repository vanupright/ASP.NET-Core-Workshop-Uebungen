using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workshop02.Controllers
{
    public class BookController : Controller
    {
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}

        public List<String> Books()
        {
            List<String> BookList = new List<String>();
            BookList.Add("Der Herr der Ringe - Die Gefährten, J. R. R. Tolkien");
            BookList.Add("Der Herr der Ringe - Die zwei Türme, J. R. R. Tolkien");
            BookList.Add("Der Herr der Ringe - Die Rückkehr des Königs, J. R. R. Tolkien");
            return BookList;
        }
    }
}
