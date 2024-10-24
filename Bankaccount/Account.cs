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
        }

        public void DisplayData()
        {
            Console.WriteLine("Witaj w systemie Bankowym Admina,o to dane zarejestrowanych kont:");
            Debug.WriteLine("Płeć: " + Sex);
            Debug.WriteLine("Imię: " + Name);
            Debug.WriteLine("Nazwisko: " + Surname);
            Debug.WriteLine("Data urodzenia: " + DateOfBirth.ToShortDateString());
            Debug.WriteLine("Numer konta: " + AccountNumber);           
            Debug.WriteLine("Email: " + Email);
            Debug.WriteLine("Hasło: " + Password);
            Debug.WriteLine("-----------------------");


        }
    }




}
