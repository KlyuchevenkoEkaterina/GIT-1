namespace Transliteration
{
  //This class used to initialize string arrays with Latin and Cyrillic letters and
  //call the method that translates word from Latin to Cyrillic.
  class LCtranslator
  {
    string[] latinletters = { "a", "b", "v", "g", "d", "e","z", "i", "y", "k", "l", "m", "n", "о","p", "r", "s", "t", "u", "f","y", "e", "'",
                              "A", "B", "V", "G", "D", "E","Z", "I", "Y", "K", "L", "M", "N", "O","P", "R", "S", "T", "U", "F","Y", "E","'"};
    string[] cyrillicletters = { "а", "б", "в", "г", "д", "е","з", "и", "й", "к", "л", "м", "н", "o","п", "р", "с", "т", "у", "ф","ы", "э","ь",
                                 "А", "Б", "В", "Г", "Д", "Е","З", "И", "Й", "К", "Л", "М", "Н", "О","П", "Р", "С", "Т", "У", "Ф","Ы", "Э","Ь"};

    //The method that translates word from Latin to Cyrillic.
    public string TranslateLatinWord(string word)
    {
      for (int i = 0; i < latinletters.Length; i++)
      {
        for (int j = 0; j < cyrillicletters.Length; j++)
        {

          if (word.Contains(latinletters[j]))
          {
            word = word.Replace(latinletters[j], cyrillicletters[j]);
          }
          if (word.Contains("shch") || word.Contains("SHCH") || word.Contains("Shch"))
          {
            word = word.Replace("shch", "щ");
            word = word.Replace("SHCH", "Щ");
            word = word.Replace("Shch", "Щ");

          }
          if (word.Contains("sh") || word.Contains("SH") || word.Contains("Sh"))
          {
            word = word.Replace("sh", "ш");
            word = word.Replace("SH", "Ш");
            word = word.Replace("Sh", "Ш");
          }
          if (word.Contains("ch") || word.Contains("CH") || word.Contains("Ch"))
          {
            word = word.Replace("ch", "ч");
            word = word.Replace("CH", "Ч");
            word = word.Replace("Ch", "Ч");
          }
          if (word.Contains("ts") || word.Contains("TS") || word.Contains("Ts"))
          {
            word = word.Replace("ts", "ц");
            word = word.Replace("TS", "Ц");
            word = word.Replace("Ts", "Ц");
          }
          if (word.Contains("kh") || word.Contains("KH") || word.Contains("Kh"))
          {
            word = word.Replace("kh", "х");
            word = word.Replace("KH", "Х");
            word = word.Replace("Kh", "Х");
          }
          if (word.Contains("zh") || word.Contains("ZH") || word.Contains("Zh"))
          {
            word = word.Replace("zh", "ж");
            word = word.Replace("ZH", "Ж");
            word = word.Replace("Zh", "Ж");
          }
          if (word.Contains("ye") || word.Contains("YE") || word.Contains("Ye"))
          {
            word = word.Replace("ye", "ё");
            word = word.Replace("YE", "Ё");
            word = word.Replace("Ye", "Ё");
          }
          if (word.Contains("yu") || word.Contains("YU") || word.Contains("Yu"))
          {
            word = word.Replace("yu", "ю");
            word = word.Replace("YU", "Ю");
            word = word.Replace("Yu", "Ю");
          }
          if (word.Contains("ya") || word.Contains("YA") || word.Contains("Ya"))
          {
            word = word.Replace("ya", "я");
            word = word.Replace("YA", "Я");
            word = word.Replace("Ya", "Я");
          }
        }
      }
      return word;
    }
  }
}
