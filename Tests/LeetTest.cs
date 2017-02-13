using Xunit;
using System.Collections.Generic;

namespace LeetSpeak.Objects
{
  public class TranslateTest
  {
    // test code here
    [Fact]
    public void Rules_LetterE_True()
    {
      // Arrange
      List<string> testList = new List<string>{"a","e","o","I"," ","s","a","s"};
      Translate testTranslate = new Translate(testList);
      List<string> testResult = testTranslate.Rules();
      //Act
      List<string> verifyList = new List<string>{"a","3","0","1"," ","s","a","z"};
      //Assert
      Assert.Equal(verifyList, testResult);
    }
  }
}
