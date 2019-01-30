﻿using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    public class CustomComparator
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x%2!=0).ThenBy(x=>x).ToList().ForEach(x=>Console.Write(x+" "));

        }
    }
}
