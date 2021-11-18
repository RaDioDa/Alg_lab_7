using System;

namespace Alg_lab_7
{
    internal class Program
    {
        private static int size = 25;
        private static string[] surname = new string[size];
        private static string[] name = new string[size];
        private static DateTime[] date = new DateTime[size];
        private static int[] eng = new int[size];
        private static int[] fiz = new int[size];
        private static int[] math = new int[size]; 
        private static int[] prog = new int[size];

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                for (int i = 0; i < size; i++)
                {
                    surname[i] = Generator.SurnameGenerator();
                    name[i] = Generator.NameGenerator();
                    date[i] = Generator.DateGenerator();
                    eng[i] = Generator.MarkGenerator();
                    fiz[i] = Generator.MarkGenerator();
                    math[i] = Generator.MarkGenerator();
                    prog[i] = Generator.MarkGenerator();
                }

                for (int i = 0; i < size; i++)
                    Console.WriteLine(surname[i] + "||" + name[i] + "||" + date[i] + "||" + eng[i] + "||" + math[i] + "||" + fiz[i] + "||" + prog[i]);
                Console.WriteLine("\nActions:");
                Console.Write("\n");
                Console.WriteLine("1. Sort\n");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        {
                            sort();
                            for (int i = 0; i < size; i++)
                            {
                                Console.WriteLine(surname[i] + "||" + name[i] + "||" + date[i] + "||" + eng[i] + "||" + math[i] + "||" + fiz[i] + "||" + prog[i]);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }
        }

        static void sort()
        {
            int n = math.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the maximum element in unsorted array
                int max_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (math[j] > math[max_idx])
                        max_idx = j;

                // Swap the found maximum element with the first
                // element
                int temp = math[max_idx];
                math[max_idx] = math[i];
                math[i] = temp;

                temp = eng[max_idx];
                eng[max_idx] = eng[i];
                eng[i] = temp;

                temp = fiz[max_idx];
                fiz[max_idx] = fiz[i];
                fiz[i] = temp;

                temp = prog[max_idx];
                prog[max_idx] = prog[i];
                prog[i] = temp;

                string tmp = surname[max_idx];
                surname[max_idx] = surname[i];
                surname[i] = tmp;

                tmp = name[max_idx];
                name[max_idx] = name[i];
                name[i] = tmp;

                DateTime dateTemp = date[max_idx];
                date[max_idx] = date[i];
                date[i] = dateTemp;
            }
        }
    }
}
