using Nancy;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => return View["index.cshtml"];

    }
  }
}
