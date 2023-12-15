using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Accounts> accountList { get; set; }

        public int Money { get; set; }

        public Customer(string name, int age, int money)
        {
            Name = name;
            Age = age;
            Money = money;
            accountList = new List<Accounts>
            {
                new Accounts("Brukskonto", 200000),
                new Accounts("Sparekonto", 10000)
            };
        }

        public void MyAccount()
        {
            foreach (var account in accountList)
            {
                Console.WriteLine(account.AccountName);

                Console.WriteLine(account.Money);
            }

        }
        
        public void AddToAccount()
        {
            Console.WriteLine("Sette inn/Ta ut penger");

            Console.WriteLine("1. Sette inn");

            Console.WriteLine("2. Ta ut");

            string konto = Console.ReadLine();

            if (konto == "1")
            {
                Console.WriteLine("Hvilken konto vil du administrere?");

                Console.WriteLine("1. Brukskonto");

                Console.WriteLine("2. Sparekonto");

                string valg = Console.ReadLine();

                if (valg == "1")
                {
                    Console.WriteLine($"Saldo brukskonto:{accountList[0].Money}");

                    Console.WriteLine("Hvor mye penger vil du sette inn?");

                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount <= Money)
                    {
                        accountList[0].Money += amount;
                        Console.WriteLine($"Saldo brukskonto: {accountList[0].Money}");
                    }
                    else if (amount > Money)
                    {
                        Console.WriteLine("Kan ikke sette inn antall penger");
                    }
                }
                else if (valg == "2")
                {
                    Console.WriteLine($"Saldo sparekonto:{accountList[1].Money}");

                    Console.WriteLine("Hvor mye penger vil du sette inn?");

                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount <= Money)
                    {
                        accountList[1].Money += amount;
                    Console.WriteLine($"Saldo sparekonto: {accountList[1].Money}");
                    }
                    else if (amount > Money)
                    {
                        Console.WriteLine("Kan ikke sette inn antall penger");
                    }
                }
                else
                {
                    Console.WriteLine("Konto finnes ikke!");
                }
            }
            else if (konto == "2")
            {
                Console.WriteLine("Hvilken konto vil du administrere?");

                Console.WriteLine("1. Brukskonto");

                Console.WriteLine("2. Sparekonto");

                string valg = Console.ReadLine();

                if (valg == "1")
                {
                    Console.WriteLine($"Saldo brukskonto:{accountList[0].Money}");

                    Console.WriteLine("Hvor mye penger vil du ta ut?");

                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount <= accountList[0].Money)
                    {
                        accountList[0].Money -= amount;
                        Console.WriteLine($"Saldo Brukskonto: {accountList[0].Money}");
                    }
                    else if (amount > accountList[0].Money)
                    {
                        Console.WriteLine("Ikke nok penger på konto!");
                    }
                }
                else if (valg == "2")
                {
                    Console.WriteLine($"Saldo sparekonto:{accountList[1].Money}");

                    Console.WriteLine("Hvor mye penger vil du ta ut?");

                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount <= accountList[1].Money)
                    {
                        accountList[1].Money -= amount;
                        Console.WriteLine($"Saldo Sparekonto: {accountList[1].Money}");
                    }
                    else if (amount > accountList[1].Money)
                    {
                        Console.WriteLine("Ikke nok penger på konto!");
                    }
                }
                else
                {
                    Console.WriteLine("Konto finnes ikke!");
                }
            }
        }

        public void MyMoney()
        {
            Console.WriteLine("Hvilken konto vil du overføre fra?");

            Console.WriteLine("1. Brukskonto");

            Console.WriteLine("2. Sparekonoto");

            string valg = Console.ReadLine();

            if (valg == "1")
            {
                Console.WriteLine("Overfør penger fra Brukskonto til Sparekonto");

                Console.WriteLine("Hvor mye vil du overføre?");

                Console.WriteLine($"Saldo brukskonto: {accountList[0].Money}");

                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount <= accountList[0].Money)
                {
                   accountList[0].Money -= amount;
                    accountList[1].Money += amount;

                    Console.WriteLine($"Saldo brukskonto: {accountList[0].Money}");
                }
                else if (amount > accountList[0].Money)
                {
                    Console.WriteLine("Ikke nok penger!");
                }
            }
            else if (valg == "2")
            {
                Console.WriteLine("Overfør penger fra Sparekonto til Brukskonto");

                Console.WriteLine("Hvor mye vil du overføre?");

                Console.WriteLine($"Saldo sparekonto: {accountList[1].Money}");

                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount <= accountList[1].Money)
                {
                    accountList[1].Money -= amount;

                    accountList[0].Money += amount;

                    Console.WriteLine($"Saldo sparekonto {accountList[1].Money}");
                }
                else if (amount > accountList[1].Money)
                {
                    Console.WriteLine("Ikke nok penger!");
                }
            }
            else
            {
                Console.WriteLine("Konto finnes ikke!");
            }
        }

        public void NewAccount()
        {
            Console.WriteLine("Legg til ny konto");

            Console.WriteLine("Hva er navnet på den nye kontoen?");

            string kontonavn = Console.ReadLine();

            Console.WriteLine($"Hvor mye penger vil du sette inn på {kontonavn}?");

            int amount = Convert.ToInt32(Console.ReadLine());

            Money -= amount;

            accountList.Add(new Accounts(kontonavn, amount));

            Console.WriteLine($"Ny konto '{kontonavn}' opprettet med saldo {amount}");
        }
    }
}