using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV2
{
    class PhoneticConverter
    {
        private static readonly char[] vowels = { 'а', 'о', 'у', 'ы', 'э', 'я', 'е', 'ё', 'ю', 'и' };
        private static readonly char[] consonants = {'б', 'в', 'г', 'д', 'й', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'};

        public string inputedWord { get; set; }
        public int indexOfShockConst { get; set; }
        public PhoneticConverter(string inputedWord)
        {
            if (inputedWord.Length < 1)
            {
                this.inputedWord = string.Empty;
                Console.WriteLine("Incorrect input");
            }
            else
            {
                this.inputedWord = inputedWord;
            }
        }

        public int ShockVowelSearcher(string inputedWord)
        {
            int indexOfPlus = inputedWord.IndexOf('+');
            indexOfShockConst = indexOfPlus - 1;
            return indexOfShockConst;
        }

        public void PhonemsConverter(string inputWord, int indexOfShockConst)
        {
            
            StringBuilder word = new StringBuilder(inputWord);
            char letterA = 'а';
            for (int i = 0; i < word.Length; i++)
            {
                if (i != indexOfShockConst && word[i] == 'о')
                {
                    word[i] = letterA;
                }
            }           
            inputWord = word.ToString().Replace("+", "");            
            Console.WriteLine("replaced word: " + inputWord);
            Console.ReadLine();
        }

        /// <summary>
        /// This method displays subseqences. 
        /// </summary>
        public void DisplayPhonems(HashSet<string> phonems)
        {
            foreach (string s in phonems)
            {
                Console.WriteLine(s);
            }
        }
    }
}
