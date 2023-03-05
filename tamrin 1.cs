using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ehsan Akbari Reshte IT Term2 Kardani 01111033334003

            Console.WriteLine("enter your score in number form!");
            int score = int.Parse(Console.ReadLine());

            if (score > 20 && score < 0)
            {
                Console.WriteLine("please enter a number between 0 and 20!");
                
            }

                 else if (score >= 0 && score <= 9)
                 {
                     Console.WriteLine("you couldn't get the expected score, try harder next time =D");
                 }

                 else if (score >= 10 && score <= 15)
                 {
                     Console.WriteLine("you got C! , it's not bad but not good either! try a lil harder next time ok?");
                 }

                 else if (score >= 16 && score <= 17)
                 {
                     Console.WriteLine("you got B! , you're getting better Nice!. stay sharp");
                 }

                 else if (score >= 18 && score <= 20)
                 {
                     Console.WriteLine("you got A! , can't get any better!. well done");
                 }







                Console.WriteLine("");
                Console.WriteLine("Press any key to close the app");
                Console.ReadKey();
        }
    }
}
