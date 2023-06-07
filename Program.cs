using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[20];
            Random rnd = new Random();
            array[0] = rnd.Next(1, 11);
            Console.Write(array[0] + "   ");
            array[1] = rnd.Next(1, 11);
            if (array[0] == array[1])
            {
                while (array[0] == array[1])
                {
                    array[1] = rnd.Next(1, 11);
                }
            }
            Console.Write(array[1] + "   ");
            for (int i = 2; i < 20; i++)
            {

                // array[i] = Convert.ToInt32(Console.ReadLine());
                array[i] = rnd.Next(1, 11);

                Console.Write(array[i] + "    ");
            }
            Console.WriteLine();
            bool flag = true;
            int k = 0;

            while (flag)
            {

                for (int i = 0; i < 20; i++)
                {

                    for (int j = i; j < 20; j++)
                    {
                        if (i != j && array[i] == array[j])
                        {

                            array[j] *= j;

                        }

                    }
                }
                for (int i = 0; i < 20; i++)
                {

                    for (int j = i; j < 20; j++)
                    {
                        if (i != j && array[i] == array[j])
                        {


                            k++;
                        }

                    }
                }


                if (k == 0)
                    flag = false;

                k = 0;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i] + "    ");
            }
            Console.WriteLine();
            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}



