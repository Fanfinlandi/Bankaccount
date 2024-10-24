using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    public  class Account
    {
       
        public int Id { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }     
        public string Surname { get; set; }  
        public string AccountNumber { get; set; } 
        public DateTime DateOfBirth { get; set; } 


        public Account( int id ,string name, string surname, string accountNumber, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Surname = surname;
            AccountNumber = accountNumber;
            DateOfBirth = dateOfBirth;
        }
        public void DisplayData()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Imię: " + Name);
            Console.WriteLine("Nazwisko: " + Surname);
            Console.WriteLine("Numer konta: " + AccountNumber);
            Console.WriteLine("Data urodzenia: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Płeć: " + Sex);
        }

    }

    


}
