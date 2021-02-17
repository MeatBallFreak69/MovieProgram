using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Clark";
            string favMovie = "The Matrix.".ToUpper();

            Console.WriteLine($"Hello, my name is {firstName} and my favourite movie is {favMovie}".ToLower());
            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine($"Hello, my name is {firstName} and my favourite movie is {favMovie}".ToLower());
        }
    }
}
