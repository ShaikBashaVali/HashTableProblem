namespace HashTablesProblems
{
    public class Program
    {

        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            Console.WriteLine("Welcome to the Hash Tables Problems");
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.WriteLine("Please choose any options");
                Console.WriteLine("1.Find Frequency Of words in a sentence \n" +
                    "2.Find Frequency Of words in a large paragraph and remove word from paragraph \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        string sentence = "To be or not to be";
                        CountNumbOfOccurence(sentence);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 2:
                        String paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        CountNumbOfOccurence(paragraph);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying after add operation\n---------------------------------");
            Console.WriteLine("Word      NumberOfFrequency");
            hashTabe.Display();
            string s = "avoidable";
            hashTabe.Remove(s);
            Console.WriteLine("\n----------------------------------", s);
            Console.WriteLine("After removed word:  {0}\n----------------------------------\n", s);
            hashTabe.Display();
        }
    }
}