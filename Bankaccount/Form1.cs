using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bankaccount
{
    public partial class Form1 : Form
    {
        private List<Account> konta = new List<Account>();
        private bool dateSelected = false;
        private int id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkage()
        {
            DateTime pelnoletnosc = dataurodzenia.SelectionStart;

           
            if (DateTime.Now.Year - pelnoletnosc.Year < 18)
            {
                Date.Text = string.Empty;
                dateSelected = false;
            }
            else
            {
                dateSelected = true;
            }
        }

        private void dataurodzenia_DateSelected(object sender, DateRangeEventArgs e)
        {
            Date.Text = dataurodzenia.SelectionStart.ToShortDateString();
            checkage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nazwa.Text;
            string surname = Surname.Text;
            string email = Email.Text;
            string password = passmail.Text;

           
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || !dateSelected)
            {
                MessageBox.Show("Proszê wprowadziæ poprawne dane");
                return;
            }
            if (passmail.Text.Length < 8)
            {


                MessageBox.Show("Za krótke has³o");
                return;
            }
           

            if (!this.Email.Text.Contains('@') || !this.Email.Text.Contains('.'))
            {
                MessageBox.Show("Wpisz Poprawny E-mail!", "Niepoprawny E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Text = string.Empty;
                return;
            }

            



            string accountnumber = gennumber();
            string sex = checksex();
            if (sex == null)
            {
                return;
            }


            Account noweKonto = new Account(email, password, name, surname, accountnumber, dataurodzenia.SelectionStart);
            noweKonto.Sex = sex;
            konta.Add(noweKonto);

            MessageBox.Show("Konto utworzone pomyœlnie.\n" +
                "P³eæ: " + noweKonto.Sex + "\n" +
                "Imiê: " + noweKonto.Name + "\n" +
                "Nazwisko: " + noweKonto.Surname + "\n" +
                "Numer konta: " + noweKonto.AccountNumber + "\n" +
                "Email: " + noweKonto.Email + "\n" +
                "Has³o: " + noweKonto.Password + "\n" +
                "Data urodzenia: " + noweKonto.DateOfBirth.ToShortDateString());
                

           
            id++;
            label1.Text = "Liczba zarejestrowanych kont: " + id;

            clear();
            Debug.WriteLine("Lista wszystkich kont:");
            foreach (var account in konta)
            {
                account.DisplayData();
            }
        }

        void clear()
        {
            nazwa.Text = string.Empty;
            Surname.Text = string.Empty;
            Date.Text = string.Empty;
            male.Checked = false;
            female.Checked = false;
            Email.Text = string.Empty;
            passmail.Text = string.Empty;
        }

        private string gennumber()
        {
            Random random = new Random();
            string accountNumber = "1";

            for (int i = 0; i < 25; i++)
            {
                accountNumber += random.Next(0, 10).ToString();
            }

            return accountNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkdate()
        {
            dataurodzenia.Visible = !dataurodzenia.Visible;
        }

        private void datebtn_Click(object sender, EventArgs e)
        {
            checkdate();
        }

        private string checksex()
        {
            if (male.Checked && female.Checked)
            {
                MessageBox.Show("Proszê wybraæ tylko jedn¹ p³eæ.");
                return null;
            }
            else if (male.Checked)
            {
                return "Mê¿czyzna";
            }
            else if (female.Checked)
            {
                return "Kobieta";
            }
            else
            {
                MessageBox.Show("Proszê wybraæ p³eæ.");
                return null;
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
        }

        private void passmail_TextChanged(object sender, EventArgs e)
        {

           


        }
    }

}