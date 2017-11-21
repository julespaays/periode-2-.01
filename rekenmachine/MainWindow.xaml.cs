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
using System.IO;

namespace rekenmachine
{
    
    public partial class MainWindow : Window
      
    {
        public double getal1;
        public double getal2;
        public int uitkomst;
        public string strCommand;
        public MainWindow()
        {
            InitializeComponent();
            string strRip = "ripboi";
            string strLocation = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            string strContent = "cunt";


            File.WriteAllText(strLocation + strRip, strContent);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = Convert.ToString(getal1 + getal2);
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = Convert.ToString(getal1 - getal2);

        }

        private void maal_Click(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = Convert.ToString(getal1 * getal2);

        }

        private void delen_Click(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = Convert.ToString(getal1 / getal2);

        }

        private void Getal_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Getal_1.Text == "")
                return;
            getal1 = Convert.ToDouble(Getal_1.Text);
        }

        private void Getal_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Getal_2.Text == "")
                return;
                getal2 = Convert.ToDouble(Getal_2.Text);            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Getal_1.Text = "0";
            Getal_2.Text = "0";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://me.me/i/12329524");
            }
            catch { }
        }
    }
}
