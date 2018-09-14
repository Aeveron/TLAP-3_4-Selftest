

using System;
using System.Linq;

namespace TLAP_3_4_Selftest
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            var code = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";
            var ciphertext = "Hei";
            Encrypt(alphabet, code, ciphertext);
            Console.WriteLine(ciphertext);
            var x = "ye";
        }
      
        static void Encrypt(string alphabet, string code, string ciphertext)
        {
            var codeToArray = code.ToCharArray();
            var alphabetToArray = alphabet.ToCharArray();
            //var characters = ciphertext;
            var outputText = string.Empty;

            foreach (var i in ciphertext.ToUpper())
            {
                if (alphabetToArray.Contains(i))
                {
                    outputText += alphabetToArray[Array.IndexOf(codeToArray, i)];
                }
                else outputText += i;
                //Console.WriteLine(i);
            }

            Console.WriteLine(outputText);
        }
    }
}
