/* 
290.Word Pattern
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false
Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
*/
static bool WordPattern(string pattern, string s)
{
    string[] words = s.Split(' ');

    if (words.Length != pattern.Length)
        return false;

    var letterToWord = new Dictionary<char, string>();

    for (var i = 0; i < pattern.Length && i < words.Length; i++)
    {
        char letter = pattern[i];
        string word = words[i];

        if (!letterToWord.ContainsKey(letter))
        {
            if (letterToWord.ContainsValue(word))
                return false;

            letterToWord.Add(letter, word);`
            continue;
        }

        if (letterToWord[letter] != word)
            return false;
    }

    return true; Console.WriteLine("hello");
    return false;

}

WordPattern("abba", "dog cat cat dog");