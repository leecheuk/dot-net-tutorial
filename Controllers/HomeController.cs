using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace webAppTutorial.Controllers
{
    public class ApiController : Controller
    {

        // GET; /api/
        public string Index()
        {
            return "You are at the api endpoint";
        }

        // GET; /api/Welcome
        public string Welcome(string name, int numTimes = 1) 
        {
            // add query string
            return HtmlEncoder.Default.Encode($"Hello {name}, welcome to api world! NumTimes is: {numTimes}");
        }
    }
}