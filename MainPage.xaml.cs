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

namespace Wpf_project
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SignIn_Bt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.Header);
        }

        private void SignUp_Bt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.SignUp);
        }

        private void PasswordBox_Password_MouseEnter(object sender, MouseEventArgs e)
        {
            PasswordBox_Password.FontSize = 30;
        }

        private void PasswordBox_Password_MouseLeave(object sender, MouseEventArgs e)
        {
            PasswordBox_Password.FontSize = 20;
        }

        private void TextBox_Login_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Login.FontSize = 30;
        }

        private void TextBox_Login_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Login.FontSize = 20;
        }

        private void SignIn_Bt_MouseEnter(object sender, MouseEventArgs e)
        {
            SignIn_Bt.FontSize = 30;
        }

        private void SignIn_Bt_MouseLeave(object sender, MouseEventArgs e)
        {
            SignIn_Bt.FontSize = 20;
        }

        private void SignUp_Bt_MouseEnter(object sender, MouseEventArgs e)
        {
            SignUp_Bt.FontSize = 30;
        }

        private void SignUp_Bt_MouseLeave(object sender, MouseEventArgs e)
        {
            SignUp_Bt.FontSize = 20;
        }
    }
}
