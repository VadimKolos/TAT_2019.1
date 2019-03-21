using System;

namespace task_DEV2
{
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
                int indexOfShockVowel = phoneticConverter.ShockVowelSearcher(args[0]);
                string OAconvertedWord = phoneticConverter.OAConverter(args[0], indexOfShockVowel);
                string softConsonantWord = phoneticConverter.SoftConsonantsConverter(OAconvertedWord);
                string doubleVoicedVowelWord = phoneticConverter.DoubleSoundVowelsConverter(softConsonantWord);
                string voicedSoundWord = phoneticConverter.VoicedToDeafConsonantsConverter(doubleVoicedVowelWord);
                string deafSoundWord = phoneticConverter.DeafToVoicedConsonantsConverter(voicedSoundWord);
                phoneticConverter.DisplayPhonems(deafSoundWord);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}