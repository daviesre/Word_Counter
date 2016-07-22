using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    //Methods
    public int LetterCount(char myLetter)
    {
      return 1;
    }

    public int WordCount(string myWord)
    {
      return 1;
    }

    public int LetterAmount(string inputletter, string sentence)
    {
      string[] lettersArray = sentence.Split(' ');
      int numberOfLetter = 0;

      foreach(var letter in lettersArray)
      {
        if (letter == inputletter)
        {
          numberOfLetter++;
        }
      }
      return numberOfLetter;
    }

  }
}
