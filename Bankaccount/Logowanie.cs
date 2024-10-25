using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bankaccount
{
    public partial class Logowanie : Form
    {


        public Logowanie()
        {
            InitializeComponent();
        }


        private Account FindAccount(string email, string password)
        {
            return Account.konta.FirstOrDefault(account => account.Email == email && account.Password == password);
        }
        private void Logowanie_Load(object sender, EventArgs e)
        {






        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            string email = Log.Text;
            string password = logpass.Text;



            Login login = new Login(email, password);

            if (login.Authenticate())
            {
                
                MessageBox.Show("Logowanie udane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Account foundAccount = Account.konta.First(account => account.Email == email); 
                Profil profil = new Profil(foundAccount);
                profil.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Błędne dane logowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1();
            register.ShowDialog();
            this.Hide();
        }
    }
}
