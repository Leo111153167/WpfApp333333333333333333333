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

namespace WpfApp333333333333333333333
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncon_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txthei.Text, out double height_cm) && height_cm > 0 && height_cm < 300)
            {
                double height_m = height_cm / 100;
                if (double.TryParse(txtwei.Text, out double weight) && weight > 0 && weight < 500)
                {
                    double bmi = weight / (height_m * height_m);
                    txtshow.Text = bmi.ToString("F2");
                } 
                else
                {
                    txtshow.Text = "體重有誤";
                }
            }
            else
            {
                txtshow.Text = "身高有誤";
            }
        }
    }
}
