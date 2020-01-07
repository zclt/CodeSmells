namespace CodeSmells
{
    public static class StringComparison
    {
        public static bool CompareText(string text, string textToBeCompare)
        {
            return text.Equals(textToBeCompare);
        }

        public static bool ComparePartialNumber(int number, int numberToBeCompare)
        {
            return number.ToString().StartsWith(numberToBeCompare.ToString());
        }
    }
}