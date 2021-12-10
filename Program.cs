using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructUrline
{
    class Program
    {
        static void Main(string[] args)
        {
            Urline ur = new Urline();
            ur.Root();
            Console.ReadKey();
        }

    }
    struct Urline
    {
        public double k;
        public double b;
        public double x;



        public void Root()

        {
            Console.WriteLine("Введите значение K");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение В");
            b = Convert.ToDouble(Console.ReadLine());
            if (k != 0) Console.WriteLine("x равен {0:f2}", x = -b / k);
            if (k == 0 && b != 0) Console.WriteLine("Уравнение решение не имеет!");
            if (k == 0 && b == 0) Console.WriteLine("x равен любому числу");

        }


    }
   
}
