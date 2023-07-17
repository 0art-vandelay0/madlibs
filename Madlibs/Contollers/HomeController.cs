using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/finalMadlib")]
        public ActionResult FinalMadlib(string noun, string verb, string adjective, string adverb)
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.Noun = noun;
            myMadlibVariable.Verb = verb;
            myMadlibVariable.Adjective = adjective;
            myMadlibVariable.Adverb = adverb;
            return View(myMadlibVariable);
        }
    }
}