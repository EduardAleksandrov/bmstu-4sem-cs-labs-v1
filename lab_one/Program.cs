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
            Console.WriteLine(txt1);

            string? get_txt = Console.ReadLine();
            TimeSpan span = DateTime.Now - startedAt;
            Console.WriteLine($"Время печати {span}, результат хороший попробуйте еще раз? Да/Нет");

            string? response = Console.ReadLine();
            if(response != "Да") break; 



        }
        
    }
}