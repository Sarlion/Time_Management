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
using System.Media;

namespace Wpf_project
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : Page
    {

        // доделать с ползунком времени и окончанием времени 

        public Header()
        {
            InitializeComponent();
        }


        int min, sec, msec;
        int min1=0, sec1=0, msec1=0, all=0;

        int value_now;
        SoundPlayer sp = new SoundPlayer();


        private void ON_BT_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            ComboBox_min.Visibility = Visibility.Hidden;
            ComboBox_sec.Visibility = Visibility.Hidden;
            ComboBox_msec.Visibility = Visibility.Hidden;

            lbl_min.Visibility = Visibility.Visible;
            lbl_sec.Visibility = Visibility.Visible;
            lbl_msec.Visibility = Visibility.Visible;
            

            min = int.Parse(ComboBox_min.SelectedItem.ToString());
            sec = int.Parse(ComboBox_sec.SelectedItem.ToString());
            msec = int.Parse(ComboBox_msec.SelectedItem.ToString());

            OFF_BT.Visibility = Visibility.Visible;
            ON_BT.Visibility = Visibility.Hidden;
            
        }

        private void Stop_BT_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }



        private void Task_add_BT_Click(object sender, RoutedEventArgs e)
        {


            if (TextBox_Task.Text != null)
            {
                // Todo_list.Todo_list1.Add(TextBox_Task.Text); (пока не знаю для чего это нужно...) 

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

        private void OFF_BT_Click(object sender, RoutedEventArgs e)
        {
            ON_BT.Visibility = Visibility.Visible;
            OFF_BT.Visibility = Visibility.Hidden;

            ComboBox_min.Visibility = Visibility.Visible;
            ComboBox_sec.Visibility = Visibility.Visible;
            ComboBox_msec.Visibility = Visibility.Visible;

            lbl_min.Visibility = Visibility.Hidden;
            lbl_sec.Visibility = Visibility.Hidden;
            lbl_msec.Visibility = Visibility.Hidden;

            timer.Stop();
            lbl_min.Content = "0";
            lbl_sec.Content = "0";
            lbl_msec.Content = "0";

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

            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;

            for (int i = 0; i <= 60; i++)
            {
                ComboBox_min.Items.Add(i);
            }

            for (int i = 0; i <= 60; i++)
            {

                ComboBox_sec.Items.Add(i);
            }

            for (int i = 0; i <= 60; i++)
            {

                ComboBox_msec.Items.Add(i);
            }

            ComboBox_msec.SelectedIndex = 0;
            ComboBox_sec.SelectedIndex = 0;
            ComboBox_min.SelectedIndex = 20;

            sp.SoundLocation = "Sounds/time_finish.wav"; 
            

        }

        
        private void Timer_Tick(object sender, EventArgs e)
        {
            all = min * 60 + sec; // чему равняется 100
            int value_five = all * 5 / 100; // чему равняется 1/20 (5%)
            

            msec1 = msec1 + 1;

            if(msec1 == 60)
            {
                sec1 = sec1 + 1;
                
                if(sec1 == 60)
                {
                    min1 = min1 + 1;

                    
                    lbl_min.Content = min1.ToString();
                    sec1 = 0;

                }

                lbl_sec.Content = sec1.ToString();
                msec1 = 0;
            }
            lbl_msec.Content = msec1.ToString();


            value_now = min1 * 60 + sec1;

            for (int i = 0; i <= 20; i++)
            {
                if(value_now == value_five*i)
                {
                    Progress_Task.Value = i*5;
                }
            }

            if (min1 == min && sec1 == sec)
            {
                timer.Stop();
                MessageBox.Show("Your time is going up");

                sp.Load();
                sp.PlayLooping();
                Thread.Sleep(500);
                sp.Stop();


                lbl_min.Content = 0;
                lbl_sec.Content = 0;
                lbl_msec.Content = 0;

                ComboBox_min.Visibility = Visibility.Visible;
                ComboBox_sec.Visibility = Visibility.Visible;
                ComboBox_msec.Visibility = Visibility.Visible;

                lbl_min.Visibility = Visibility.Hidden;
                lbl_sec.Visibility = Visibility.Hidden;
                lbl_msec.Visibility = Visibility.Hidden;

            }


        }
        
    }
}
