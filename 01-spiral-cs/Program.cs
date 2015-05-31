using System;
using System.Text;

namespace spiral

{
    class Program
    {
        static void Main(string[] args)
        {
            var size = new Tuple<int, int>(70, 70);

            var spiral = MakeSpiral(size.Item1, size.Item2);

            Print(spiral);
            Console.ReadLine();
        }

        private static void Print(SafeGrid<string> spiral)
        {
            var sb = new StringBuilder();
            for (var row = 0; row < spiral.Height; row++)
            {
                for (var col = 0; col < spiral.Width; col++)
                {
                    var value = spiral[row, col];
                    sb.Append(string.IsNullOrEmpty(value)? " ": value);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        private static SafeGrid<string> MakeSpiral(int rows, int cols)
        {
            var step = (2*Math.PI)/100.0d;
            var rMax = 25*2*Math.PI;
            var halfX = cols/2;
            var halfY = rows/2;

            var grid = new SafeGrid<string>(rows, cols);

            for (var r = 0d; r < rMax; r += step)
            {
                var x = Math.Sin(r) * r;
                var y = Math.Cos(r) * r;
                var col = halfX + (int)Math.Round(x);
                var row = halfY + (int)Math.Round(y);
                grid[row, col] = ".";
            }

            return grid;
        }
    }
}
