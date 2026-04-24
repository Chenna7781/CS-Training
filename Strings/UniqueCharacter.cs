using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class UniqueCharacter
    {
        public static void Run(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                // d[ch] = d.ContainsKey(ch) ? d[ch] + 1 : 1;
                if (d.ContainsKey(ch))
               // d['a'] = 3;
                d[ch]++;

                else
                    d.Add(ch, 1);

            }

            foreach (var c in d)
            {
                if (c.Value == 1)
                    Console.WriteLine(c.Key);
                break;
            }
        }
    }
}
