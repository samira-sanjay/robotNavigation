using System;
using System.Collections.Generic;


namespace Codec_Techical
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the command string as a list"); //eg. FFRFLFLF 
            var consoleInput = Console.ReadLine();
            Console.WriteLine("Enter size of matrix");
            var size = Console.ReadLine();
            CurrentPosition currentPosition = new();
            
            char[] commandList = consoleInput.ToCharArray();
            
            currentPosition.NavigateRobot(commandList);
            Console.WriteLine(currentPosition.X);
            Console.WriteLine(currentPosition.Y);
            Console.WriteLine(currentPosition.Direction);

        }
    }
}
