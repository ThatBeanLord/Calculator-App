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

namespace Calculator_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> currentNum { get; set; }
        List<int> nums { get; set; }
        List<string> functions { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            string displayText;
            
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            currentNum.Add(1);
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            currentNum.Add(2);
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            currentNum.Add(3);
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            currentNum.Add(4);
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            currentNum.Add(5);
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            currentNum.Add(6);
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            currentNum.Add(7);
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            currentNum.Add(8);
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            currentNum.Add(9);
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            currentNum.Add(0);
        }

        private void Button_Plus(object sender, RoutedEventArgs e)
        {
            nums.Add(Compile_Num(currentNum));
            functions.Add("Plus");
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            nums.Add(Compile_Num(currentNum));
            functions.Add("Minus");
        }

        private void Button_Times(object sender, RoutedEventArgs e)
        {
            nums.Add(Compile_Num(currentNum));
            functions.Add("Times");
        }

        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            nums.Add(Compile_Num(currentNum));
            functions.Add("Divide");
        }

        private void Button_Equals(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {

        }

        private int Compile_Num(List<int> currentNum)
        {
            int total = 0;
            foreach (int num in currentNum)
            {
                total = 10 * total + num;
            }
            return total;
        }
    }
}
