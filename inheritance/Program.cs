using inheritance.Entities;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma nova instância de BusinessAccount com valores específicos
            BusinessAccount account = new BusinessAccount(220, "Simao M", 1000000, 100.0);

            Console.WriteLine(account.Holder);
            Console.WriteLine(account.Number);
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.LoanLimit);
        }
    }
}
