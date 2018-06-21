using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace Booksdemo.Controllers
{
    [RoutePrefix("api/books")]
    public class BooksAPIController : ApiController
    {
        [Route("getbooks")]
        public IHttpActionResult GetBooks(string SearchString = "")
        {
            XDocument doc = XDocument.Load(Url.Content("~/DataSource/books.xml"));

            var FoundBooks = from cat in doc.Descendants("catalog")
                             from book in cat.Descendants("book")
                             select book;
            if (!string.IsNullOrEmpty(SearchString))
            {
                FoundBooks = from book in FoundBooks
                             where book.Element("title").Value.ToLower().Contains(SearchString.ToLower())
                             select book;
            }

            return Ok(FoundBooks);
        }
    }
}
