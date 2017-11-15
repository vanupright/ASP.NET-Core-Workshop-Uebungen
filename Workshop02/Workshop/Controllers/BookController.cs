using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Workshop.Controllers
{
    [Produces("application/json")]
    [Route("api/Book")]
    public class BookController : Controller
    {
        [HttpGet]
        public List<String> Index()
        {
            List<String> BookList = new List<String>();
            BookList.Add("Der Herr der Ringe - Die Gefährten, J. R. R. Tolkien");
            BookList.Add("Der Herr der Ringe - Die zwei Türme, J. R. R. Tolkien");
            BookList.Add("Der Herr der Ringe - Die Rückkehr des Königs, J. R. R. Tolkien");
            return BookList;
        }
    }


}