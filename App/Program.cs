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

            // A "While" loop runs through the entirety of the entered string and collects info.
            while (i < j)
            {
                // Variable that is used to divide out the whites spaces of the entered string so they are not counted among the special characters.
                var l = inp[i];

                // An "If-Else-If" statement that counts how many characters, numbers, and special characters are in the entered string.
                if ((inp[i] >= 'a' && inp[i] <= 'z') || (inp[i] >= 'A' && inp[i] <= 'Z'))
                {
                    CharCnt++;
                }
                else if (inp[i] >= '0' && inp[i] <= '9')
                {
                    NumCnt++;
                }
                else if (l != ' ')
                {
                    SpecCnt++;
                }

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

            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
