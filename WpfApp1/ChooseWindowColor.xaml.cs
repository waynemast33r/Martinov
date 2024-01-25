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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ChooseWindowColor.xaml
    /// </summary>
    public partial class ChooseWindowColor : Window
    {
        string ColorW = "White";
        public ChooseWindowColor()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                ColorW = item.Content.ToString();
            }
        }

        private void Choose_Color_Click(object sender, RoutedEventArgs e)
        {
            switch (ColorW)
            {
                case "White":
                    {
                        App.Current.MainWindow.Background = Brushes.White;
                        break;
                    }
                case "Red":
                    {
                        App.Current.MainWindow.Background = Brushes.Red;
                        break;
                    }
                case "Green":
                    {
                        App.Current.MainWindow.Background = Brushes.Green;
                        break;
                    }
                case "Blue":
                    {
                        App.Current.MainWindow.Background = Brushes.Blue;
                        break;
                    }
                case "Gray":
                    {
                        App.Current.MainWindow.Background = Brushes.Gray;
                        break;
                    }
            }
            Close();
        }
    }
}
