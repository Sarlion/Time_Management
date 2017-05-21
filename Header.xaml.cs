using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


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
            timer.Start();
        }

        private void Stop_BT_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }



        private void Task_add_BT_Click(object sender, RoutedEventArgs e)
        {


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
            if (ListBox_Task.SelectedIndex >= 0)
            {
                TextBlock_Task.Text = ListBox_Task.SelectedItem.ToString();
            }
        }

        DispatcherTimer timer = new DispatcherTimer();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;


        }

        int min = 0, sec = 0, msec = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
        

            msec = msec + 1;

            if (msec == 60)
            {

                sec = sec + 1;

                if (sec == 60)
                {

                    min = min + 1;

                    lbl_min.Content = min.ToString();

                    sec = 0;
                }
                else
                {
                    lbl_sec.Content = sec.ToString();
                }

                msec = 0;

            }

            else
            {
                lbl_min.Content = min.ToString();
            }

            lbl_msec.Content = msec.ToString();

        }
    }
}
