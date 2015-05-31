namespace spiral
{
    public class SafeGrid<T>
    {
        public int Width { get; private set; }
        
        public int Height { get; private set; }

        private readonly T[,] _cells;

        public T this[int row, int col]
        {
            get
            {
                if (IsIndexOutOfBounds(row, col))
                {
                    return default(T);
                }
                return _cells[row, col];
            }
            set
            {
                if (IsIndexOutOfBounds(row, col))
                {
                    return;
                }
                _cells[row, col] = value;
            }
        }

        private bool IsIndexOutOfBounds(int row, int col)
        {
            return row >= Height || row < 0 || col >= Width || col < 0;
        }

        public SafeGrid(int height, int width)
        {
            Width = width;
            Height = height;
            _cells = new T[height, width];
        }
    }
}