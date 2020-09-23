using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool one = true;
            byte bit1 = 10;
            sbyte bit2 = -10;
            short sh1 = -30000;
            ushort sh2 = 30000;
            int a = 1000000;
            uint b = 4000000000;
            long c1 = -9;
            ulong c2 = 9;
            float d = 3.1F;
            decimal d1 = 3.4M;
            double e = 3.1;
            char f = 'A';
            string str = "Hello";
            object obj = 3.13;
            long a1 = a;
            int e1 = (int)e;
            object e2 = e;
            int z = (char)f;
            object f1 = f;
            char f2 = (char)f1;
            var x = "CONST";
            Nullable<int> z2 = 5;


            Console.WriteLine($"Bool: {one}");
            Console.WriteLine($"Byte: {bit1}");
            Console.WriteLine($"sByte: {bit2}");
            Console.WriteLine($"Short: {sh1}");
            Console.WriteLine($"uShort: {sh2}");
            Console.WriteLine($"Int: {a}");
            Console.WriteLine($"Uint: {b}");
            Console.WriteLine($"Long: {c1}");
            Console.WriteLine($"uLong: {c2}");
            Console.WriteLine($"Float: {d}");
            Console.WriteLine($"Decimal: {d1}");
            Console.WriteLine($"Double: {e}");
            Console.WriteLine($"Char: {f}");
            Console.WriteLine($"String: {str}");
            Console.WriteLine($"Object: {obj}");
            Console.WriteLine($"Неявное преобразование: {a1}");
            Console.WriteLine($"Неявное преобразование: {e2}");
            Console.WriteLine($"Явное приведение: {e1}");
            Console.WriteLine($"Явное приведение: {z}");
            Console.WriteLine($"Боксинг: {f1}");
            Console.WriteLine($"Анбоксинг: {f2}");
            Console.WriteLine($"Неявно типизированная переменная: {x}");
            Console.WriteLine($"Nullable: {z2}");
            Console.WriteLine($"Строковые литералы");
            string first = "Как дела ";
            string second = "Что происходит ";
            string third = "Не работает ";
            Console.WriteLine(String.Concat(first, second));
            Console.WriteLine(String.Copy(second));
            Console.WriteLine(second.Substring(1, 3));
            foreach (var word in (first + second + third).Split(' '))
            {
                Console.Write("\t{0}", word);
            }
            Console.WriteLine("\n" + first.Insert(4, second));
            string remove = "remove";
            Console.WriteLine("\n" + remove.Remove(1, 3));

            string EMPTY = String.Empty;
            string NULL = null;
            Console.WriteLine("\n\t\t\tEmpty:\t\tNULL:", EMPTY, NULL);
            Console.WriteLine("\n\tLength:\t\t0\t\t-1", EMPTY?.Length ?? -1, NULL?.Length ?? -1);
            StringBuilder stringBuilder = new StringBuilder("??What I'm doing here?");
            Console.WriteLine($"\nStringBuilder: {stringBuilder}");
            Console.WriteLine($"Длина строки: {stringBuilder.Length}");
            Console.WriteLine($"Емкость строки: {stringBuilder.Capacity}");
            stringBuilder.Remove(0, 2);
            Console.WriteLine($"\nStringBuilder: {stringBuilder}");
            stringBuilder.Insert(0, "-");
            Console.WriteLine($"\nStringBuilder: {stringBuilder}");
            stringBuilder.Append("??");
            Console.WriteLine($"\nStringBuilder: {stringBuilder}\n\n\n");


            Random rand = new Random(System.DateTime.Now.Millisecond);
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-99, 99);
                    Console.Write("\t{0}", matrix[i, j].ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("\n\n\n");

            string[] Arr = { "World1", "World2", "World3", "World4", "World5" };
            Console.WriteLine("Размер массива: - {0}", Arr.Length);
            foreach (var STR in Arr)
            {
                Console.WriteLine("Кол-во символов: \t{1}\t{0} ", STR, STR.Length);
            }
            Console.Write("Введите позицию изменяемого слова и значение нового слова: ");
            var inputArgs = Console.ReadLine().Split(' ');
            Arr[Convert.ToInt32(inputArgs[0])] = inputArgs[1];
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("\t[{0}] {1}\t{2} Кол-во символов: ", i, Arr[i], Arr[i].Length);
            }
            float[][] fArr = { new float[2], new float[3], new float[4] };
            for (int i = 0; i < fArr.Length; i++)
            {
                Console.Write("Введите {0} значений через пробел: ", fArr[i].Length);
                inputArgs = Console.ReadLine().Split(' ');
                for (int j = 0; j < fArr[i].Length; j++)
                {
                    fArr[i][j] = (float)Convert.ToDouble(inputArgs[j]);
                }
            }
            foreach (var line in fArr)
            {
                foreach (var item in line)
                {
                    Console.Write("\t{0}", item.ToString());
                }
                Console.WriteLine();
            }


            var iArr = new int[] { 1, 2, 3 };
            var boolArr = new bool[] { true, false };
            var doubleArr = new double[] { 3.1, 2.4, 1.4, 1.9 };
            var charArr = new char[] { 'A', 'B', 'C' };
            Console.WriteLine("int: " + iArr.GetType());
            Console.WriteLine("bool: " + boolArr.GetType());
            Console.WriteLine("double: " + doubleArr.GetType());
            Console.WriteLine("char: " + charArr.GetType());


            (int, string, char, string, ulong) cort = (1, "HELLO", 'U', "WORLD!", 999999999);
            var cort1 = Tuple.Create<int, string, char, string, ulong>(1, "HELLO", 'U', "WORLD!", 124124144);
            Console.Write($"\n\n{cort.Item1}");
            Console.Write($"\t{cort.Item2}");
            Console.Write($"\t{cort.Item3}");
            Console.Write($"\t{cort.Item4}");
            Console.Write($"\t{cort.Item5}");
            Console.Write($"\n\n{cort}");

            int contp = (int)cort.Item1;
            var cortp = cort.Item4;
            Console.Write($"\n\n{contp}");
            Console.Write($"\n\n{cortp}");

            Console.WriteLine($"\n\nСравнение двух кортежей: {(cort.ToTuple() == cort1 ? bool.TrueString : bool.FalseString)}\n\n");



            var intArr = new int[] { 1, 2, 3 };
            string STRR = "HELLO";

            Console.WriteLine($"Вводим: {intArr[0]}, {intArr[1]}, {intArr[2]}, {STRR}");
            var funn = new Program().fun(intArr, STRR);
            Console.WriteLine($"Вывод: {funn}");
        }

        public (int max, int min, long sum, char fl) fun (int[] intArr, string STRR)
        {
            return (intArr.Max(), intArr.Min(), intArr.Sum(), STRR[0]);
        }
    }
}
