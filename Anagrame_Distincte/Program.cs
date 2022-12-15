using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrame_Distincte
{
    class Program
    {
        static List<string> list = new List<string>();
        static List<string> list2 = new List<string>();
        static int nr = 0;
        static string str = "EXCELLENT";
        
        
        static ulong fact2 (ulong n)
        {
            if (n <= 1) return 1;
            else return n * fact2(n - 1);
        }
        static ulong fact ( ulong n)
        {
            ulong p = 1;
            for (ulong i = 1; i <= n; i++)
            
                p *= i;

            return p;
        }
        static void BK(int k, int n, int []s, bool []b)
        //k - nivel curent 
        //n - nivelul maxim
        // s - vectorul unde salvezi indicii 
        // b - vector boolean ca sa optin unicitatea permutarilor
        {
            if ( k >= n)
            {
                /*for (int i = 0; i < n; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine(); inlocuim asta cu*/
                /*Console.WriteLine(Anagr(s));il inlocuim cu lista*/
                list.Add(Anagr(s));
                nr++;

            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    { b[i] = true;
                        s[k] = i;
                        BK(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
            
        }
        static string Anagr(int []s)
        {
            string tor = "";
            for (int i = 0; i < s.Length; i++)
           
                tor += str[s[i]];
                return tor; 
        }
        static void Main(string[] args)
        {
            int n = str.Length;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BK(0, n, s, b);
            
            list.Sort(delegate (string a, string c) { return a.CompareTo(c); });
            foreach (string s1 in list)
                Console.WriteLine(s1);
            list2.Add(list[0]);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != list2[list2.Count - 1])
                    list2.Add(list[i]);
            }
            foreach (string s1 in list2)
                Console.WriteLine(s1);
            Console.WriteLine(nr);
            Console.WriteLine(list2.Count);
            Console.WriteLine(fact((ulong)n));
            Console.WriteLine(fact2((ulong)n));
            Console.Write(fact((ulong)n) / (fact2(2) * fact(3)));

            int[] Vn = new int[255];
            for (int i = 0; i < str.Length; i++)
            {
                Vn[(int)str[i]]++;
            }
            for (int i = 0; i < 255; i++)
            {
                Console.Write(Vn[i]);
            }
            ulong Lv = 1;
            for (int i = 0; i < 255; i++)
            {
                if (Vn[i] > 1)
                    Lv *= fact((ulong)Vn[i]);
            }
            Console.WriteLine();
            Console.WriteLine(fact((ulong)str.Length) / Lv);
           
            Console.ReadKey();


            
        }
    }
}
