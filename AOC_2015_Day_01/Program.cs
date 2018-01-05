using System;

namespace AOC_2015_Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1 result : " + Part_1(Properties.Resources.Puzzle_Input_Part_1.ToString()));
            Console.WriteLine("Part 2 result : " + Part_2(Properties.Resources.Puzzle_Input_Part_2.ToString()));
            Console.ReadKey();
        }

        static int Part_1(String input)
        {
            int currentFloor = 0;
            foreach(char c in input)
            {
                if (c == '(') currentFloor++;
                else currentFloor--;
            }
            return currentFloor;
        }

        static int Part_2(String input)
        {
            int currentFloor = 0;
            int basementCharPosition = 0;
            foreach (char c in input)
            {
                if (c == '(') currentFloor++;
                else currentFloor--;
                basementCharPosition++;
                if (currentFloor == -1)
                    break;
            }
            return basementCharPosition;
        }
    }
}
