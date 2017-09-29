using System;
namespace RandomChangeOfaConsecutiveGroupOfSymbols
{
    class LineChange
    {      
        public string firstLine { get; set; }
        public string secondLine { get; set; }
    

        public LineChange(string FirstLine, string SecondLine)
        {
            firstLine = FirstLine;
            secondLine = SecondLine;
        }

        Random rand = new Random();
        //The method randomly selects a sequential group of symbols in one line, 
        //and replaces with another group of characters of the same length.
        public string ReplacementSubstring()
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
