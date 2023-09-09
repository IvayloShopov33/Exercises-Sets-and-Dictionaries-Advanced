namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalElements = new SortedSet<string>();
            int inputLinesCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputLinesCount; i++)
            {
                string[] inputElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in inputElements)
                {
                    //add the element to the sorted set if it is not present in it
                    chemicalElements.Add(element);
                }
            }

            //print the chemical elements, separated by " "
            Console.WriteLine(string.Join(' ', chemicalElements));
        }
    }
}