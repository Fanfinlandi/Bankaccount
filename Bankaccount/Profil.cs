using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankaccount
{
    public partial class Profil : Form
    {
        private Account userAccount;

        public Profil(Account account)
        {
            InitializeComponent();
            userAccount = account;
            DisplayUserData();
        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }
        private void DisplayUserData()
        {
            label1.Text = userAccount.Name;
            label2.Text = userAccount.Surname;
            label3.Text = userAccount.Email;
            label4.Text = userAccount.AccountNumber;
            label5.Text = userAccount.DateOfBirth.ToShortDateString();
            label6.Text = userAccount.Sex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
