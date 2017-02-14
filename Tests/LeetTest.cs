using Xunit;
using System.Collections.Generic;

namespace LeetSpeak.Objects
{
  public class TranslateTest
  {
    // test code here
    [Fact]
    public void Rules_charArray_True()
    {
      // Arrange
      string inputString = " sasaeo1 ss";
      Translate testTranslate = new Translate(inputString);
      string outputString = testTranslate.Rules();
      //Act
      string verifyString = " saza301 sz";
      //Assert
      Assert.Equal(outputString,verifyString);
    }
  }
}
