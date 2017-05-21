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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private static List<User> ListUser = new List<User>();

       
        Wpf_project.MainPage MP1 = new Wpf_project.MainPage();

        private void SignUp1_BT_Click(object sender, RoutedEventArgs e)
        {
            

            if (PasswordBox_Pas.Password != PasswordBox_RePas.Password)
                MessageBox.Show("Password != RePassword"); 

            else
            {
                User User1 = new User(TextBox_Name.Text, ComboBox_Age.Text, TextBox_NickName.Text, TextBox_Uni.Text, ComboBox_Graduate.Text, PasswordBox_Pas.Password);
                ListUser.Add(User1);

                MP1.TextBox_Login.Text = TextBox_Name.Text;
                MP1.PasswordBox_Password.Password = PasswordBox_Pas.Password;


                NavigationService.Navigate(Pages.MainPage);

            }
            
        }
    }
}
