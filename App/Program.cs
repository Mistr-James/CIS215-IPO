using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App {
    internal class Program {
        static void Main(string[] args) {
            Output.Line("Enter Input: ");
            var inp = Console.ReadLine();
			Console.SetIn ( new StreamReader ( Console.OpenStandardInput ( 2048 ) ) );
            int WordCnt, CharCnt, NumCnt, SpecCnt;
            /********************** DO NOT EDIT ABOVE THIS LINE **********************************/

	     // Addtional Integer Variables
             int SentCnt, i, j;
		
             // Sets the variables "CharCnt", "NumCnt", "SpecCnt", "i" to 0.
             CharCnt = NumCnt = SpecCnt = i = 0;
		
	     // Sets variable "j" as the length of the user entered string.
	     j = inp.Length;
		
	     // Calculates the average number of words in the string.
	     string[] wordNum = inp.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
	     WordCnt = wordNum.Length;
		
	     // Calculates the average number of numbers in the entered string.
	     string[] sentNum = inp.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
	     SentCnt = sentNum.Length;
		
	     // A "While" loop runs through each character of the string and collects info.
	     while (i < j)
     	     {
		
	        // An "If" statement that counts how many characters, numbers, and special characters are in the entered string (discounting spaces).
		if ((char.IsLetterOrDigit(inp[i]) == true) || (char.IsPunctuation(inp[i]) == true) || (char.IsSymbol(inp[i]) == true) && inp[i] != ' ')
		{
	            CharCnt++;
		}
		
		// An "If" statement that counts how many numbersare in the entered string (discounting spaces).
		if (char.IsDigit(inp[i]) == true && inp[i] != ' ')
		{
		    NumCnt++;
	        }
		
		// An "If" statement that counts how many special characters are in the entered string (discounting spaces).
		if (char.IsLetterOrDigit(inp[i]) == false && inp[i] != ' ')
		{
		    SpecCnt++;
	        }
		     
		// Advances the variable "i" to the next charaxter in the string.
		i++;
		
	      }
		
	      // Displays the information gathered into a list.
	      Output.Line("");
	      Output.Line("Number of Words: " + WordCnt);
	      Output.Line("Number of Sentences: " + SentCnt);
	      Output.Line("Average Number Words per Sentence: " + (float) WordCnt / SentCnt);
              Output.Line("Number of Characters: " + CharCnt);
	      Output.Line("Number of Special Characters: " + SpecCnt);
	      Output.Line("Average Number Characters per Sentence: " + (float) CharCnt / SentCnt);
	      Output.Line("Number of Numbers: " + NumCnt);
              Output.Line("\nThank you for using our program.\nGoodbye!");

            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
