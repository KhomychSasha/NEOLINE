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


namespace UI
{
    public partial class RegistrationUser : UserControl
    {
        public RegistrationUser()
        {
            InitializeComponent();
        }

        protected Uri FileNameAvatar = null;

        protected Service1Client client = new Service1Client();


        private void ClickBTNSignup(object sender, RoutedEventArgs e)
        {

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
