public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
         // Sort dictionary by length to ensure shortest root preference
        List<string> sortedDictionary = new List<string>(dictionary);
        sortedDictionary.Sort((a, b) => a.Length.CompareTo(b.Length));

        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++) {
            string word = words[i];
            foreach (var root in sortedDictionary) {
                if (word.StartsWith(root)) {
                    words[i] = root;
                    break; // Replace with the first (shortest) root and stop further checks
                }
            }
        }
        
        return string.Join(" ", words);
        
    }
}