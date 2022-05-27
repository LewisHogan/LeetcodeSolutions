namespace _125_ValidPalindrome;
public class Solution
{
    public bool IsPalindrome(string s)
    {
        var sanitized = s.ToLower().ToCharArray().Where(c => char.IsLetterOrDigit(c)).ToArray();

        for (var startIndex = 0; startIndex < s.Length / 2; startIndex++)
        {
            if (sanitized[startIndex] != sanitized[s.Length - startIndex - 1]) return false;
        }

        return true;
    }
}
