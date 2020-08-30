using System;

namespace _4lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool otrz = false;
            int i, j, m;
            Console.WriteLine("Введите натуральное число");
            m = int.Parse(Console.ReadLine());
            for (i = 1; i < m; i++)
                for (j = i; j < m; j++)
                    if (i * i + j * j == m)
                    {

                        otrz = true;
                        Console.WriteLine(i.ToString()  + " * " + i.ToString() + " + " + j.ToString()  + " * " + j.ToString() + " = " + m.ToString());
                    }

            if (!otrz) Console.WriteLine("нет числа");
            Console.ReadKey();
            
        
        }
    }
}
