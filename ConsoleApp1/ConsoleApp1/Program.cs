using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
//Clinton Carter
{
    class Program
    {
        static void Main(string[] args)
        /*Create a class variable, of type string, that will hold the value:
 "Programming today is a race between software engineers striving to build bigger and better 
 idiot-proof programs, and the universe trying to build bigger and better idiots. So far, 
 the universe is winning."
 Start your application off by showing the user the above sentence.  Then ask the user 
 for input on what word they want to look for in the above sentence, and what word they 
 want to change it to (easier if this is two separate inputs). 
 If the word they want to look for is not present in the sentence, output 
 "Sorry, I could not find your word {INSERT THEIR WORD HERE}." and then output their
 word they wanted you to look for in reverse order (e.g. if their word was puppy,
 you would output yppup).  If the word does exist in the sentence, replace all occurrences of 
 it with the word they wanted to replace it with and output the new sentence with the words
 replaced.
     */
        {

            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot - proof programs, and the universe trying to build bigger and better idiots.So far,the universe is winning.";
            Console.WriteLine(sentence);
            Console.WriteLine("What word do you want to look for in the sentence? >>");
            string word = Console.ReadLine().ToLower();
            // making a true false value to see if the word is in the sentence
            bool success = sentence.Contains(word);

            if (success == false)
            {
                Console.Write("Sorry that word is not in the sentence!");
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    Console.Write(word[i] + " ");
                }
            }

            else
            {
                Console.WriteLine("What do you want to change this word to? >>");
                string change = Console.ReadLine().ToLower();
                change = sentence.Replace(word, change);
                //output
                Console.WriteLine(change);
            }

                Console.ReadKey();




            
        }
    }
}
