using System;
namespace RandomChangeOfaConsecutiveGroupOfSymbols
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string FirstLine = "12345678";
            string SecondLine = "00000000";
            LineChange lineChange = new LineChange(FirstLine, SecondLine);
            Console.WriteLine(FirstLine + "\n" + SecondLine);
            string resultLine = lineChange.ReplacementSubstring();
            Console.WriteLine(resultLine);
            Console.ReadKey();           

        }
    }
}
