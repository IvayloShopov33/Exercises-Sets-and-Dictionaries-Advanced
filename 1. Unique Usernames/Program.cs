namespace _1._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int inputLinesCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputLinesCount; i++)
            {
                string username = Console.ReadLine();
                //add the username to the hashset if it is not present in it
                usernames.Add(username);
            }

            //print the unique usernames, each one on a new line
            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}