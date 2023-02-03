using Microsoft.AspNetCore.Mvc;

namespace MVC_Application.Controllers
{
    public class BookController : Controller
    {
        public string Author()
        {
            return "Author - Sandeep";
        }
        public string GetAllBooks() {
            return "The Man without Gravity";
        }
        public string BookDetails(int i = 1)
        {
            return "book id:" + i;
        }
    }
}
