using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellogit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GIT");
            Console.ReadLine(); //Borkborkbork

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\\ O.o /");
            }

            Hello();
            
            Console.ReadKey();
        }

        static void Hello()
        {
            Console.WriteLine("Yolo!");
        }
    }
}
