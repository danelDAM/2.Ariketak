using System.Windows;

namespace LaugarrenAriketa
{
    public partial class MainWindow : Window
    {
        String pasahitza = "1234";
        String erabiltzailea = "informatica";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void onartu(object sender, RoutedEventArgs e)
        {
            if (erabiltzaileaTB.Text == erabiltzailea &&
                pasahitzaErantzuna.Password == pasahitza)
            {
                alerta.Text = "Ongi etorri sistemara " + erabiltzaileaTB.Text;
            }
            else
            {
                alerta.Text = "Identifikatu gabeko erabiltzailea";
            }
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            erabiltzaileaTB.Text = "";
            pasahitzaErantzuna.Password = "";
            alerta.Text = "";
        }

        private void irten(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}