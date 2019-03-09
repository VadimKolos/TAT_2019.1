using System;
using System.Text;
using System.Collections.Generic;

namespace task_DEV1
{
    /// <summary>
    /// This class works with input sequence
    /// </summary>
    class UniqueSymbols
    {
        /// <summary>
        /// This method check input sequence and calculates unique subsequence from the input sequense and displays them
        /// </summary>
        /// <param name="inputedSequence">input string (sequnce)</param>
        /// <param name="sequences">unique subsequences from input sequence</param>
        public HashSet<string> SubsequenceFinder(string inputedSequence)
        {
            var subsequences = new HashSet<string>();
            if (inputedSequence.Length < 2)
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                for (int index = 0; index < inputedSequence.Length - 1; index++)
                {
                    StringBuilder subsequence = new StringBuilder();
                    subsequence.Append(inputedSequence[index]);
                    for (int nextIndex = index + 1; nextIndex < inputedSequence.Length; nextIndex++)
                    {
                        if (inputedSequence[nextIndex - 1] == inputedSequence[nextIndex])
                        {
                            break;
                        }
                        subsequence.Append(inputedSequence[nextIndex]);
                        subsequences.Add(subsequence.ToString());                        
                    }
                }
            }
            return subsequences;
        }

        public void DisplaySubsequence(HashSet<string> subsequenceList)
        {
            /// <summary>
            /// This method displays subseqences 
            /// </summary>
            foreach (string s in subsequenceList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
