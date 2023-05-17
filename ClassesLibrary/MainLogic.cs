using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassesLibrary
{
    public class MainLogic
    {        
        public int Cells { get; set; }
        public static int TotalCombinations { get; set; }

        public static List<Combination> CalculateTwo(int targetNumber)
        {
            List<Combination> Combinations = new List<Combination>();
            int totalCombinations = 0;
            //targetNumber = TargetNumber;
            
            for (int i = 1; i <= 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if (i + j == targetNumber)
                    {
                        Combination combination = new Combination();
                        combination.NumberOne = i;
                        combination.NumberTwo = j;
                        Combinations.Add(combination);

                        totalCombinations++;
                    }
                }
            }

            TotalCombinations = totalCombinations;
            return Combinations;
        }

        public static List<Combination> CalculateThree(int targetNumber)
        {
            List<Combination> Combinations = new List<Combination>();
            int totalCombinations = 0;
            //targetNumber = TargetNumber;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    for (int k = j + 1; k <= 9; k++)
                    {
                        if (i + j + k == targetNumber)
                        {
                            Combination combination = new Combination();
                            combination.NumberOne = i;
                            combination.NumberTwo = j;
                            combination.NumberThree = k;
                            Combinations.Add(combination);

                            totalCombinations++;
                        }
                    }
                }
            }

            TotalCombinations = totalCombinations;
            return Combinations;
        }
    }
}
