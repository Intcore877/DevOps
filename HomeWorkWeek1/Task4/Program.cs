using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int x = 2;
            int y = 50;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            swap(ref x, ref y);
            Console.WriteLine("After swap x = {0}, y = {1}", x, y);
            Console.ReadLine();
        }

        public static void swap(ref int par1, ref int par2)
        {
        int temp = par1;
        par1 = par2;
        par2 = temp;
        }

        public static void swap(ref double par1, ref double par2)
        {
            double temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref char par1, ref char par2)
        {
            char temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref float par1, ref float par2)
        {
            float temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref short par1, ref short par2)
        {
            short temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref long par1, ref long par2)
        {
            long temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref byte par1, ref byte par2)
        {
            byte temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref decimal par1, ref decimal par2)
        {
            decimal temp = par1;
            par1 = par2;
            par2 = temp;
        }

        public static void swap(ref string par1, ref string par2)
        {
            string temp = par1;
            par1 = par2;
            par2 = temp;
        }

    }
}
