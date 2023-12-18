using System.Globalization;
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

        private double _previousNumber;
        private string _previousOperation;
        private double _allNumber;
        private bool _IsWrite;

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            if (_previousOperation == "=")
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
            if (TextBoxSupport.Text == "" && TextBoxMain.Text == "")
            {

            }
            else if (_previousOperation == "=")
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _allNumber = _previousNumber;
                TextBoxSupport.Text = $"{TextBoxMain.Text}+";

                TextBoxMain.Text = "";
                _previousOperation = "+";

            }
            else
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _previousOperation = "+";
                TextBoxSupport.Text += $"{TextBoxMain.Text}+";
                _allNumber += _previousNumber;
                TextBoxMain.Text = "";
            }

        }
        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            if (_previousOperation == "=")
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _allNumber = _previousNumber;
                TextBoxSupport.Text = $"{TextBoxMain.Text}-";

                TextBoxMain.Text = "";
                _previousOperation = "-";

            }
            else
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _previousOperation = "-";
                TextBoxSupport.Text += $"{TextBoxMain.Text}-";
                _allNumber += _previousNumber;
                TextBoxMain.Text = "";
            }
        }
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxSupport.Text == "" && TextBoxMain.Text == "")
            {

            }
            else if (_previousOperation == "=")
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _allNumber = _previousNumber;
                TextBoxSupport.Text = $"{TextBoxMain.Text}*";

                TextBoxMain.Text = "";
                _previousOperation = "*";

            }
            else if (_previousOperation is null || _previousOperation == "")
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _previousOperation = "*";
                TextBoxSupport.Text += $"{TextBoxMain.Text}*";
                _allNumber = _previousNumber;
                TextBoxMain.Text = "";
            }
            else
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _previousOperation = "*";
                TextBoxSupport.Text += $"{TextBoxMain.Text}*";
                _allNumber *= _previousNumber;
                TextBoxMain.Text = "";
            }
        }
        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxSupport.Text == "" && TextBoxMain.Text == "")
            {

            }
            else if (_previousOperation == "=")
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _allNumber = _previousNumber;
                TextBoxSupport.Text = $"{TextBoxMain.Text}*";

                TextBoxMain.Text = "";
                _previousOperation = "/";

            }
            else if (_previousOperation is null || _previousOperation == "")
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _previousOperation = "/";
                TextBoxSupport.Text += $"{TextBoxMain.Text}/";
                _allNumber = _previousNumber;
                TextBoxMain.Text = "";
            }
            else
            {
                _previousNumber = double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);
                _previousOperation = "/";
                TextBoxSupport.Text += $"{TextBoxMain.Text}/";
                _allNumber /= _previousNumber;
                TextBoxMain.Text = "";
            }
        }

        private void ButtonEqals_Click(object sender, RoutedEventArgs e)
        {
            if (_previousOperation == "=")
            {
                TextBoxMain.Text = "";
                TextBoxSupport.Text = "";
            }
            if (_previousOperation == "+")
            {
                TextBoxSupport.Text += $"{TextBoxMain.Text}=";
                _allNumber += double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);

                TextBoxMain.Text = _allNumber.ToString(CultureInfo.InvariantCulture);
                _previousOperation = "=";
                _allNumber = 0;
            }
            if (_previousOperation == "-")
            {
                TextBoxSupport.Text += $"{TextBoxMain.Text}=";
                _allNumber -= double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);

                TextBoxMain.Text = _allNumber.ToString(CultureInfo.InvariantCulture);
                _previousOperation = "=";
                _allNumber = 0;
            }
            if (_previousOperation == "*")
            {
                TextBoxSupport.Text += $"{TextBoxMain.Text}=";

                _allNumber *= double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);

                TextBoxMain.Text = _allNumber.ToString(CultureInfo.InvariantCulture);
                _previousOperation = "=";
                _allNumber = 0;
            }
            if (_previousOperation == "/")
            {
                TextBoxSupport.Text += $"{TextBoxMain.Text}=";

                _allNumber /= double.Parse(TextBoxMain.Text, CultureInfo.InvariantCulture);

                TextBoxMain.Text = _allNumber.ToString(CultureInfo.InvariantCulture);
                _previousOperation = "=";
                _allNumber = 0;
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _previousOperation = "";
            _previousNumber = 0;
            _allNumber = 0;
            TextBoxMain.Text = "";
            TextBoxSupport.Text = "";
        }


        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxMain.Text == "")
            {
                TextBoxMain.Text = "0.";
            }
            else
            {
                TextBoxMain.Text += ".";
            }
        }
    }
}
