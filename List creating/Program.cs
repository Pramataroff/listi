namespace List_creating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of colors: \n \"done\" for end");
            List<string> colorList = new List<string>();
            string input = Console.ReadLine();
            while (input != "done")
            {
                 input = Console.ReadLine();

                colorList.Add(input);
            }
            for (int i = 0; i < colorList.Count; i++)
            {
                Console.Write(colorList[i]);
            }
            foreach(string kvadratche in colorList)
            {
                Console.WriteLine(kvadratche);
            }
            Console.Write("Which element do you want to delete: " +
            (colorList.Count - 1) + "?");
            int index = int.Parse(Console.ReadLine());
            
            colorList.RemoveAt(index);
            colorList[0] = "rozovo";
        }
    }
}
