using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ATMandIB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //public void StartWin(object s)
        //{
        //    Window win1 = new Window1();
        //    win1.Title = (string)s;
        //    win1.Show();
        //}


        public static void FileRead()
        {
            //FileStream fs = new FileStream("cards.txt", FileMode.Open,FileAccess.ReadWrite);
            //fs.Dispose();
            using (StreamReader r = File.OpenText("cards.txt"))
            {
                List<string> line = new List<string>();
                
                
                for(int i = 0; r.ReadLine() != null ;i++)
                {
                    line.Add(r.ReadLine());
                }
                string[,] data = new string[line.Count,5];
                foreach (string str in line)
                {
                    data = str.Split(';');
                }
            }
        }

        public static void FileWrite()
        {
            using (StreamWriter w = File.AppendText("cards.txt"))
            {
                w.WriteLine("");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            //object s1 = (object)"Банкомат";
            //object s2 = (object)"ИнтернетБанкинг";
            //Thread t1 = new Thread(StartWin);
            //Thread t2= new Thread(StartWin);
            //t1.Start(s1);
            //t2.Start(s2);

            Window win1 = new Window1();
            win1.Title = "Банкомат";
            win1.Show();

            Window win2 = new Window1();
            win2.Title = "ИнтернетБанкинг";
            
            win2.Show();

            //this.Visibility = System.Windows.Visibility.Hidden;


        }
    }
}
