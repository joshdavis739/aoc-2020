using System;

namespace Day_6
{
    class Program
    {
        static void Main()
        {
            var input = Inputs.FullInput;
            var parser = new AnswerParser();
            Console.WriteLine(parser.GetCountForInput(input));
        }
    }
}
