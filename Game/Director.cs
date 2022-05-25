namespace jumper.Game 
{

    public class Director
    {

        Jumper jumper;
        Puzzle puzzle = new Puzzle();
        TerminalService term = new TerminalService();
        private bool gameOver = false;

        public Director()
        {
            jumper = new Jumper(term);
            puzzle.GenerateNewWord();
        }

        public void StartGame()
        {
            while (!gameOver)
            {
                GetInput();
                DoUpdates();
                DoOutput();
            }
        }

        public void GetInput()
        {
            jumper.MakeGuess();
        }

        public void DoUpdates()
        {
            
        }

        public void DoOutput()
        {

        }
    }

}