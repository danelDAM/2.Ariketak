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

namespace Bostgarren_Ariketa
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

        private void comicSans(object sender, RoutedEventArgs e)
        {
            texto.FontFamily = new FontFamily("Comic Sans MS");
        }
        private void lodia(object sender, RoutedEventArgs e)
        {
            if (texto.FontWeight == FontWeights.Bold)
            {
                texto.FontWeight = FontWeights.Normal;
            }
            else
            {
                texto.FontWeight = FontWeights.Bold;
            }
        }
        private void marratua(object sender, RoutedEventArgs e)
        {
            if (texto.TextDecorations == TextDecorations.Strikethrough)
            {
                texto.TextDecorations = null;
            }
            else
            {
                texto.TextDecorations = TextDecorations.Strikethrough;
            }
        }
        private void tamainaHanditu(object sender, RoutedEventArgs e)
        {
            texto.FontSize += 2;
        }
        private void tamainaTxikitu(object sender, RoutedEventArgs e)
        {
            texto.FontSize -= 2;
        }
        private void azpimarratua(object sender, RoutedEventArgs e)
        {
            if (texto.TextDecorations == TextDecorations.Underline)
            {
                texto.TextDecorations = null;
            }
            else
            {
                texto.TextDecorations = TextDecorations.Underline;
            }
        }
        private void etzana(object sender, RoutedEventArgs e)
        {
            if (texto.FontStyle == FontStyles.Italic)
            {
                texto.FontStyle = FontStyles.Normal;
            }
            else
            {
                texto.FontStyle = FontStyles.Italic;
            }
        }
        private void courier(object sender, RoutedEventArgs e)
        {
            texto.FontFamily = new FontFamily("Courier New");
        }

        private void hautatu(object sender, RoutedEventArgs e)
        {
            texto.SelectAll();
            texto.Focus();

            int karaktereKopurua = texto.Text.Length;
            kontadorea.Text = "Testuak duen karaktere kopurua: " + karaktereKopurua.ToString();
        }

        private void irten(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
    
    
}