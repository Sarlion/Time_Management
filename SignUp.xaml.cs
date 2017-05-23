using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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

        User User1;



        private void SignUp1_BT_Click(object sender, RoutedEventArgs e)
        {
            

            if (PasswordBox_Pas.Password != PasswordBox_RePas.Password)
                MessageBox.Show("Password != RePassword"); 

            else
            {
                User1 = new User(TextBox_Name.Text, ComboBox_Age.Text, TextBox_NickName.Text, TextBox_Uni.Text, ComboBox_Graduate.Text, PasswordBox_Pas.Password);
                
                // User1.ListUser.Add(User1); я не знаю как сделать так, чтобы: при регистрации 
                //создавался отедельный лист с информацией о человеке и потом просто передавалась эта инфомармация на другую страницу.
                 
                User.ListUser.Add(User1);
                  
                NavigationService.Navigate(Pages.MainPage);

            }
            
            
        }
    }
}
