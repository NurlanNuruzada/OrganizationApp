namespace Human.Services.Utilities;

public static class Helper
{
    public static void WordCounter(this string sentence, string word)
    { 
        int result = 0;
 
        string[] stringArray = sentence.Split(' ');
        foreach (string item in stringArray)
        {
            if (item == word)
            {
                result++;
            }
        }
        {
            Console.WriteLine(result);
        }
    }
}