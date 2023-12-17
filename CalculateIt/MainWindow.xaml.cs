using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculateIt
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

        private decimal _previousNumber;
        private string _previousOperation;
        private decimal _allNumber;
        private bool _IsWrite;

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            if(CheckPreviousOperationIsEqual())
            {
                TextBoxMain.Text = "";
                _previousOperation = "";
            }

            if (((Button)sender).Content == "+" || ((Button)sender).Content == "-" || ((Button)sender).Content == "/" || ((Button)sender).Content == "X")
            {
                _previousOperation = (string)((Button)sender).Content;
            }
            if ((_previousOperation == "+" || _previousOperation == "-" || _previousOperation == "/" || _previousOperation == "X") && _IsWrite == false)
            {
                TextBoxMain.Text = "";
                _IsWrite = true;
            }

            TextBoxMain.Text += ((Button)sender).Content;

        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (_previousOperation == "=")
            {
                _previousNumber = int.Parse(TextBoxMain.Text);
                _allNumber = _previousNumber;
                TextBoxSupport.Text = $"{TextBoxMain.Text}+";
                
                TextBoxMain.Text = "";
                _previousOperation = "+";
                
            }
            else
            {
                _previousNumber = Convert.ToInt32(TextBoxMain.Text);
                _previousOperation = "+";
                TextBoxSupport.Text += $"{TextBoxMain.Text}+";
                _allNumber += _previousNumber;
                TextBoxMain.Text = "";
            }

        }

        private void ButtonEqals_Click(object sender, RoutedEventArgs e)
        {
            if (CheckPreviousOperationIsEqual())
            {
                TextBoxMain.Text = "";
                TextBoxSupport.Text = "";
            }
            if (_previousOperation == "+")
            {
                TextBoxSupport.Text += $"{TextBoxMain.Text}=";
            }
            _allNumber += int.Parse(TextBoxMain.Text);

            TextBoxMain.Text = _allNumber.ToString();
            _previousOperation = "=";
            _allNumber = 0;

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _previousOperation = "";
            _previousNumber = 0;
            _allNumber = 0;
            TextBoxMain.Text = "";
            TextBoxSupport.Text = "";
        }

        private bool CheckPreviousOperationIsEqual()
        {
            bool result = false;
            if(_previousOperation == "=")
            {
                result = true;
            }

            return result;
        }
    }
}
