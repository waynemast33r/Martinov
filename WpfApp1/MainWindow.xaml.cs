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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ChoseColor;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лабораторная работа №3\nВыполнил студент Cафронов Михаил");
        }
        private void Close_Programm(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Mouse_Chenge(object sender, RoutedEventArgs e)
        {
            StatusInfo.Text = "Выбранный элемент:";
            Element.Text = ((FrameworkElement)sender).Name.ToString();
        }
        private void Mouse_Leave(object sender, RoutedEventArgs e)
        {
            StatusInfo.Text = "";
            Element.Text = "";
        }

        private void Choose_Color_Click(object sender, RoutedEventArgs e)
        {
            ChooseWindowColor chooseWindowColor = new ChooseWindowColor();
            chooseWindowColor.Show();
        }
    }
}
