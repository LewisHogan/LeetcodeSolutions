namespace _242_ValidAnagram;
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        // Two possible approaches here:
        // 1. Convert both to arrays, sort the arrays, go element by element and check for match
        // 2. Iterate through the chars of one string, check if other contains said char and track occurances, exit out early if not enough
        var sChars = s.ToCharArray();
        Array.Sort(sChars);
        var tChars = t.ToCharArray();
        Array.Sort(tChars);

        for (var i = 0; i < sChars.Length; i++)
        {
            if (sChars[i] != tChars[i]) return false;
        }

        return true;
    }
}
