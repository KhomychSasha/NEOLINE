using System;
using System.Collections.Generic;
using System.Linq;
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
using WinForm = System.Windows.Forms;
using Microsoft.Win32;
using UI.ServiceReference1;
using System.Security.Cryptography;

namespace UI
{
    public partial class RegistrationUser : UserControl
    {
        public RegistrationUser()
        {
            InitializeComponent();
        }

        protected Uri FileNameAvatar = null; protected bool flagForSkipToReg = false;

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

        private void ClickBTNSignup(object sender, RoutedEventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();

                if (TBLogin.Text != "" && TBNickname.Text != "" && TBEmail.Text != "" && PBPass.Password != "")
                {
                    flagForSkipToReg = true;
                }

                if (client.VerificationLogin(TBLogin.Text) == false)
                {
                    if (client.VerificationNickname(TBNickname.Text) == false)
                    {
                        if (flagForSkipToReg == true)
                        {
                            client.AddUser(TBLogin.Text, HashPass(PBPass.Password), TBNickname.Text, TBEmail.Text, MEAvatar);
                            LBLMessage.Content = "!!!--You succesfully registred--!!!";
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        LBLMessage.Content = "The same nickname is already exist";
                    }
                }
                else
                {
                    LBLMessage.Content = "The same login is already exist";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Process is down because: " + ex.Message);
            }
        }

        private void ClickAnAvatar(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();

            if (result == true)
            {
                FileNameAvatar = new Uri(dialog.FileName);
            }

            if (FileNameAvatar != null)
            {
                MEAvatar.Source = FileNameAvatar;
            } 
        }

        private void ClickFinishAnAvatar(object sender, MouseButtonEventArgs e)
        {
          
        }
    }
}
