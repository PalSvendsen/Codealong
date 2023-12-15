//Du skal lage en konsollapp som oppfører seg som en nettbank. Man skal kunne se hvor mye man har på konto, sette inn penger og overføre penger til en annen konto
namespace Codealong
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer("Pål", 34, 1000000);
            Accounts account = new Accounts("Brukskonto", 200000);

            while (true)
            {
            Console.WriteLine("Velkommen til nettbanken");

            Console.WriteLine("Hva kan jeg hjelpe deg med?");

            Console.WriteLine("1. Sjekk saldo");

            Console.WriteLine("2. Overføre penger til annen konto");

            Console.WriteLine("3. Sette inn penger til konto/ta ut penger");

            Console.WriteLine("4. Legg til ny konto");

            Console.WriteLine("5. Logg ut");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.Clear();
                    customer.MyAccount();
                    break;
                case "2":
                    Console.Clear();
                    customer.MyMoney();
                    break;
                case "3":
                    Console.Clear();
                    customer.AddToAccount();
                    break;
                case "4":
                    Console.Clear();
                    customer.NewAccount();
                        break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
}