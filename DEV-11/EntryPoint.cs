using System;

namespace Transliteration
{
  //The entry point of the program.
  class EntryPoint
  {
    static void Main(string[] args)
    {
      const string CYRILLICWORD = "Привет";
      const string LATINWORD = "Chashka";

      CLtranslator cltranslator = new CLtranslator();
      string resultLatinWord = cltranslator.TranslateCyrillicWord(CYRILLICWORD);
      Console.WriteLine("Translation from cyrillic to latin: {0}", resultLatinWord);

      LCtranslator lctranslator = new LCtranslator();
      string resultCyrillicWord = lctranslator.TranslateLatinWord(LATINWORD);
      Console.WriteLine("Translation from latin to cyrillic: {0}", resultCyrillicWord);

      Console.ReadKey();
    }
  }
}
