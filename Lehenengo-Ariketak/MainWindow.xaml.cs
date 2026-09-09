using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lehenengo_Ariketak
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

        private void Kalkulatu_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtLehenengoZenbakia.Text);
            double b = Convert.ToDouble(txtBigarrenZenbakia.Text);
            double c = Convert.ToDouble(txtHirugarrenZenbakia.Text);
            double d = Convert.ToDouble(txtLaugarrenZenbakia.Text);


            double emaitza = (a + 2 * b + 3 * c + 4 * d) / 4;

            txtEmaitza.Text = emaitza.ToString();
        }

        private void garbitu_Click(object sender, RoutedEventArgs e) {
            txtLehenengoZenbakia.Text = "";
            txtBigarrenZenbakia.Text = "";
            txtHirugarrenZenbakia.Text = "";
            txtLaugarrenZenbakia.Text = "";
            txtEmaitza.Text = "";
        }

        private void itxi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}