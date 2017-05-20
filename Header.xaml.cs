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

        private int Zu = 10;

        private void Task_add_BT_Click(object sender, RoutedEventArgs e)
        {

            Button List_BT1 = new Button();



            if (TextBox_Task.Text != null)
            {
                Todo_list.Todo_list1.Add(TextBox_Task.Text);
                ListBox_Task.Items.Add(TextBox_Task.Text);



            }
            
            if (TextBox_Task.Text == "" && TextBox_Task.Text == " " && TextBox_Task.Text == "  " && TextBox_Task.Text == "   ")
            {
                MessageBox.Show("enter task");
            }




        }

        private void Done_BT_Click(object sender, RoutedEventArgs e)
        {
          

        }

        private void Delete_BT_Click(object sender, RoutedEventArgs e)
        {
            ListBox_Task.Items.RemoveAt(ListBox_Task.SelectedIndex);

        }

        private void Choose_BT_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_Task.Text = ListBox_Task.SelectedItem.ToString();
        }

       
    }
}
