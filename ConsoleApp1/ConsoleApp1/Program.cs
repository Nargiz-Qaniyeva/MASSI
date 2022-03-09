using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "CODE";
            string reverse = ""; //massivi tersden oxutma
            int length = str.Length - 1;

            for (int i = 0; i < length; i++) 
            {
                while (length >= 0) 
                {
                    reverse += str[length];
                    length-=1;   
                }
               
            }
            Console.WriteLine(reverse);


        }
    }
}
