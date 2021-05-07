using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace ConsoleApp1
{
    class Program
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int ziplamaSayisi = 0, sayac = 0;
            while (true)
            {
                if (c[sayac] != 1)
                {
                    if (c.Count - (sayac + 1) > 1)
                    {
                        if (c[sayac] == c[sayac + 1] && c[sayac] != c[sayac + 2])
                        {
                            ziplamaSayisi++;
                            sayac++;
                            if (c[sayac] == 1) sayac++;
                        }
                        else if (c[sayac] == c[sayac + 2])
                        {
                            ziplamaSayisi++;
                            sayac += 2;
                            if (c[sayac] == 1) sayac++;
                        }
                    }
                    else
                    {
                        if (c[sayac] == c[sayac + 1])
                        {
                            ziplamaSayisi++;
                            sayac++;
                            if (c[sayac] == 1) sayac++;
                        }

                    }
                }
                if (c.Count == sayac + 1)
                    break;
            }
            return ziplamaSayisi;
        }
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 2 || n > 100)
            {
                Console.Write("n : ");
                n = Convert.ToInt32(Console.ReadLine().Trim());
                if (n >= 2 && n <= 100) break;
            }

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = jumpingOnClouds(c);
            Console.WriteLine("Jumping : " + result);
            Console.Read();
        }
    }
}
