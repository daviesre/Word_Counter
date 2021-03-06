using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    //properties
    private string _word;
    private string _sentence;
    private int _numberOfWords;

    //construcor
    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    //Getters and Setters
    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string inputword)
    {
      _word = inputword;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string inputsentence)
    {
      _sentence = inputsentence;
    }

    public int GetNumber()
    {
      return _numberOfWords;
    }

    //Methods

    public int LetterCount()
    {
      string inputletter = this.GetWord();
      string inputsentence = this.GetSentence();
      return 1;
    }

    public int WordCount()
    {
      string inputletter = this.GetWord();
      string inputsentence = this.GetSentence();
      return 1;
    }
    //
    public int LetterAmount()
    {
      string inputletter = this.GetWord();
      string inputsentence = this.GetSentence();
      string[] lettersArray = inputsentence.Split(' ');
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

    public int CountRepeats()
    {
      string inputword = this.GetWord();
      string inputsentence = this.GetSentence();

      inputsentence=inputsentence.Replace("!","");
      inputsentence=inputsentence.Replace("?","");
      inputsentence=inputsentence.Replace(".","");
      inputsentence=inputsentence.Replace(",","");
      inputsentence=inputsentence.Replace(";","");
      inputsentence=inputsentence.Replace(":","");
      inputsentence=inputsentence.Replace("-","");

      string noCaps = inputsentence.ToLower();
      string noCapsWord = inputword.ToLower();
      string[] wordArray = noCaps.Split(' ');

      foreach(var word in wordArray)
      {
        if (word == noCapsWord)
        {
          _numberOfWords++;
        }
      }
      return _numberOfWords;
    }
  }
}
