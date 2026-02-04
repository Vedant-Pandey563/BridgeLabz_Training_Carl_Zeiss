namespace HashMap
{
    
    internal class Program
    {
        static void PrintMap(Dictionary<int,string> map)
        {
            Console.WriteLine("Printing map Elements");
            foreach (var x in map)
            {
                Console.WriteLine(x);
            }
        }
        static bool CheckMapValue(string s,Dictionary<int,string>map)
        {
            if(map.ContainsValue(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckMapKey(int i,Dictionary<int,string>map)
        {
            if(map.ContainsKey(i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int MapSize(Dictionary<int,string> map)
        {
            int s = map.Count();
            return s;
        }
        static void MapRemove(int i,Dictionary<int,string>map)
        {
            map.Remove(i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Map");

            Dictionary<int, string> map = new Dictionary<int, string>();

            Console.WriteLine(MapSize(map));

            map[1] = "a";
            map[2] = "b";
            map[3] = "c";

            Console.WriteLine(MapSize(map));

            Console.WriteLine(map[1]);
            
            PrintMap(map);

            Console.WriteLine("a".GetHashCode());
            Console.WriteLine("b".GetHashCode());
            Console.WriteLine("c".GetHashCode());
            Console.WriteLine("a".GetHashCode());

            map.Add(6, "f");

            PrintMap(map);
            Console.WriteLine( CheckMapValue("b",map));
            Console.WriteLine( CheckMapKey(4, map));
            Console.WriteLine(CheckMapKey(2, map));
            Console.WriteLine(CheckMapValue("x", map));

            Console.WriteLine(MapSize(map));

            MapRemove(2,map);

            PrintMap(map);

            Console.WriteLine(MapSize(map));

        }
    }
}
