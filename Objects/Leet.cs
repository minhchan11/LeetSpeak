using System.Collections.Generic;
using System;
using System.Text;

namespace LeetSpeak.Objects
{
  public class Translate
  {
    private string _inputSentence;
    public char[] _input = new char[]{};
    StringBuilder outputString = new StringBuilder();

    public Translate(string inputSentence)  {
      _inputSentence = inputSentence;
      _input = inputSentence.ToCharArray();
    }

    //Make the "prototype"
    public string Rules()
    {
      for (int i =0; i < _input.Length ;i++) {
        if(_input[i] == 'e')
        {
          outputString.Append('3');
        }
        else if (_input[i] == 'o' )
        {
          outputString.Append('0');
        }
        else if (_input[i] == 'I')
        {
          outputString.Append('1');
        }
        else if (_input[i] == 's')
        {
          if(_input[ i - 1 ] == ' ')
          {
            outputString.Append('s');
          }
          else
          {
            outputString.Append('z');
          }
        }
        else
        {
          outputString.Append(_input[i]);
        }
      }
    return outputString.ToString();
  }
}
}
