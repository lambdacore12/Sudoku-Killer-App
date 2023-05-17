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
        //public int NumberOne { get; set; }
        //public int NumberTwo { get; set; }
        //public int NumberThree { get; set; }

        public static List<string> MakeReadable(List<Combination> rawList)
        {
            List<string> list = new List<string>();
            foreach (Combination combination in rawList)
            {
                string firstNumber = combination.NumberOne.ToString();
                string secondNumber = combination.NumberTwo.ToString();
                if (combination.NumberThree == 0)
                {
                    list.Add($" {firstNumber} + {secondNumber} ");
                }
                else
                {
                    string thirdNumber = combination.NumberThree.ToString();
                    list.Add($" {firstNumber} + {secondNumber} + {thirdNumber}");
                }
                
            }
            return list;
        }
    }
}
