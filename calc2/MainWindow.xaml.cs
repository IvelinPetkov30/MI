using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace mi2calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbox.Focus();
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += div.Content.ToString();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += zero.Content.ToString();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += one.Content.ToString();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += two.Content.ToString();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += three.Content.ToString();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += four.Content.ToString();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += five.Content.ToString();
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += nine.Content.ToString();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += eight.Content.ToString();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += seven.Content.ToString();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += six.Content.ToString();
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += comma.Content.ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "-";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += add.Content.ToString();
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += sub.Content.ToString();
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += mul.Content.ToString();
        }

        private void clr_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text = "";
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            calculate();
        }

        private void tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Return)
            {
                tbox.Focus();
            }else if(e.Key == Key.Return)
            {
                calculate();
            }
        }

        private void calc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                calculate();
            }
        }
        private void calculate()
        {
            double res = 0;
            string a;

            a = tbox.Text.ToString();
            DataTable dt = new DataTable();
            try
            {
                res = Convert.ToDouble(dt.Compute(a, ""));
                tbox.Clear();
                tbox.Text = res.ToString();
                tbox.Select(tbox.Text.Length, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input!");
            }
        }
    }
}
