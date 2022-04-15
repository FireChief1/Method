using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı gir");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            islemler islem =new islemler();
            islemler islem1 = new islemler();
            islem.topla(sayı, sayı1);
        }



        public class islemler
        {
            public int topla(int a, int b)
            {
                return a + b;
            }
            public int cikar(int a, int b)
            {
                return a - b;
            }
            public int çarp(int a, int b)
            {
                return a / b;
            }
            public double bol(int a, int b)
            {
                return a / b;
            }

            //ref tipi örnek 
            
        }
        public class islemler1
        {
            public int topla1(ref int a, ref int b)
            {
                return a + b;
            }
            public int cikar1(ref int a, ref int b)
            {
                return a - b;
            }
            public int çarp1(ref int a, ref int b)
            {
                return a / b;
            }
            public double bol1(ref int a, ref int b)
            {
                return a / b;
            }


        }
    }
}
