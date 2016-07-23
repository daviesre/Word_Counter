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
        return View["/wordcounter_generated.cshtml", newRepeat];
      };
      
    }
  }
}
