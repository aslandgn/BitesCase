using BitesCase.Abstract;
using BitesCase.Concrate;
using BitesCase.dogancan_aslan;

namespace BitesCase
{
    class Program
    {
        static void Main(string[] args)
        {
            ZoneCounterInterface mapBuilder = new MapBuilder();
            MapInterface map = new MapObject();

            map.SetSize(10, 10);

            map.SetBorder(0, 3);
            map.SetBorder(1, 2);
            map.SetBorder(2, 1);
            map.SetBorder(3, 0);

            map.SetBorder(2, 3);
            map.SetBorder(3, 4);
            map.SetBorder(3, 5);
            map.SetBorder(3, 6);
            map.SetBorder(3, 7);
            map.SetBorder(3, 8);
            map.SetBorder(2, 9);


            map.SetBorder(5, 0);
            map.SetBorder(5, 1);
            map.SetBorder(5, 2);
            map.SetBorder(6, 3);
            map.SetBorder(6, 4);
            map.SetBorder(6, 5);
            map.SetBorder(7, 6);
            map.SetBorder(7, 7);
            map.SetBorder(8, 8);
            map.SetBorder(8, 9);
            
            
            map.SetBorder(5, 2);
            map.SetBorder(6, 2);
            map.SetBorder(7, 2);
            map.SetBorder(8, 2);
            map.SetBorder(9, 1);
            
            
            map.SetBorder(4, 7);
            map.SetBorder(5, 7);
            map.SetBorder(6, 6);



            mapBuilder.Init(map);
            map.Show();
            System.Console.WriteLine(mapBuilder.Solve());
        }
    }
}
