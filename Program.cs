using System.Diagnostics;

namespace InterpolationSearch
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\Users\icest\source\repos\Projekt-wyszukiwanie-interpolacyjne\dane6s.txt";
            Console.WriteLine("Witaj. Ten program sprawdzi, czy podana przez Ciebie liczba znajduje się w pliku metodą wyszukiwania interpolacyjnego.");
            List<int> array = ReadEngine.Read(path);
            Console.WriteLine("Wpisz poszukiwaną przez siebie liczbę: ");
            TargetInput(array);
        }
        public static void TargetInput(List<int> array)
        {
            string message = "Czy chciałbyś poszukać kolejnej liczby?";
            int target;
            Stopwatch timer = new();
            try
            {
                target = int.Parse(Console.ReadLine());

                while (target < 0 || target > 10000000)
                {
                    Console.WriteLine("Wybierz liczbę z zakresu 0 - 10000000: ");
                    target = int.Parse(Console.ReadLine());
                }

                timer.Start();
                int position = SearchEngine.Search(array, target);
                timer.Stop();

                if (position >= 0)
                {
                    Console.WriteLine("Pozycja Twojego elementu w pliku to: {0}", position + 1);
                    Console.WriteLine("Czas wyszukiwania to: {0} ms", timer.ElapsedMilliseconds);
                    timer.Reset();
                }
                if (position == -1)
                {
                    Console.WriteLine("Twojego elementu nie ma w zbiorze.");
                    Console.WriteLine("Czas wyszukiwania to: {0} ms", timer.ElapsedMilliseconds);
                    timer.Reset();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Nieprawidłowy typ zmiennej.");
                message = "Czy chcesz spróbować jeszcze raz?";
            }
            NextNumber.Next(array, message);
        }
    }
}