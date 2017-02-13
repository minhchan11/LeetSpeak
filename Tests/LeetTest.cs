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
      List<string> testList = new List<string>{" ","s","a","s","a","e","o", "I", " ", "s","s"};
      Translate testTranslate = new Translate(testList);
      List<string> testResult = testTranslate.Rules();
      //Act
      List<string> verifyList = new List<string>{" ","s","a","z","a","3","0","1", " ", "s","z"};
      //Assert
      Assert.Equal(verifyList, testResult);
    }
  }
}
