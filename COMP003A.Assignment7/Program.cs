/*
 * Author: Joshua Isidro
 * Purpose: Code for assignment 7
 * Course: COMP003A
 */

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Character Counter");
            Console.WriteLine("Please enter a letter");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word");
            string word1 = Console.ReadLine();
            int count = CharacterCounter(letter, word1);
            Console.WriteLine($"There are {count} {letter} in the word {word1}");

            SectionSeparator("IsPalindrome");
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            string word = Console.ReadLine();
            bool isPalindrome=IsPalindrome(word);
            Console.WriteLine($"Is the word {word} palindrome: {isPalindrome}");

            SectionSeparator("Add");
            List<string> names = new List<string>();
            char userInput = default;
            do
            {
                Console.WriteLine("Please enter a name");
                string name = Console.ReadLine();
                names.Add(name);
                Console.WriteLine("Press any key to add more or (e) to exit");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInput != 'e');
            Console.WriteLine();

            SectionSeparator("Traversal");
            TraverseList(names);
            


            SectionSeparator("Reverse Traversal");
            TraverseListReverse(names);
        }

        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
        }


        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsPalindrome(string word)
        {
            string reversedWord = "";
            word = word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return word == reversedWord;
        }

        static void TraverseList(List<string> list)
        {
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
