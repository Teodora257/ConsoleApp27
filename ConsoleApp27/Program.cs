namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числа, разделени с интервали:");
            string input = Console.ReadLine();

            string[] inputStrings = input.Split(' ');
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (string num in inputStrings)
            {
                uniqueNumbers.Add(int.Parse(num));
            }

            List<int> sortedUniqueNumbers = new List<int>(uniqueNumbers);
            sortedUniqueNumbers.Sort();

            Console.WriteLine("Уникалните числа са:");
            Console.WriteLine(string.Join(" ", sortedUniqueNumbers));
        }
    }
}
