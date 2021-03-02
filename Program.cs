using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie2
{

   
    class Program
    {
        public static  List<int> l_pierwsze = new List<int>();
        public static void generuj_l_pierwsze()
        {
            int l_dzielnikow = 0;
            for (int i = 120; i < 150; i++)
            {
                
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        l_dzielnikow++;
                    }
                }

                if (l_dzielnikow == 2)
                {
                    l_pierwsze.Add(i);
                    l_dzielnikow = 0;
                }
                else
                {
                    l_dzielnikow = 0;
                }


            }
        }
        static void Main(string[] args)
        {
            generuj_l_pierwsze();
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {

                int strings = int.Parse(Console.ReadLine());
                int[] values = new int[strings];
                string wartosci = Console.ReadLine();
                string[] wartosciStr = wartosci.Split(' ');

                for(int j = 0; j < strings; j++)
                {
                    values[j] = int.Parse(wartosciStr[j]);
                }

                int klucz = 0;
                foreach (var item in l_pierwsze)
                {
                    bool spelnia = false;
                    for(int k = 0; k < values.Length; k++)
                    {
                        if(values[k]%item>=65 && values[k] % item <= 90)
                        {
                            spelnia = true;
                        }
                        else
                        {
                            spelnia = false;
                            break;
                        }
                        if (spelnia == true)
                        {
                            klucz = item;
                            break;
                        }
                    }
                }
                if (klucz != 0)
                {
                    char[] znaki = new char[values.Length];
                    Console.Write(klucz+" ");
                    
                    for(int m = 0; m < values.Length; m++)
                    {
                        znaki[m] = (char)(values[m] % klucz);
                        Console.Write(znaki[m]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("NIECZYTELNE");
                }
                

            }
            Console.ReadKey();




        }
    }
}
