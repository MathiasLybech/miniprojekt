using System;
using System.Collections.Generic;
using System.IO;

namespace superliga_miniproject
{
    class Program
    {
        static List<Results> listOfResults = new List<Results>();
        static List<String> allTeams = new List<string>();
        static void Main(string[] args)
        {
            readFromFile();
            createListOfAllTeams();

        }

        private static void createListOfAllTeams()
        {

            foreach (Results results in listOfResults)
            {
                if (!allTeams.Contains(results.homeTeam))
                {
                    allTeams.Add(results.homeTeam);
                }
            }
        }

        private static void readFromFile()
        {
            string[] temp;
            string[] lines = System.IO.File.ReadAllLines(@"results.txt"); /*Kopier jeres path ind her til results.txt */

            foreach (string line in lines)
            {
                temp = line.Split(new char[] { '-', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                listOfResults.Add(new Results(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5],
                                             Int32.Parse(temp[6]), Int32.Parse(temp[7]), Convert.ToInt32(double.Parse(temp[8]))));
            }
        }
    }
}
