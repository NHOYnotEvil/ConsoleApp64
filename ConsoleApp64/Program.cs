namespace ConsoleApp64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCounts = 3;
            int remainder = 1;
            int result;
            string password = "secret";
            string userInput;

            Console.WriteLine("Когда посох - сильнее меча?");

            for (int i = 0; i < tryCounts; i++)
            {
                Console.Write("Введите парорль:");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.WriteLine("Ответ прост - когда он в умелых руках.");
                    break;
                }
                else
                {
                    result = tryCounts - i - remainder;
                    Console.WriteLine("У вас осталось - " + result + " попыток.");
                }
            }
        }
    }
}