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
using Microsoft.Win32;

namespace WpfApp2
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

        public string InitialDirectory { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();

        }

        private void SelectedImage(object sender, RoutedEventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Рисунки|*.gif;*.png;*.jpeg;*.jpg;|Любые файлы|*.**",
                    Title = "выбери"
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    string filePath = openFileDialog.FileName;
                    BitmapImage bitmap = new BitmapImage(new Uri(filePath));
                    img1.Source = bitmap;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Close();
        }

        private void btnShowPopup_Click(object sender, RoutedEventArgs e)
        {
            Window4 popup = new Window4();
            popup.ShowDialog(); // Используем ShowDialog для модального окна
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            this.Close();
        }
    }
}


