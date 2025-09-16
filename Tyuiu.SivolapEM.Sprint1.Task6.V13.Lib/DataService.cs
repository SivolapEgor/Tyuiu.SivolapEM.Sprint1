using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SivolapEM.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            var letters = value.ToLower().Where(char.IsLetter).ToArray();

            if (letters.Length < 2 ) return true;

            for (int i = 0; i < letters.Length - 1; i++) if (letters[i] > letters[i + 1]) return false;

            return true;
        }
    }
}
