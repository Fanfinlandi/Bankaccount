using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bankaccount
{
    public partial class Form1 : Form
    {
        private Account konto;
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

            if (pelnoletnosc.Year > 2006)
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

           


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || !dateSelected)
            {
                MessageBox.Show("Proszê wprowadziæ poprawne dane");
                return;
                checkage();
            }

            

            string accountnumber = gennumber();
            string sex = checksex();
            if (sex == null)
            {
                return;
            }
            konto = new Account(id++, name, surname, accountnumber, dataurodzenia.SelectionStart)
            {
                Sex = sex
            };
            
                
            

            MessageBox.Show("Konto utworzone pomyœlnie.\n" +
                "P³eæ:"+konto.Sex + " \n"+
                "Imiê: " + konto.Name + "\n" +
                "Nazwisko: " + konto.Surname + "\n" +
                "Numer konta: " + konto.AccountNumber + "\n" +
                "Data urodzenia: " + konto.DateOfBirth.ToShortDateString());
            clear();

            
            label1.Text = "Liczba zarejestrowanych kont: " + id;


        }



        void clear()
        {
            nazwa.Text = string.Empty;
            Surname.Text = string.Empty;
            Date.Text = string.Empty;
            male.Checked = false;
            female.Checked = false;
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


         private string  checksex()
        {
            
            string Sex ="";
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
    }
}