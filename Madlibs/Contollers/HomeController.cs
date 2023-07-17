using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index() { return View(); }

        // [Route("/form")]
        // [Route("/")]
        [Route("/cultForm")]
        public ActionResult CultForm() { return View(); }

        [Route("/cultMadlib")]
        public ActionResult CultMadlib(string[] noun, string[] verb, string[] adjective, string[] adverb)
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.Nouns = noun;
            myMadlibVariable.Verbs = verb;
            myMadlibVariable.Adjectives = adjective;
            myMadlibVariable.Adverbs = adverb;

            return View(myMadlibVariable);
        }

        [Route("/wizardForm")]
        public ActionResult WizardForm() { return View(); }

        [Route("/wizardMadlib")]
        public ActionResult WizardMadlib(string[] noun, string[] verb, string[] adjective, string[] adverb)
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.Nouns = noun;
            myMadlibVariable.Verbs = verb;
            myMadlibVariable.Adjectives = adjective;
            myMadlibVariable.Adverbs = adverb;

            return View(myMadlibVariable);
        }

        [Route("/meanGirlsForm")]
        public ActionResult MeanGirlsForm() { return View(); }

        [Route("/meanGirlsMadlib")]
        public ActionResult MeanGirlsMadlib(string[] noun, string[] verb, string[] adjective, string[] adverb)
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.Nouns = noun;
            myMadlibVariable.Verbs = verb;
            myMadlibVariable.Adjectives = adjective;
            myMadlibVariable.Adverbs = adverb;

            return View(myMadlibVariable);
        }
    }
}