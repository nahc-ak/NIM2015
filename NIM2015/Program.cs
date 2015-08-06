using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIM2015
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;

            do
            {
                Console.Write("尻を 叩いて 下さい: ");
                str = Console.ReadLine();
                if (str.Equals("ッパーン"))
                {
                    Console.WriteLine("ほ～い");
                }
            }
            while (!str.Equals("exit"));
        }
    }
}
