using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace myC_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] x = { "barev", "vonces", "lav" };
            //string[] y = { "hajox", "bari", "gisher" };
            //string[] r = GetLongestStrings(x,y);
            //for (int i = 0; i < r.Length; i++)
            //{
            //    Console.WriteLine(r[i]);
            //}
            //Faktorial(5);
            //Bazmapatkum(5);
            //Fibunachi(7);
            //Hakarak(1234);
            //Qanak(654321);
            //Gumar(5555);
            Prime(7);
            //Armstrong(371);
            //Piramida(5);
            //Sezon(11);
            //char c = Convert.ToChar(Console.ReadLine());
            //Dzaynavor(c);
            //Gnahatakan(c);
            //Zuyg(67);
            //Stugel(-8);
            //Visakosni(2016);
            //Aravelaguyn(77, 34, 99);
            //Gnahatakan2(77);
            Console.ReadLine();
        }
        public static string[] GetLongestStrings(string[] arr1, string[] arr2)
        {
            int arr1Length = GetLongestWordLength(arr1);
            int arr2Length = GetLongestWordLength(arr2);
            int longest = arr1Length >= arr2Length ? arr1Length : arr2Length;
            string[] longestFromArr1 = GetLongestElements(arr1, longest);
            string[] longestFromArr2 = GetLongestElements(arr2, longest);
            string[] finalArray = new string[longestFromArr1.Length + longestFromArr2.Length];
            for (int i = 0; i < longestFromArr1.Length; i++)
            {
                finalArray[i] = longestFromArr1[i];
                finalArray[i + 1] = longestFromArr2[i];
                break;
            }
            return finalArray;
        }
        public static string[] GetLongestElements(string[] arr, int length)
        {
            string[] newArr = new string[arr.Length];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == length)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            return newArr;
        }
        public static int GetLongestWordLength(string[] arr)
        {
            int length = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > length)
                {
                    length = arr[i].Length;
                }
            }
            return length;
        }
        public static void Faktorial(int x)
        {//1
            int c = 1;
            for (int i = 1; i <= x; i++)
            {
                c *= i;
                Console.WriteLine(c);
            }
        }
        public static void Bazmapatkum(int x)
        {//2
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(x * i);
            }
        }
        public static void Fibunachi(int x)
        {//3
            int z = 0;
            int z1 = 1;
            int z2 = 0;
            Console.WriteLine(z);
            Console.WriteLine(z1);
            for (int i = 1; i <= x; i++)
            {
                z2 = z1 + z;
                Console.WriteLine(z2);
                z = z1;
                z1 = z2;
            }
        }
        public static void Hakarak(int x)
        {//4
            int c = 0;
            int z = 0;
            for (int i = 0; i < x;)
            {
                z = x % 10;
                c = x / 10;
                x = c;
                Console.Write(z);
            }

        }
        public static void Qanak(int x)
        {//5
            int num = 0;
            int c = 0;
            int t = 0;
            for (int i = 0; i < x; i++)
            {
                num = x % 10;
                c = x / 10;
                x = c;
                t++;

            }
            Console.WriteLine(t);
        }
        public static void Gumar(int x)
        {//6
            int c = 0;
            int z = 0;
            for (int i = 0; i < x;)
            {
                z += x % 10;
                c = x / 10;
                x = c;

            }
            Console.Write(z);

        }
        public static void Prime(int x)
        {//7
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(false);
                    break;
                }
                Console.WriteLine(true);
                break;
            }
        }
        public static void Armstrong(int x)
        {//8

        }
        public static void Piramida(int x)
        {//9
            int y = x;
            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    Console.Write(" ");

                }
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                y--;
            }
        }
        public static void Sezon(int x)
        {//10
            switch (x)
            {
                case 1:
                    Console.WriteLine("dzmer hunvar");
                    break;
                case 2:
                    Console.WriteLine("dzmer petrvar");
                    break;
                case 12:
                    Console.WriteLine("dzmer dektember");
                    break;
                case 3:
                    Console.WriteLine("garun mart");
                    break;
                case 4:
                    Console.WriteLine("garun april");
                    break;
                case 5:
                    Console.WriteLine("garun mayis");
                    break;
                case 6:
                    Console.WriteLine("amar hunis");
                    break;
                case 7:
                    Console.WriteLine("amar hulis");
                    break;
                case 8:
                    Console.WriteLine("amar ogostos");
                    break;
                case 9:
                    Console.WriteLine("ashun september");
                    break;
                case 10:
                    Console.WriteLine("ashun hoktember");
                    break;
                case 11:
                    Console.WriteLine("ashun noyember");
                    break;
                default: Console.WriteLine("sxal"); break;
            }
        }
        public static void Dzaynavor(char x)
        {//11
            string a = "AaEeIiOoUu";
            string s = "QqWwRrTtYyPpSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm";
            for (int i = 0; i <= s.Length; i++)
            {
                if (a.Contains(x))
                {
                    Console.WriteLine("dzaynavor");
                    break;
                }
                else if (s.Contains(x))
                {
                    Console.WriteLine("baxadzayn");
                    break;
                }
            }
        }
        public static void Gnahatakan(char x)
        {//12
            switch (x)
            {
                case 'a':
                    Console.WriteLine("amazing");
                    break;
                case 'f':
                    Console.WriteLine("fool");
                    break;
                case 'g':
                    Console.WriteLine("good");
                    break;
                case 'v':
                    Console.WriteLine("veri good");
                    break;
                case 'e':
                    Console.WriteLine("exselent");
                    break;
                default:
                    Console.WriteLine("sxala");
                    break;
            }
        }
        public static void Zuyg(int x)
        {//13
            if (x % 2 == 0)
            {
                Console.WriteLine("zuyg");
            }
            else
            {
                Console.WriteLine("kent");
            }
        }
        public static void Stugel(int x)
        {//14
            if (x > 0)
            {
                Console.WriteLine("drakan");
            }
            else if (x < 0)
            {
                Console.WriteLine("bacasakan");
            }
            else if (x == 0)
            {
                Console.WriteLine("Zero");
            }
        }
        public static void Visakosni(int x)
        {//15
            if (x % 4 == 0)
            {
                Console.WriteLine("visakosni");
            }
            else
            {
                Console.WriteLine("sovorakan");
            }
        }
        public static void Aravelaguyn(int x, int y, int c)
        {//16
            int u = Math.Max(x, y);
            int f = Math.Max(u, c);
            Console.WriteLine(f);
        }
        public static void Gnahatakan2(int x)
        {
            if (x >= 1 && x <= 20)
            {
                Console.WriteLine('f');
            }
            else if (x >= 21 && x <= 40)
            {
                Console.WriteLine('d');
            }
            else if (x >= 41 && x <= 60)
            {
                Console.WriteLine("c");
            }
            else if (x >= 61 && x <= 80)
            {
                Console.WriteLine('b');
            }
            else if (x >= 81 && x <= 100)
            {
                Console.WriteLine('a');
            }
            else { Console.WriteLine("sxal"); }
        }
    }
}
