using System;
namespace RandomChangeOfaConsecutiveGroupOfSymbols
{   
    //The entry point of the program.
    class EntryPoint
    {
        const string FirstLine = "12345678";
        const string SecondLine = "00000000";
        //The method for calling a method from a class LineChanger
        //and outputting results to the console.
        static void Main(string[] args)
        {            
            LineChanger lineChanger = new LineChanger(FirstLine, SecondLine);
            Console.WriteLine(FirstLine + "\n" + SecondLine);
            string resultLine = lineChanger.ReplaceString();
            Console.WriteLine(resultLine);
            Console.ReadKey();        
        }
    }
}
