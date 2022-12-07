using System;
using System.ComponentModel;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 123;
            bool sonuc = x.IsEventNumber();
            Console.WriteLine(sonuc);

            Console.WriteLine(faktoriyel(7));

        }

        public static int faktoriyel(int sayi)
        {
            if(sayi == 0 || sayi==1)
            {
                return 1;
            }
            else
            {
                return sayi*faktoriyel(sayi-1);
            }
        }

    }

    public static class MyExtensionClass
    {
        public static bool IsEventNumber(this int value)
        {
            if (value % 2 == 0)
                return true;
            else
                return false;
        }
    }

}