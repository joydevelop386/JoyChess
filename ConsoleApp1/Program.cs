namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello,Chess World!");
            var board = new ChessBoard();
            board.Display();
        }
    }
}