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
using System.Windows.Shapes;

namespace ATMandIB
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int Pin { get; set; }
        int NumCard { get; set; }

        public Window1()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            this.lb3.Visibility = System.Windows.Visibility.Collapsed;
            this.lb4.Visibility = System.Windows.Visibility.Collapsed;
            this.tb2.Visibility = System.Windows.Visibility.Collapsed;
            this.rec1.Visibility = System.Windows.Visibility.Collapsed;
            this.rb1.Visibility = System.Windows.Visibility.Collapsed;
            this.rb2.Visibility = System.Windows.Visibility.Collapsed;
            this.lb2.Content = "Введите сумму";
            this.NumCard = Convert.ToInt32(tb1.Text);
            this.Pin = Convert.ToInt32(tb2.Text);
            //MessageBox.Show(this.NumCard.ToString() + " " + this.Pin.ToString());
            
        }
    }
}
