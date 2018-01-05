using System;

namespace AOC_2015_Day_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1 result : " + Part_1(Properties.Resources.Puzzle_Input_Part_1.ToString()));
            Console.WriteLine("Part 2 result : " + Part_2(Properties.Resources.Puzzle_Input_Part_2.ToString()));
            Console.ReadKey();
        }

        static int Part_1(String input) // 1588178
        {
            String[] rows = input.Split('\n');
            int surface = 0;
            foreach (var row in rows)
            {
                String[] dimensions = row.Split('x');
                int l, w, h;
                l = Convert.ToInt32(dimensions[0]);
                w = Convert.ToInt32(dimensions[1]);
                h = Convert.ToInt32(dimensions[2]);

                surface += 2*l*w + 2*w*h + 2*h*l;
                surface += Math.Min(l*w, Math.Min(w*h,h*l));
            }
            return surface;
        }

        static int Part_2(String input)
        {
            String[] rows = input.Split('\n');
            int ribbon = 0;
            foreach (var row in rows)
            {
                String[] dimensions = row.Split('x');
                int l, w, h;
                l = Convert.ToInt32(dimensions[0]);
                w = Convert.ToInt32(dimensions[1]);
                h = Convert.ToInt32(dimensions[2]);
                
                int smallest = Math.Min(l, Math.Min(w, h));
                int median = Math.Max(Math.Min(l, w), Math.Min(Math.Max(l, w), h));
                
                ribbon += smallest * 2 + median * 2;
                ribbon += l * w * h;
            }
            return ribbon;
        }
    }
}
