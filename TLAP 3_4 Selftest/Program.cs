

using System;
using System.Linq;

namespace TLAP_3_4_Selftest
{

    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            var code = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";
            var ciphertext = "Hei på deg!";
            MainEncrypt(alphabet, code, ciphertext);
            BackToPlainText(alphabet, code, ciphertext);
            Console.WriteLine(ciphertext);

        }

        static void MainEncrypt(string alphabet, string code, string ciphertext)
        {
            var codeToArray = code.ToCharArray();
            var alphabetToArray = alphabet.ToCharArray();
            var outputText = string.Empty;

            foreach (var i in ciphertext.ToUpper())
            {
                if (alphabetToArray.Contains(i))
                {
                    outputText += alphabetToArray[Array.IndexOf(codeToArray, i)];
                }
                else outputText += i;
            }
            Console.WriteLine(outputText);
        }




        static void BackToPlainText(string alphabet, string code, string ciphertext)
        {
            var codeToArray = code.ToCharArray();
            var alphabetToArray = alphabet.ToCharArray();
            var characters = ciphertext;
            var outputText = string.Empty;

            foreach (var i in ciphertext.ToUpper())
            {
                if (alphabetToArray.Contains(i))
                {
                    outputText += alphabetToArray[Array.IndexOf(codeToArray, i)];
                }
                else outputText += i;
            }
            Console.WriteLine(characters);
            Console.WriteLine(outputText);

        }
    }
}
