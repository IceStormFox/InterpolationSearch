namespace InterpolationSearch
{
    internal class NextNumber
    {
        public static void Next(List<int> array, string message)
        {
            Console.WriteLine(message + " y/n");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Console.WriteLine("Wybierz kolejną liczbę: ");
                Program.TargetInput(array);
            }
            if (choice != "y" && choice != "n")
            {
                message = "Proszę wprowadź prawidłową odpowiedź na poprzednie pytanie: y - yes, n - no. ";
                Next(array, message);
            }
        }
    }
}