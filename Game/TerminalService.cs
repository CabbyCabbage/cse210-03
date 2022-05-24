namespace jumper.Game 
{

    public class TerminalService 
    {

        public TerminalService()
        {
        }

        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public string Input(string s)
        {
            Console.Write(s);
            return Console.ReadLine();
        }
    }

}