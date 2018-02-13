using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            AnagramGenerator newAnagramGenerator = new AnagramGenerator("bread", "banana mouse");
            newAnagramGenerator.CreateCharList();
            return View(newAnagramGenerator.GetWordCharList());
        }
    }
}
