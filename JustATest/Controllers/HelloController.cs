using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JustATest
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: //helloworld
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" + 
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                     "<option value=''>Please Select an Option</option>" +
                     "<option value='English'>English</option>" +
                     "<option value='French'>Francais</option>" +
                     "<option value='Arabic'>Arabeya</option>" +
                     "<option value='Chinese'>ZhongWen</option>" +
                     "<option value='Spanish'>Espanol</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // POST: /helloworld
        [HttpPost("/helloworld")]
        public IActionResult Welcome(string name = "World", string language = "English")
        {
            return Content(CreateMessage(name, language), "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting = "";

            switch (language)
            {
                case "English":
                    greeting = "Hello, ";
                    break;
                case "French":
                    greeting = "Bonjour, ";
                    break;
                case "Arabic":
                    greeting = "Ahlan wa Sahlan, ";
                    break;
                case "Chinese":
                    greeting = "Ni Hao, ";
                    break;
                case "Spanish":
                    greeting = "Hola, ";
                    break;
                default:
                    greeting = "Hi, I'm the default case, ";
                    break;
            }

            return greeting + name;
        }
    }
}
