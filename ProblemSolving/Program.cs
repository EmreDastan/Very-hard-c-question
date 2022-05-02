using System;

namespace ProblemSolving
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second value: ");
            string input2 = Console.ReadLine();
            Console.WriteLine(Simplify(input1 + "/" + input2));

        }
        public static string Simplify(string str)
        {
            string[] words = str.Split('/');
            int a, b;
            string result = null;
            try
            {
                a = Convert.ToInt32(words[0]);
                b = Convert.ToInt32(words[1]);
                for (int i = 2; i < 20; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        a /= i;
                        b /= i;
                        i--;
                    }
                }
                string value1 = a.ToString();
                string value2 = b.ToString();
                if (b == 1)
                {
                    result = value1;
                }
                else
                {
                    result = value1 + "/" + value2;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " Please enter Integer values.");
            }
            return result;
        }
    }
}
