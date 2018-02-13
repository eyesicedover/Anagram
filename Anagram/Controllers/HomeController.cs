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
            AnagramGenerator newAnagramGenerator = new AnagramGenerator("bread", "banana mouse butts");
            newAnagramGenerator.BreakString();
            List<List<string>> newListofLists = new List<List<string>> {};
            newAnagramGenerator.SplitCompareList();
            newListofLists = newAnagramGenerator.GetSplitCompareList();
            return View(newListofLists);
        }
    }
}
