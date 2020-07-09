using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salkin_E
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = 0;
            while (s.Length > 0)
            {
                int nextSpace = s.IndexOf(' ');
                string word = s.Substring(0, nextSpace);
                if (word[0] == word[word.Length - 1])
                {
                    n++;
                }

                s = s.Remove(0, nextSpace + 1);
            }

            Console.WriteLine("Слов: {0}", n);

            Console.ReadKey();
        }
    }
}