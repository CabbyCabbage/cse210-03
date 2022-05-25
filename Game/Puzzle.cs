namespace jumper.Game 
{

    public class Puzzle
    {

        private string[] words;
        private string secretWord;
        private bool isInWord;

        public Puzzle()
        {
            words = File.ReadAllLines(".\\Game\\words.txt");
        }

        public void GenerateNewWord()
        {
            Random r = new Random();
            secretWord = words[r.Next(1, words.Length+1)];
            // Take out later 
            Console.WriteLine(secretWord);
        }

        public int GetSecretIndex(string guess)
        {
            int secretIndex = secretWord.IndexOf(char.Parse(guess));
            if (secretIndex >= 0)
            {
                isInWord = true;
            } 
            else 
            {
                isInWord = false;
            }
            return secretIndex;
        }

        public bool GetisInWord()
        {
            return isInWord;
        }

    }
    
}