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
using ShapeAreaCalculation;
using ShapeAreaCalculation.Classes;

namespace ShapeAreaCheck
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

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string firstSide = FirstSide.Text;
            string secondSide = SecondSide.Text;
            string thirdSide = ThirdSide.Text;

            double firstNumber;
            double secondNumber;
            double thirdNumber;

            Double.TryParse(firstSide.Trim(), out firstNumber);
            Double.TryParse(secondSide.Trim(), out secondNumber);
            Double.TryParse(thirdSide.Trim(), out thirdNumber);

            //MessageBox.Show(firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString());

            try
            {
                ResultLabel.Content = GetShape.Rectangle(firstNumber, secondNumber).Area;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
