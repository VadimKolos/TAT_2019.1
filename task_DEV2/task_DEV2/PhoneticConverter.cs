using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace task_DEV2
{
    /// <summary>
    /// This class make sound presentation from inputed string. 
    /// </summary>

    class PhoneticConverter
    {
        /// <summary>
        /// Сlassified russian letters.
        /// </summary>
        private static readonly char[] diacriticLetters = { 'ь', 'ъ' };
        private static readonly char[] doubleVoicedVowels = { 'я', 'е', 'ё', 'ю' };
        private static readonly char[] vowels = { 'а', 'о', 'у', 'ы', 'э', 'я', 'е', 'ё', 'ю', 'и' };
        private static readonly char[] consonants = { 'б', 'в', 'г', 'д', 'й', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
        private static readonly char[] voicedConsonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'л', 'м', 'н' };
        private static readonly char[] deafConsonants = { 'п', 'ф', 'к', 'т', 'с', 'ш', 'х', 'ц', 'ч', 'щ' };
        private static readonly char[] pairVoicedConsonants = { 'б', 'в', 'г', 'д', 'з', 'ж' };
        private static readonly char[] pairDeafConsonants = { 'п', 'ф', 'к', 'т', 'с', 'ш' };

        /// <summary>
        /// Dictionarys for translit to phonemes.
        /// </summary>
        Dictionary<char, string> letters = new Dictionary<char, string>(4);
        Dictionary<char, string> doubleSoundLetters = new Dictionary<char, string>(4);
        Dictionary<char, string> voicedToDeafLetters = new Dictionary<char, string>(6);
        Dictionary<char, string> deafToVoicedLetters = new Dictionary<char, string>(6);

        public string inputedWord { get; set; }
        public int indexOfShockVowel { get; set; }
        /// <summary>
        /// This constructor check input string.
        /// </summary>
        public PhoneticConverter(string inputedWord)
        {
            if (inputedWord.Length < 1)
            {
                this.inputedWord = string.Empty;
                Console.WriteLine("Incorrect input");
            }
            if (Regex.IsMatch(inputedWord, @"[А-ЯЁ]"))
            {
                this.inputedWord = string.Empty;
                Console.WriteLine("Incorreсt input: use only lowercase letters");
                Environment.Exit(1);
            }
            else
            {
                this.inputedWord = inputedWord;
            }
        }

        /// <summary>
        /// This method is looking for index of shock vowel.
        /// </summary>
        /// <param name="inputedWord">inputed string by user</param>
        /// <param name="indexOfShockConst">index of shock vowel</param>
        public int ShockVowelSearcher(string inputedWord)
        {
            int indexOfPlus = inputedWord.IndexOf('+');
            indexOfShockVowel = indexOfPlus - 1;
            return indexOfShockVowel;
        }

        /// <summary>
        /// This method is replaced unshockable russian letter 'o' on letter 'a'.
        /// </summary>
        /// <param name="inputedWord">inputed string by user</param>
        /// <param name="indexOfShockConst">index of shock vowel</param>
        /// /// <param name="inputedWord">returns converted word</param>
        public string OAConverter(string inputedWord, int indexOfShockConst)
        {

            StringBuilder word = new StringBuilder(inputedWord);
            char letterA = 'а';
            for (int i = 0; i < word.Length; i++)
            {
                if (i != indexOfShockConst && word[i] == 'о')
                {
                    word[i] = letterA;
                }
            }
            inputedWord = word.ToString().Replace("+", "");
            return inputedWord;
        }

        /// <summary>
        /// This method is softens consonants before russian letters 'е', 'ё', 'ю', 'я', and view sounds of them.
        /// </summary>
        /// <param name="inputedWord">inputed string from OAConverter method</param>        
        /// <param name="inputedWord">returns converted word</param>
        public string SoftConsonantsConverter(string inputedWord)
        {
            StringBuilder word = new StringBuilder(inputedWord);
            string replacedLetter;
            letters.Add('ю', "'у");
            letters.Add('я', "'а");
            letters.Add('ё', "'о");
            letters.Add('е', "'э");
            for (int i = 1; i < word.Length; i++)
            {
                if (doubleVoicedVowels.Contains(word[i]) && consonants.Contains(word[i - 1]))
                {
                    replacedLetter = letters[word[i]];
                    word = word.Remove(i, 1).Insert(i, replacedLetter);
                }
            }
            inputedWord = word.ToString();
            return inputedWord;
        }

        /// <summary>
        /// This method is view sound replace letters 'е', 'ё', 'ю', 'я' on phonems of this letters.
        /// </summary>
        /// <param name="inputedWord">inputed string from SoftConsonantsConverter method</param>        
        /// <param name="inputedWord">returns converted word</param>
        public string DoubleSoundVowelsConverter(string inputedWord)
        {
            StringBuilder word = new StringBuilder(inputedWord);
            string replacedLetter;
            doubleSoundLetters.Add('ю', "йу");
            doubleSoundLetters.Add('я', "йа");
            doubleSoundLetters.Add('ё', "йо");
            doubleSoundLetters.Add('е', "йэ");
            for (int i = 1; i < word.Length; i++)
            {
                if (doubleVoicedVowels.Contains(word[i]) && (vowels.Contains(word[i - 1]) || diacriticLetters.Contains(word[i - 1])))
                {
                    replacedLetter = doubleSoundLetters[word[i]];
                    word = word.Remove(i, 1).Insert(i, replacedLetter);
                }
            }
            if (doubleVoicedVowels.Contains(word[0]))
            {
                replacedLetter = doubleSoundLetters[word[0]];
                word = word.Remove(0, 1).Insert(0, replacedLetter);
            }

            inputedWord = word.ToString();
            return inputedWord;
        }

        /// <summary>
        /// This method is stuns voiced consonants.
        /// </summary>
        /// <param name="inputedWord">inputed string from DoubleSoundVowelsConverter method</param>        
        /// <param name="inputedWord">returns converted word</param>
        public string VoicedToDeafConsonantsConverter(string inputedWord)
        {
            StringBuilder word = new StringBuilder(inputedWord);
            string replacedLetter;
            voicedToDeafLetters.Add('б', "п");
            voicedToDeafLetters.Add('в', "ф");
            voicedToDeafLetters.Add('г', "к");
            voicedToDeafLetters.Add('д', "т");
            voicedToDeafLetters.Add('з', "с");
            voicedToDeafLetters.Add('ж', "ш");

            for (int i = 1; i < word.Length - 1; i++)
            {
                if (pairVoicedConsonants.Contains(word[i]) && deafConsonants.Contains(word[i + 1]))
                {
                    replacedLetter = voicedToDeafLetters[word[i]];
                    word = word.Remove(i, 1).Insert(i, replacedLetter);
                }
            }
            if (pairVoicedConsonants.Contains(word[word.Length - 1]))
            {
                replacedLetter = voicedToDeafLetters[word[word.Length - 1]];
                word = word.Remove(word.Length - 1, 1).Insert(word.Length, replacedLetter);
            }
            if (word[word.Length - 1] == 'ь' && pairVoicedConsonants.Contains(word[word.Length - 2]))
            {
                replacedLetter = voicedToDeafLetters[word[word.Length - 2]];
                word = word.Remove(word.Length - 2, 1).Insert(word.Length - 1, replacedLetter);
            }
            inputedWord = word.ToString();
            return inputedWord;
        }

        /// <summary>
        /// This method is voices deaf consonants.
        /// </summary>
        /// <param name="inputedWord">inputed string from DoubleSoundVowelsConverter method</param>        
        /// <param name="inputedWord">returns converted word</param>
        public string DeafToVoicedConsonantsConverter(string inputedWord)
        {
            StringBuilder word = new StringBuilder(inputedWord);
            string replacedLetter;
            deafToVoicedLetters.Add('п', "б");
            deafToVoicedLetters.Add('ф', "в");
            deafToVoicedLetters.Add('к', "г");
            deafToVoicedLetters.Add('т', "д");
            deafToVoicedLetters.Add('с', "з");
            deafToVoicedLetters.Add('ш', "ж");

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (deafConsonants.Contains(word[i]) && voicedConsonants.Contains(word[i + 1]))
                {
                    replacedLetter = deafToVoicedLetters[word[i]];
                    word = word.Remove(i, 1).Insert(i, replacedLetter);
                }
            }
            word = word.Replace('ь', '\'');
            inputedWord = word.ToString();
            return inputedWord;
        }
        /// <summary>
        /// This method displays subseqences. 
        /// </summary>
        public void DisplayPhonems(string inputedWord)
        {
            Console.WriteLine(inputedWord);
        }
    }
}