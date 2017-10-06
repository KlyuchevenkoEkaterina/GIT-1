using System.Collections.Generic;

namespace Transliteration
{
  //This class used to initialize the dictionary and
  //call the method that translates word from Cyrillic to Latin.
  class CLtranslator
  {
    Dictionary<string, string> dictionaryCL = new Dictionary<string, string>()
    {
      { "a", "а" },
      { "б", "b" },
      { "в", "v" },
      { "г", "g" },
      { "д", "d" },
      { "е", "e" },
      { "ё", "ye"},
      { "ж", "zh" },
      { "з", "z" },
      { "и", "i" },
      { "й", "y" },
      { "к", "k"},
      { "л", "l" },
      { "м", "m" },
      { "н", "n" },
      { "о", "o" },
      { "п", "p" },
      { "р", "r" },
      { "с", "s" },
      { "т", "t" },
      { "у", "u" },
      { "ф", "f" },
      { "х", "kh" },
      { "ц", "ts" },
      { "ч", "ch" },
      { "ш", "sh" },
      { "щ", "shch" },
      { "ы", "y" },
      { "э", "e" },
      { "ю", "yu" },
      { "я", "ya" },
      { "ъ", "'" },
      { "ь", "'" },
      { "А", "A" },
      { "Б", "B" },
      { "В", "V" },
      { "Г", "G" },
      { "Д", "D" },
      { "Е", "E" },
      { "Ё", "YE"},
      { "Ж", "ZH" },
      { "З", "Z" },
      { "И", "I" },
      { "Й", "Y" },
      { "К", "K"},
      { "Л", "L" },
      { "М", "M" },
      { "Н", "N" },
      { "О", "O" },
      { "П", "P" },
      { "Р", "R" },
      { "С", "S" },
      { "Т", "T" },
      { "У", "U" },
      { "Ф", "F" },
      { "Х", "KH" },
      { "Ц", "TS" },
      { "Ч", "CH" },
      { "Ш", "SH" },
      { "Щ", "SHCH" },
      { "Ы", "Y" },
      { "Э", "E" },
      { "Ю", "YU" },
      { "Я", "YA" },
      { "Ъ", "'" },
      { "Ь", "'" },
    };

    //The method that translates word from Cyrillic to Latin.
    public string TranslateCyrillicWord(string word)
    {
      string resultWord = word;
      foreach (KeyValuePair<string, string> key in dictionaryCL)
      {
        resultWord = resultWord.Replace(key.Key, key.Value);
      }
      return resultWord;
    }
  }
}
