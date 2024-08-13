using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Desafios.Facil
{
    public class StringToInteger
    {
        public int Converter(string s)
        {
            int i = 0;
            int ix = 0;

            while (s[i] == 32) //blank
                i++;

            if (s[i] == 45) //negative          
                i++;

            while (i < s.Length)
            {
                if (char.IsAsciiDigit(s[i]))
                    i++;
                ix = i;
            }

            return int.Parse(s[0..ix]);
        }
    }
}