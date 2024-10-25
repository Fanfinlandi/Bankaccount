using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bankaccount
{
    public class Login 
    {
        private string email;
        private string password;

        public Login(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        
        public bool Authenticate()
        {
            var account = Account.konta.FirstOrDefault(a => a.Email == email);

            if (account != null && account.Password == password)
            {
                return true; 
            }

            return false; 
        }


    }






}
