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
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : Page
    {
        public Header()
        {
            InitializeComponent();
            
        }
        

        private void ON_BT_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void Stop_BT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Task_add_BT_Click(object sender, RoutedEventArgs e)
        {

            if (TextBox_Task.Text != null)
            {
                Todo_list.Todo_list1.Add(TextBox_Task.Text);

                ListBox_Task.ItemsSource = Todo_list.Todo_list1;
            }
            else
                MessageBox.Show("enter task");

        }
    }
}
