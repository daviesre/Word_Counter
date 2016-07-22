using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    //properties
    private string _word;
    private string _sentence;

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

    public void SetWord(string newword)
    {
      _word = newword;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string newsentence)
    {
      _sentence = newsentence;
    }

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

    public int CountRepeats(string inputword, string sentence)
    {
      sentence=sentence.Replace("!","");
      sentence=sentence.Replace("?","");
      sentence=sentence.Replace(".","");
      sentence=sentence.Replace(",","");
      sentence=sentence.Replace(";","");
      sentence=sentence.Replace(":","");
      sentence=sentence.Replace("'","");
      sentence=sentence.Replace("-","");
      sentence=sentence.Replace("(","");
      sentence=sentence.Replace(")","");
      sentence=sentence.Replace("{","");
      sentence=sentence.Replace("}","");
      sentence=sentence.Replace("[","");
      sentence=sentence.Replace("]","");

      string noCaps = sentence.ToLower();
      string noCapsWord = inputword.ToLower();
      string[] wordArray = noCaps.Split(' ');
      int numberOfWords = 0;

      foreach(var word in wordArray)
      {
        if (word == noCapsWord)
        {
          numberOfWords++;
        }
      }
      return numberOfWords;
    }
  }
}
