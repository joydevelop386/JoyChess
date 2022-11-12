namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello,Chess World!");
            var board = new ChessBoard();
            board.Display();
            board.ReadMove();   

        }
    }
}