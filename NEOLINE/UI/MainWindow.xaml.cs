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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello", "Hello", MessageBoxButton.OK);
        }

        private void AnswersAndQuestions_MouseEnter(object sender, MouseEventArgs e)
        {
            labelAnwersAndQuestions.Foreground = new SolidColorBrush(Colors.Red);
        }
       
        private void Credits_MouseEnter(object sender, MouseEventArgs e)
        {
            labelCredits.Foreground = new SolidColorBrush(Colors.Red);
        }
       
        private void DeliveryAndPayment_MouseEnter(object sender, MouseEventArgs e)
        {
            labelDeliveryAndPayment.Foreground = new SolidColorBrush(Colors.Red);
        }
       
        private void Guarantee_MouseEnter(object sender, MouseEventArgs e)
        {
            labelGuarantee.Foreground = new SolidColorBrush(Colors.Red);
        }
       
        private void Contacts_MouseEnter(object sender, MouseEventArgs e)
        {
            labelContacts.Foreground = new SolidColorBrush(Colors.Red);
        }
       
        private void SellOnNEOLINE_MouseEnter(object sender, MouseEventArgs e)
        {
            labelSellOnNEOLINE.Foreground = new SolidColorBrush(Colors.Red);
        }
       
      private void AnswersAndQuestions_MouseLeave(object sender, MouseEventArgs e)
      {
          labelAnwersAndQuestions.Foreground = new SolidColorBrush(Colors.Black);
      }
        private void Credits_MouseLeave(object sender, MouseEventArgs e)
        {
            labelCredits.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void DeliveryAndPayment_MouseLeave(object sender, MouseEventArgs e)
        {
            labelDeliveryAndPayment.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void Guarantee_MouseLeave(object sender, MouseEventArgs e)
        {
            labelGuarantee.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void Contacts_MouseLeave(object sender, MouseEventArgs e)
        {
            labelContacts.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void SellOnNEOLINE_MouseLeave(object sender, MouseEventArgs e)
        {
            labelSellOnNEOLINE.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            canvasDen.Children.Add(new UserWindow());
        }
    }
}