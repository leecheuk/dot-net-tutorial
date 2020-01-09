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
        public string Welcome() 
        {
            return "Welcome to api world";
        }
    }
}