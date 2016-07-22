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
      int myResult = 1;
      //Act
      RepeatCounter myRepeatCounter = new RepeatCounter();
      int myLetterResult = myRepeatCounter.LetterCount(myLetter);
      //Assert
      Assert.Equal(myResult, myLetterResult);
    }

    [Fact]
    public void WordCount_ReturnsOneAfterInputWord_ReturnsOne()
    {
      //Arrange
      string myWord = "cat";
      int myResult = 1;
      //Act
      RepeatCounter myRepeatCounter = new RepeatCounter();
      int myWordResult = myRepeatCounter.WordCount(myWord);
      //Assert
      Assert.Equal(myResult, myWordResult);
    }

    [Fact]
    public void LetterAmount_ReturnsCorrectNumberAfterInputLetter_NumberOfLetters()
    {
      //Arrange
      string myLetters = "A";
      string mySentence = "A B C";
      int myResult = 1;
      //Act
      RepeatCounter myRepeatCounter = new RepeatCounter();
      int myLettersResult = myRepeatCounter.LetterAmount(myLetters, mySentence);
      //Assert
      Assert.Equal(myResult, myLettersResult);
    }


  }
}
