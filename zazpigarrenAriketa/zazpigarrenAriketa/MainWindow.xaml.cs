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

namespace zazpigarrenAriketa
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

        double numero1 = 0;
        String operador = "";
        bool numeroNuevo = true;



        private void clickZenbaki(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            if (numeroNuevo)
            {
                pantalla.Text = boton.Content.ToString();
                numeroNuevo = false;

            }
            else
            {
                pantalla.Text += boton.Content.ToString();
            }
        }

        private void operacionClick( object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;

            numero1 = Convert.ToDouble(pantalla.Text);
            operador = boton.Content.ToString();
            numeroNuevo = true;
        }

        private void igualClick(object sender, RoutedEventArgs e)
        {
            double numero2 = Convert.ToDouble(pantalla.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero2 + numero1;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "x":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;
               
            }

            pantalla.Text = resultado.ToString();
            numeroNuevo = true;
        }
        
        private void c_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = "0";
            operador = "";
            numero1 = 0;
            numeroNuevo = true;

        }

        private void ce_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = "0";
            numeroNuevo = true;
        }

        private void coma_Click(object sender, RoutedEventArgs e)
        {
            if (!pantalla.Text.Contains(","))
            {
                pantalla.Text += ",";
            }
        }

        private void porcentajeClick(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(pantalla.Text);
            numero = numero / 100;

            pantalla.Text = numero.ToString();
        }

    }


}