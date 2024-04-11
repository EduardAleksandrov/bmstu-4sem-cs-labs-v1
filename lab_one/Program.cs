/*
    Этап 1; Сделано
    Этап 2; Сделано
*/
internal class Program
{
    private static void Main(string[] args)
    {
        for(;;)
        {
            Console.WriteLine("Начни печатать");
            Console.ReadLine();

            DateTime startedAt = DateTime.Now;

            string txt1 = "Hello my dear friend!";
            string txt2 = "How are you doing";
            string txt3 = "Whatsapp my friend";
            string[] options = new [] { txt1, txt2, txt3 };
            var random = new Random();
            int r = random.Next(options.Length);

            Console.WriteLine(options[r]);

            string? get_txt = Console.ReadLine();
            TimeSpan span = DateTime.Now - startedAt;
            Console.WriteLine($"Время печати {span}, результат хороший попробуйте еще раз? Да/Нет");

            string? response = Console.ReadLine();
            if(response == "Нет") break; 



        }
        
    }
}