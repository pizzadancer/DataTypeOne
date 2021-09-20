using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice;
            string input;
            int searchLocation;

            alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
       
            // Prompt user for term to search
            Console.WriteLine("Alice Search!");
            Console.WriteLine(alice);
            Console.WriteLine("\nPlease enter a term to search the alice quote. ");
            input = Console.ReadLine();

            // Search for the term
            searchLocation = alice.IndexOf(input);

            // New Looping Replace
            string[] splitAlice = alice.Split(" ");
            foreach(string item in splitAlice)
            {
                Console.WriteLine(item.ToString());
            }
           /* searchLocation = Array.IndexOf(splitAlice, input);
            Console.WriteLine(searchLocation);*/
            // If Search was successful, return true | if not, return false
            /*if (searchLocation != 0)
            {
                Console.WriteLine("true");
                Console.WriteLine("The location of the search term is at index (" + searchLocation + ") and it's length is " + input.Length + ". ");
                // array before location
                string firstPart[] = splitAlice[0..searchLocation];
                // array after

                // join parts into new array

                // loop three steps above


                for (int i = 0; i < splitAlice.Length; i++)
                {
                    Console.WriteLine(splitAlice[i]); 
                }
                
            }
            else
            {
                Console.WriteLine("false");
            }*/
        }
    }
}


// OLD BELOW
// string after
// string before location
/*string firstPart = alice.Substring(0, searchLocation);*/
/*string lastPart = alice.Substring(searchLocation + input.Length+1);
string newAlice = firstPart + lastPart;
Console.WriteLine(newAlice);*/