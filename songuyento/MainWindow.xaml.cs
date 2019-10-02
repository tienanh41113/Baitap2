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

namespace songuyento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mang = {7, 5, 6, 9, 3}; 
        public MainWindow()
        {
            InitializeComponent();
        }  
        private void btntong_Click(object sender, RoutedEventArgs e)
        {
            int s = 0;
            foreach (int i in mang)
                s += i;
            txtkq.Text = "Tổng = " + s.ToString();
        }

        private void btntongle_Click(object sender, RoutedEventArgs e)
        {
            int s = 0;
            foreach (int i in mang)
                if (i % 2 != 0)
                    s += i;
            txtkq.Text = "Tổng lẻ = " + s.ToString();
        }
    }
}
