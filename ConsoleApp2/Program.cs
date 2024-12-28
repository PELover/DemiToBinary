using System;
using System.Reflection.Emit;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;          
            List<string> str = new List<string>();
            string firstnum;
            int num;
            int nummod;
            while (true)
            {
                Console.Write("Please insert Demical Number : ");
                firstnum = Console.ReadLine();
                b = int.TryParse(firstnum, out num);
                if(!b == false)
                {
                    break;
                }
            }
            nummod = num;
            int inputnum = num;
            while (true)
            {
                if(num != 1 && num != 0)
                {
                    str.Add((nummod % 2).ToString());
                    num /= 2;
                    nummod = num;
                }
                else
                {
                    str.Add("1");
                    break;
                }
            }
            string strn = String.Join("", str);
            string answer = new string(strn.Reverse().ToArray());
            Console.WriteLine($"Your demical number {inputnum} Convert to binary = {answer}");
            Console.ReadKey();
        }
    }
}