namespace StringUtility
{
    public class StringUtility
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            if (stringToCheck == null)
            {
                return -1;
            }

            var stringAsCharArray = stringToCheck.ToLower().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToLower().ToCharArray()[0];
            var occuranceCount = 0;
            
            for (var characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
                return occuranceCount;
            
    
            
        }

    }
}