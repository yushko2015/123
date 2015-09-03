using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            B obj = new B(k);


            foreach (int index in obj.mas)
                Console.WriteLine(index);
            Console.ReadKey();

        }
    }

    class B
    {
        int a, b, d;
        public int[] mas;

        public B()
        {
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = ");
            d = Convert.ToInt32(Console.ReadLine());
            mas = new int[a];
        }

        public B(decimal k)
            : this()
        {
            mas = new int[a];

            for (int index = 0; index < a; index++)
                mas[index] = c2 * index;

        }


        public int c2
        {
            get
            {
                while (d <= 10) d += a + b;

                return d;

            }
            set
            {
                d = value;

            }
        }
    }
}