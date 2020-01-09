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

namespace WpfApplication2
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



        private void chia_Checked(object sender, RoutedEventArgs e)
        {
              double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            kq.Text = thuong(a, b).ToString();
        }
        public double thuong(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("<_>");
            }           
            return a / b;    
        
        }

        private void laydu_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void luythua_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ko_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void kq_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tinh_Click(object sender, RoutedEventArgs e)
        {
            if (txta.Text.Equals("") || txtb.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin");
            }
            else
            {
                int a = Convert.ToInt32(txta.Text);
                int b = Convert.ToInt32(txtb.Text);

                if (chia.IsChecked == true)

                    kq.Text = tru(a, b).ToString();
                if (laydu.IsChecked == true)

                    kq.Text = du(a, b).ToString();
                if (luythua.IsChecked == true)
                    kq.Text = mu(a, b).ToString();
                if (ko.IsChecked == true)
                    kq.Text = txta.Text + txtb.Text;
            }     
           
        }
        public double tru(double a, double b)
        {
            return a / b;
        }

        public double du(double a, double b)
        {
            return a % b;
        }

        public double mu(double a, double b)
        {
            return Math.Pow(a, b);
        }
        private void _out_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
