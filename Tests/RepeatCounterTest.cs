using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounterTest
  {
    [Fact]
    public void LetterCount_ReturnsOneAfterInputLetter_ReturnsOne()
    {
      //Arrange
      char myLetter = 'A';
      //Act
      RepeatCounter myRepeatCounter = new RepeatCounter();
      char myLetterResult = myRepeatCounter.LetterCount(myLetter);
      //Assert
      Assert.Equal('2', myLetterResult);
    }


  }
}
