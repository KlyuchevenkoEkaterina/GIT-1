using System;
namespace RandomChangeOfaConsecutiveGroupOfSymbols
{
    //This class includes fields, a constructor, and a method 
    //that allows to insert a random substring into a random position.
    class LineChanger
    {      
        public string firstLine { get; set; }
        public string secondLine { get; set; }
    
        public LineChanger(string FirstLine, string SecondLine)
        {
            firstLine = FirstLine;
            secondLine = SecondLine;
        }

        Random rand = new Random();
        //The method randomly selects a sequential group of symbols in one line, 
        //and replaces with another group of characters of the same length.
        public string ReplaceString()
        {
            int indexSubstringBegin = rand.Next(0, firstLine.Length);
            int lengthSubstring = rand.Next(1, firstLine.Length - indexSubstringBegin);
            int indexInsertSubstring = rand.Next(0, secondLine.Length - lengthSubstring);           

            string substring = firstLine.Substring(indexSubstringBegin, lengthSubstring);
            string resultLine = secondLine.Remove(indexInsertSubstring, lengthSubstring);
            resultLine = resultLine.Insert(indexInsertSubstring, substring);

            return resultLine;
        }
    }
}
