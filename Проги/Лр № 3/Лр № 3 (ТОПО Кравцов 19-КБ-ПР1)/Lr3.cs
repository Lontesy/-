using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Лр___3__ТОПО_Кравцов_19_КБ_ПР1_
{
    public static class Lr_3
    {
        public static void Main(string[]args)
        {

        }
        public static string Sep(string word, string letter, string replace)
        {
            if (word == "")//1
                return "";//2
            char[] wordarr = word.ToArray();//3
            for (int i = 0;//4
                i < word.Length;//5
                i++)//6
            {
                if (wordarr[i] == Convert.ToChar(letter))//7
                {
                    wordarr[i] = Convert.ToChar(replace);//8
                }
            }
            return new string(wordarr);//9
        }
    }
}
