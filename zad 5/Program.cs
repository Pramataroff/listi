namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> even = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    even.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", even));
        }
    }
}