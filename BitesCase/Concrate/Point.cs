namespace BitesCase.Concrate
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            IsVisited = false;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsVisited { get; set; }
    }
}
