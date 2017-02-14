using System.Collections.Generic;
using System;

namespace LeetSpeak.Objects
{
  public class Translate
  {//Declaring the only list in the class that we will be using
    private List<string> _input = new List<string>{};
    //Declaring the output list where the letters will be output to
    public List<string> output = new List<string>{};
    //Make new constructor
    public Translate(List<string> newList)  {
      _input = newList;
    }

    public string inputSplit
    {

    }
    //Make the "prototype"
    public List<string> Rules()
    {
      for (int i =0; i < _input.Count ;i++) {
        if(_input[i] == "e")
        {
          output.Add("3");
        }
        else if (_input[i] == "o" )
        {
          output.Add("0");
        }
        else if (_input[i] == "I")
        {
          output.Add("1");
        }
        else if (_input[i] == "s")
        {
          if(_input[ i - 1 ] == " ")
          {
            output.Add("s");
          }
          else
          {
            output.Add("z");
          }
        }
        else
        {
          output.Add(_input[i]);
        }
      }
    return output;
  }
}
}
