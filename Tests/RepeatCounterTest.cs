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
      Assert.Equal('1', myLetterResult);
    }
    [Fact]
    public void WordCount_ReturnsOneAfterInputWord_ReturnsOne()
    {
      //Arrange
      string myWord = "cat";
      //Act
      RepeatCounter myRepeatCounter = new RepeatCounter();
      string myWordResult = myRepeatCounter.WordCount(myWord);
      //Assert
      Assert.Equal("1", myWordResult);
    }

  }
}
