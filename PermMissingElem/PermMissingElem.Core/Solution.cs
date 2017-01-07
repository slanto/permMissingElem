namespace PermMissingElem.Core
{
    public class Solution
    {
        public int  GetMissingElement(int[] a)
        {
            var maxLength = a.Length + a.Length + 1;
            var result = 0;
            for(int i = 0; i < maxLength; i++)
            {
                if (i < a.Length)
                {
                    result = result ^ a[i];
                }
                else
                {
                    result = result ^ i - (a.Length - 1);
                }
            }
            return result;
        }
    }
}
