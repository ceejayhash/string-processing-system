using System;

class StringService
{
    private string originalText = "";
    private string currentText = "";

    public void SetText(string text)
    {
        originalText = text;
        currentText = text;
    }

    public string GetText()
    {
        return currentText;
    }

    public void ToUpperCase()
    {
        currentText = currentText.ToUpper();
    }

    public void ToLowerCase()
    {
        currentText = currentText.ToLower();
    }

    public int CountCharacters()
    {
        return currentText.Length;
    }

    public bool ContainsWord(string word)
    {
        return currentText.Contains(word);
    }

    public void ReplaceWord(string oldWord, string newWord)
    {
        currentText = currentText.Replace(oldWord, newWord);
    }

    public void ExtractSubstring(int start, int length)
    {
        if (start >= 0 && start + length <= currentText.Length)
            currentText = currentText.Substring(start, length);
        else
            Console.WriteLine("Invalid substring range.");
    }

    public void TrimSpaces()
    {
        currentText = currentText.Trim();
    }

    public void Reset()
    {
        currentText = originalText;
    }
}
