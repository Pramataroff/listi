namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < list.Count; i++)
            {
                string[] parts = list[i].Split();
                Console.WriteLine($"{parts[1]} {parts[0]}");
            }
        }
    }
}