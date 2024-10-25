using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bankaccount
{
    public class Account
    {
        public static List<Account> konta = new List<Account>(); 

        public string Sex { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Account(string email, string password, string name, string surname, string accountNumber, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            AccountNumber = accountNumber;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;

            konta.Add(this);
        }

        public void DisplayData()
        {
            Console.WriteLine("Imię: " + Name);
            Console.WriteLine("Nazwisko: " + Surname);
            Console.WriteLine("Numer konta: " + AccountNumber);
            Console.WriteLine("Data urodzenia: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Płeć: " + Sex);
        }
    }




}
