namespace Tyuiu.MishaginaKS.Sprint1.Task6.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

public class DataService : ISprint1Task6V12
{
    public bool CheckLastWordRepetiton(string value)

    {
        value = value.Trim().TrimEnd('.', ',', '!', '?');
      string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 2) return false;

        string lastWord = words[words.Length - 1];

        int count = 0;
        foreach (string word in words)
        {

            if (word.Equals(lastWord, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }

        return count > 1;
    }
}
