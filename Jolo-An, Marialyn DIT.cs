using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textPosts = { "Cat, Dog, Rabbit, Cow, Sheep, Mouse, Chicken, Frog, Bird, Kangaroo" };

            for (int i = 0; i < textPosts.Length; i++)
            {
                Console.WriteLine(textPosts[i]);
                Console.WriteLine("Choose A or B: ");
                Console.WriteLine("a) React");
                Console.WriteLine("b) Skip");
                char input = Convert.ToChar(Console.ReadLine());

                if (input == 'a')
                {
                    Console.WriteLine("a) Like");
                    Console.WriteLine("b) Dislike");
                    char output = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("ADDED");
                }
                else if (input == 'b')
                {
                    Console.WriteLine("ADDED");
                }
                for (int i = 0; i < n - i; 1++)
                {
                    for (int j = 0; j < n - 1 - 1 ) ;
                }
            }
        }
    }
}