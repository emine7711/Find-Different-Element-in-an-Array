using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOfEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] est = { "x", "x", "x", "x", "x", "x", "x","y" };

            int a = 0;
            for (int i = 1; i <= est.Length; i++)
            {
                if (est[a]!=est[est.Length - i] && est[i]!= est[est.Length-i])
                {
                    a = est.Length - i;
                    break;
                }
                
            }
            Console.WriteLine("Farklı eleman " + (a) + ". indistedir.");
            Console.ReadLine();
        }
    }
}
