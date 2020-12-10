using BitesCase.Abstract;
using BitesCase.Concrate;
using System.Collections.Generic;
using System.Linq;

namespace BitesCase.dogancan_aslan
{
    public class MapBuilder : ZoneCounterInterface
    {
        private MapInterface _map;
        private MapInterface _tempMap;
        private readonly Stack<Point> st = new Stack<Point>();
        public void Init(MapInterface map)
        {
            _map = new MapObject();
            map.GetSize(out var width, out var height);
            _map.SetSize(width, height);
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    if (map.IsBorder(x, y))
                    {
                        _map.SetBorder(x, y);
                    }
                }
            }
        }

        public int Solve()
        {
            if (_map == null)
            {
                return 0;
            }
            _map.GetSize(out var width, out var height);
            if (width <= 0 || height <= 0)
            {
                return 0;
            }
            int count = 0;
            _tempMap = new MapObject();
            _tempMap.SetSize(width, height);
            findPointForStack();
            while (st.Any())
            {
                FindArea();
                findPointForStack();
                count++;
            }
            return count;
        }
        private void findPointForStack()
        {
            _map.GetSize(out var width, out var height);
            bool broke = false;
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    if (!_map.IsBorder(x, y) && !_tempMap.IsBorder(x,y))
                    {
                        st.Push(new Point(x, y));
                        broke = true;
                        break;
                    }
                }
                if (broke)
                {
                    break;
                }
            }
        }
        private void FindArea()
        {
            _map.GetSize(out var width, out var height);
            while (st.Any())
            {
                var point = st.Pop();
                _tempMap.SetBorder(point.X, point.Y);
                if (point.X + 1 < width && !_map.IsBorder(point.X + 1, point.Y) && !_tempMap.IsBorder(point.X + 1, point.Y))
                {
                    st.Push(new Point(point.X + 1, point.Y));
                }
                if (point.X - 1 >= 0 && !_map.IsBorder(point.X - 1, point.Y) && !_tempMap.IsBorder(point.X - 1, point.Y))
                {
                    st.Push(new Point(point.X - 1, point.Y));
                }
                if (point.Y + 1 < height && !_map.IsBorder(point.X, point.Y + 1) && !_tempMap.IsBorder(point.X, point.Y + 1))
                {
                    st.Push(new Point(point.X, point.Y + 1));
                }
                if (point.Y - 1 >= 0 && !_map.IsBorder(point.X, point.Y - 1) && !_tempMap.IsBorder(point.X, point.Y - 1))
                {
                    st.Push(new Point(point.X, point.Y - 1));
                }
            }
        }

    }
}
