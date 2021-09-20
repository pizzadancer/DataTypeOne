using System;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice;
            string input;
            int searchLocation;
            bool isSearchTermPresent;
            string firstPart = "";
            string lastPart = "";
            string newAlice = "";
            alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            
           
            Console.WriteLine("Alice Search!");
            Console.WriteLine(alice);
            alice = alice.ToLower();
            // Prompt user for term to search
            Console.WriteLine("\nPlease enter a term to search the alice quote. ");
            input = Console.ReadLine();


            newAlice = alice;
            isSearchTermPresent = true;
            while (isSearchTermPresent)
            {
                // Search for searchTerm
                searchLocation = newAlice.IndexOf(input);
                Console.WriteLine(searchLocation);

                if (searchLocation != -1) 
                {
                    // Beginning part of the slice
                    firstPart = newAlice.Substring(0, searchLocation);

                    // Ending part of the slice
                    lastPart = newAlice.Substring(searchLocation + input.Length + 1);

                    // Combine into new string with one of the searchTerm removed
                    newAlice = firstPart + lastPart;
                }
                else
                {
                    isSearchTermPresent = false;
                }
            }
            Console.WriteLine("The New Alice");
            Console.WriteLine(newAlice);

        }
    }
}