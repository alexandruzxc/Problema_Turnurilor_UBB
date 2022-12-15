using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Turnurilor_UBB
{
    class Program
    {

        static void T (int n)
        {
            if (n == 1)
                Console.Write(1);
            else
            {
                T(n - 1);
                Console.Write(n);
                T(n - 1);
            }
                
            
        }
        static void Main(string[] args)
        {
            T(5);
            Console.ReadKey();

        }
    }
}
