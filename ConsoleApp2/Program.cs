
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float baseNum;
            Console.Write("Enter the number: ");
           bool isConverted= float.TryParse(Console.ReadLine(),out baseNum);
            if (isConverted)
            {
                for (int num = 1; num <= 12; num++)
                {
                    string str;
                    str = baseNum + "x" + num + " = ";
                    float r = baseNum * num;
                    Console.WriteLine(str + r);

                }
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
            Console.ReadLine();
        }
    }
}