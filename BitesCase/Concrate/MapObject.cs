using BitesCase.Abstract;
using System;

namespace BitesCase.Concrate
{
    public class MapObject : MapInterface
    {
        public int[,] map;
        public void ClearBorder(int x, int y)
        {
            map[x, y] = 0;
        }

        public void GetSize(out int width, out int height)
        {
            width = map.GetUpperBound(0)+1;
            height = map.GetUpperBound(1)+1;
        }

        public bool IsBorder(int x, int y)
        {
            if (x > map.GetUpperBound(0) || y > map.GetUpperBound(1))
            {
                return false;
            }
            return Convert.ToBoolean(map[x, y]);
        }

        public void SetBorder(int x, int y)
        {
            map[x, y] = 1;
        }

        public void SetSize(in int width, in int height)
        {
            map = new int[width, height];
        }

        public void Show()
        {

            GetSize(out var width, out var height);
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    Console.Write(Convert.ToBoolean(map[x, y])  ? " x " : " - ");
                }
                Console.WriteLine();
            }
        }
    }
}
