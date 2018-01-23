using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.ServiceReference1;

namespace UI
{
    public partial class LoginUser : UserControl
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void ClickBTNSignUp(object sender, RoutedEventArgs e)
        {
            RegistrationUser userReg = new RegistrationUser();

            
        }

        private string HashPass(string pass)
        {
            byte[] EncodePass = Encoding.Unicode.GetBytes(pass);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] HashBytesFromPass = md5.ComputeHash(EncodePass);

            string HashPass = null;

            foreach (var v in HashBytesFromPass)
            {
                HashPass += string.Format("{0:x2}", v);
            }

            return HashPass;
        }

        private void ClickBTNSignIn(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();

            if (client.VerificationOnExistUser(TBLogin.Text,HashPass(PBPass.Password)) == true)
            {
                
            }
            else
            {

            }
        }
    }
}
