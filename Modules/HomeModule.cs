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
        string[] splitInput = userInput.ToCharArray().toString();
        List<string> inputList = new List<string>{splitInput};
        Translate inputTranslate = new Translate(inputList);
        List<string> outputList = inputTranslate.Rules();
        string outputString = "";
        // StringBuilder outputString = new StringBuilder();
        foreach (string letter in outputList)
        {
            outputString.Insert(0,letter);
        };
        return View["results.cshtml",outputString];
      };
    }
  }
}
