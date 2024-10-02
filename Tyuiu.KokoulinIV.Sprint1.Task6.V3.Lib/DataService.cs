using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KokoulinIV.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string res = GetLastLetters(value);
            return res;
        }
        public string GetLastLetters(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string lastLetters = "";

            foreach (string word in words)
            {
                lastLetters += word[word.Length - 1]; 
            }

            return lastLetters;
        }
    }
}
