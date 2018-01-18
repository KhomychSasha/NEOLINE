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

namespace UI
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : UserControl
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void LabelExit_MouseEnter(object sender, MouseEventArgs e)
        {
            LabelExit.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void LabelExit_MouseLeave(object sender, MouseEventArgs e)
        {
            LabelExit.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
