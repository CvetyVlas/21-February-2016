namespace Problem02_EncodedAnswers
{
    using System;

    public class EncodedAnswers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = null;
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            for (int i = 0; i < n; i++)
            {
                uint answerAsNumber = uint.Parse(Console.ReadLine());
                string answer;

                if (answerAsNumber % 4 == 0)
                {
                    answer = "a";
                    countA++;
                }
                else if (answerAsNumber % 4 == 1)
                {
                    answer = "b";
                    countB++;
                }
                else if (answerAsNumber % 4 == 2)
                {
                    answer = "c";
                    countC++;
                }
                else
                {
                    answer = "d";
                    countD++;
                }

                result += answer + ' ';
            }

            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", countA, countB, countC, countD);
        }
    }
}
