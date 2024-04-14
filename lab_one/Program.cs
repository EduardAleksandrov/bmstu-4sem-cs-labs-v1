/*
    Этап 1; Сделано
    Этап 2; Сделано
*/
using lab_one;

internal class Program
{
    private static void Main(string[] args)
    {
        string txt1 = "Hello my dear friend!";
        string txt2 = "How are you doing";
        string txt3 = "Whatsapp my friend";
        string[] options = new [] { txt1, txt2, txt3 };
        for(;;)
        {
            Console.WriteLine("\n Начни печатать");
            Console.ReadLine();

            DateTime startedAt = DateTime.Now;

            var random = new Random();
            int r = random.Next(options.Length);

            Console.WriteLine(options[r]);

            string? get_txt = Console.ReadLine();
            DateTime endedAt = DateTime.Now;
            TimeSpan span = endedAt - startedAt;
            
            Typing one = new Typing(r, startedAt, endedAt, NumGettedMistakes(options[r], get_txt)); 
            Console.WriteLine(one.NumMistakes);

            Console.WriteLine($"Время печати {span.Seconds}.{span.Milliseconds}, результат хороший попробуйте еще раз? Да/Нет");
            string? response = Console.ReadLine();
            if(response == "Нет") break; 

            

        }
    }
    private static int NumGettedMistakes(string? original, string? actual)
    {
        if(original != null && actual != null)
        {
            var board = new int[original.Length + 1, actual.Length + 1];
            for (var i = 0; i < board.GetLength(0); i++) board[i, 0] = i;
            for (var i = 0; i < board.GetLength(1); i++) board[0, i] = i;

            for (var i = 1; i < board.GetLength(0); i++)
            {
                for (var j = 1; j < board.GetLength(1); j++)
                {
                    var stringsEquals = original[i - 1] == actual[j - 1];
                    var add = (stringsEquals ? 0 : 1);
                    board[i, j] = Math.Min(board[i - 1, j - 1] + add * 1, Math.Min(board[i - 1, j] + 1, board[i, j - 1] + 1));
                }
            }           
            return board[original.Length, actual.Length];
        }
        return -1;
    }
}