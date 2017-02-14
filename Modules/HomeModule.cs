using Nancy;
using System.Collections.Generic;
using System.Text;
using System;
using LeetSpeak.Objects;

namespace LeetSpeakApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        string userInput = Request.Form["sentence"];
        char[] testList = userInput.ToCharArray();
        Translate testTranslate = new Translate(testList);
        string outputString = testTranslate.Rules();
        return View["results.cshtml",outputString];
      };
    }
  }
}
