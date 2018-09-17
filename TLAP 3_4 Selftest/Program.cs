

using System;
using System.Linq;

namespace TLAP_3_4_Selftest
{

    class Program
    {
        static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            //string[] alphabetArr = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Æ", "Ø", "Å" };
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var code = "QWERTYUIOPLKJHGFDSAZXCVBNM";
            var ciphertext = "Hei på deg";
            MainEncrypt(alphabet, code, ciphertext);
            BackToPlainText(alphabet, code, ciphertext);
            Console.WriteLine(ciphertext);


        }

        static void MainEncrypt(string alphabet, string code, string ciphertext)
        {
            var codeToArray = code.ToCharArray();
            var alphabetToArray = alphabet.ToCharArray();
            var outputText = string.Empty;
            var characters = ciphertext;


            foreach (var i in ciphertext.ToUpper())
            {
                var randomAlpha = Random.Next(alphabetToArray.Length, i);
                if (alphabetToArray.Contains(i))
                {
                    outputText += alphabetToArray[Array.IndexOf(codeToArray, i)];
                }
                else outputText += RandomNess();
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
                var randomAlpha = Random.Next(alphabetToArray.Length, i);
                if (alphabetToArray.Contains(i))
                {
                    outputText += alphabetToArray[Array.IndexOf(codeToArray, i)];

                }
                else outputText += RandomNess();
            }
            Console.WriteLine(characters);
            Console.WriteLine(outputText);

        }

        private static char RandomNess()
        {
            return (char) Random.Next('A', 'Z');
        }
    }
}
