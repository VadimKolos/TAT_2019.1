using System;
using System.Text;
using System.Collections.Generic;

namespace task_DEV1
{
    /// <summary>
    /// This class works with input sequence.
    /// </summary>
    class SubsequenceSearcher
    {
        public string inputedSequence { get; set; }
        /// <summary>
        /// This constructor check input sequense.
        /// </summary>
        public SubsequenceSearcher(string inputedSequence)
        {
            if (inputedSequence.Length < 2)
            {
                this.inputedSequence = string.Empty;
                Console.WriteLine("Incorrect input");
            }
            else
            {
                this.inputedSequence = inputedSequence;
            }
        }
        /// <summary>
        /// This method calculates unique subsequence from the input sequense.
        /// </summary>
        /// <param name="inputedSequence">input string (sequnce)</param>
        /// <param name="sequences">unique subsequences from input sequence</param>
        public HashSet<string> SubsequenceFinder()
        {
            var subsequences = new HashSet<string>();
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
            return subsequences;
        }

        /// <summary>
        /// This method displays subseqences. 
        /// </summary>
        public void DisplaySubsequence(HashSet<string> subsequences)
        {
            foreach (string s in subsequences)
            {
                Console.WriteLine(s);
            }
        }
    }
}
