namespace _20_ValidParentheses;
public class Solution
{
    private char? GetMatchingBracket(char c)
    {
        return c switch
        {
            ')' => '(',
            ']' => '[',
            '}' => '{',
            _ => null // Unreachable with input constraints
        };
    }

    public bool IsValid(string s) {
        var stack = new Stack<char>();
        
        foreach (var c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count() == 0) return false;

                var precedingBracket = stack.Pop();
                if (precedingBracket != GetMatchingBracket(c)) return false;
            }
        }

        return stack.Count() == 0;
    }
}
