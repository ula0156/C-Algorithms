

namespace Test.MockInterviews
{
    public class ReplaceDigit
    {
        public static int SingleOccurrence(int num, int numToReplace, int numReplaceWith)
        {
            var rem = num % 10;
            if (rem == numToReplace)
            {
                rem = numReplaceWith;
                return (num/10) * 10 + rem;
            }

            num = SingleOccurrence(num/10, numToReplace, numReplaceWith);
            num = num * 10 + rem;
            return num;
        }

        public static int MultipleOccurrence(int num, int numToReplace, int numReplaceWith)
        {
            if (num == 0)
            {
                return 0;
            }

            var rem = num % 10;
            if (rem == numToReplace)
            {
                rem = numReplaceWith;
            }

            num = MultipleOccurrence(num / 10, numToReplace, numReplaceWith);
            num = num * 10 + rem;
            return num;
        }
    }
}
