namespace _026_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split(' ');

            // Sentence Array: [0] = "Hello", [1] = "World"
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                string word = sentenceArray[i];
                string newWord = "";

                // Word array: [0] = "H", [1] = "e", [2] = "l", [3] = "l", [4] = "o"
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] != 'a' && word[j] != 'e' && word[j] != 'i' && word[j] != 'o' && word[j] != 'u' &&
                       word[j] != 'A' && word[j] != 'E' && word[j] != 'I' && word[j] != 'O' && word[j] != 'U')
                    {
                        newWord += word[j];
                    }
   
                }
                sentenceArray[i] = newWord;
            }

            string newSentence = string.Join(" ", sentenceArray);

            Console.WriteLine("Your sentence without vowels: " + newSentence);


        }
    }
}
