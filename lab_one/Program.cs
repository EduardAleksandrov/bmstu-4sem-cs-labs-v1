/*
    Этап 1; Сделано
    Этап 2; Сделано
    Этап 3; Сделано
    Этап 4; Сделано
    Этап 5; Сделано
*/
using lab_one;

internal class Program
{
    private static void Main(string[] args)
    {
        string txt1 = "Hello my dear friend!";
        string txt2 = "How are you doing?";
        string txt3 = "Whatsapp my friend?";
        string[] options_eng = new [] { txt1, txt2, txt3 };
        string txt4 = "Привет дорогой друг!";
        string txt5 = "Как дела?";
        string txt6 = "Что новенького?";
        string[] options_rus = new [] { txt4, txt5, txt6 };

        var dictionary = new Dictionary<Lang, string[]>();
        dictionary.Add(Lang.English, options_eng);
        dictionary.Add(Lang.Russian, options_rus);

        Typing one = new Typing(0, DateTime.Now, DateTime.Now, 0);

        Statistics statistics= new Statistics();

        for(;;)
        {
            Console.WriteLine("\nНачните печатать, но вначале выберите язык (введите число): 1. English 2. Russian");
            string? lang_num = Console.ReadLine();
            int lang_num_str = 0;
            
            try
            {
                if(lang_num == null || lang_num.Length == 0) continue;
                else lang_num_str = int.Parse(lang_num);
            } catch
            {
                Console.WriteLine("Ошибка в знаке");
                continue;
            }
            
            Lang lang_choose;
            if(lang_num_str == 1) lang_choose = Lang.English;
            else if(lang_num_str == 2) lang_choose = Lang.Russian;
            else continue;

            var random = new Random();
            int r = random.Next(dictionary[lang_choose].Length); //выбираем номер текста

            DateTime startedAt = DateTime.Now;
            Console.WriteLine(dictionary[lang_choose][r]);
            string? get_txt = Console.ReadLine();
            DateTime endedAt = DateTime.Now;
            TimeSpan span = endedAt - startedAt;

            // задание данных по текущей попытке
            one.ArrayNumber = r; 
            one.StartTime = startedAt;
            one.EndTime = endedAt;
            one.NumMistakes = NumGettedMistakes(dictionary[lang_choose][r], get_txt);
            
            if(get_txt != null) statistics.PutData(span.TotalMilliseconds, get_txt.Length);
            
            Console.WriteLine($"---Количество ошибок в текущей попытке {one.NumMistakes} штук");
            Console.WriteLine($"---Время печати {span.Seconds}.{span.Milliseconds} seconds");
            Console.WriteLine($"---У Вас {statistics.TryesSum} попыток, среднее время {statistics.GetMidTime()} зн/мин, худшая {statistics.GetMinTime()} зн/мин, лудшая {statistics.GetMaxTime()} зн/мин");
            
            if(span.TotalMilliseconds < 15000) Console.WriteLine("---Результат хороший, быстрее 15 секунд, попробуйте еще раз? Да/Нет");
            else  Console.WriteLine("---Результат не очень, медленнее 15 секунд, попробуйте еще раз? Да/Нет");
            string? response = Console.ReadLine();
            if(response == "Нет") break; 
        }
    }
    enum Lang
    {
        English,
        Russian
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