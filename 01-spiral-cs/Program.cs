using System;

namespace spiral

{
    class Program
    {
        static void Main(string[] args)
        {
            var size = new Tuple<int, int>(30, 20);

            var spiral = MakeSpiral(size.Item1, size.Item2);

            Print(spiral);
        }

        private static void Print(SafeGrid<string> spiral)
        {
            
        }

        private static SafeGrid<string> MakeSpiral(int rows, int cols)
        {
            throw new NotImplementedException();
        }

        private static void SafeWrite(int x, int y)
        {
            
        }
    }
}
