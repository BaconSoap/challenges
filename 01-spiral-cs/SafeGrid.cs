namespace spiral
{
    public class SafeGrid<T>
    {
        private readonly int _width;
        private readonly int _height;
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
            return row >= _width || row < 0 || col >= _height || col < 0;
        }

        public SafeGrid(int height, int width)
        {
            _width = width;
            _height = height;
            _cells = new T[height, width];
        }
    }
}