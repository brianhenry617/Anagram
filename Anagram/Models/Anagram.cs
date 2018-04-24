using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Anagram
  {
    private string _word;
    private string _newWord;
    private static _List<word> _instances = new List<word> {};

    public Anagram (string word, string newWord)
    {
      _word = word;
      _newWord = newWord;
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string word)
    {
      return _newWord;
    }
  }
}
