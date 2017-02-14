using Nancy;
using System.Collections.Generic;
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
        Translate testTranslate = new Translate(userInput);
        string outputString = testTranslate.Rules();
        return View["results.cshtml",outputString];
      };
    }
  }
}
