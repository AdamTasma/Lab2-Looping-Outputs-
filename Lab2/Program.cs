using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2__integer_loops_
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Calculate(name);
        }

        public static void Calculate(string name) {
            Console.WriteLine("Please enter a number between 1 and 100");
            string strInput = Console.ReadLine();
            //Input Validation
            bool again = true;
            while (again == true)
                again = false;
                {
                int value;
                //while either (strInput is not a number) and (is not greater than one and less than 100) are true, run the block
                while (!(int.TryParse(strInput, out value) && ((int.Parse(strInput) > 1) && (int.Parse(strInput) < 100)))) 
                    {
                    Console.WriteLine("your input was not a number between 1 and 100. Please retry.");
                    strInput = Console.ReadLine();
                    again = true;
                    }
                    
                }
            //Output
            int input = Int32.Parse(strInput);
            //Even
            if (input % 2 == 0)
            {
                if (input < 25)
                {
                    Console.WriteLine("Even and less than 25 " + name);
                }
                else if (input < 60)
                {
                    Console.WriteLine("Even " + name);
                }
                else
                {
                    Console.WriteLine(input + " is Even " + name);
                }
            }
            //Odd
            else
            {
                Console.WriteLine(input + " is odd " + name);
            }
            //repeat
            Console.WriteLine("Would you like to continue? (y/n)");
            char repeat = char.Parse(Console.ReadLine().ToUpper());
            if (repeat.Equals(Char.Parse("Y")))
            {
                Calculate(name);
            }
            else
            {
                Console.WriteLine("Ok " + name + ", goodbye");
                Console.ReadLine();
            }
        }
    }
}
