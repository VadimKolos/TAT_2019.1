using System;

namespace task_DEV2
{
    /// <summary>
    /// This program takes a sequence of Russian characters and converts them 
    /// into a phonetic representation.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            try
            {
                PhoneticConverter phoneticConverter = new PhoneticConverter(args[0]);
                int indexOfShockVowel = phoneticConverter.ShockVowelSearch(args[0]);
                string OAconvertedWord = phoneticConverter.OAReplace(args[0], indexOfShockVowel);
                string softConsonantWord = phoneticConverter.SoftConsonantsReplace(OAconvertedWord);
                string doubleVoicedVowelWord = phoneticConverter.DoubleSoundVowelsReplace(softConsonantWord);
                string voicedSoundWord = phoneticConverter.VoicedToDeafConsonantsReplace(doubleVoicedVowelWord);
                string deafSoundWord = phoneticConverter.DeafToVoicedConsonantsReplace(voicedSoundWord);
                phoneticConverter.DisplayPhonems(deafSoundWord);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}