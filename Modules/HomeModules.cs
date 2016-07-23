using Nancy;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/wordcounter_generated"] = _ =>
      {
        RepeatCounter newRepeat = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        string newString1 = newRepeat.GetWord();
        string newString2 = newRepeat.GetSentence();
        int newInt = newRepeat.CountRepeats(newString1, newString2);
        return View["/wordcounter_generated.cshtml", newRepeat];
      };

    }
  }
}
