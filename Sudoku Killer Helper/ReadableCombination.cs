using ClassesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Killer_Helper
{
    internal class ReadableCombination
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public static List<string> MakeReadable(List<Combination> rawList)
        {
            List<string> list = new List<string>();
            foreach (Combination comb in rawList)
            {
                string firstNumber = comb.NumberOne.ToString();
                string secondNumber = comb.NumberTwo.ToString();
                list.Add($" {firstNumber} + {secondNumber} ");
            }
            return list;
        }
    }
}
