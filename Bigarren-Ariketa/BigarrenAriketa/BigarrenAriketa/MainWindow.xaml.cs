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

namespace BigarrenAriketa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private String[] esaldiak = new string[5];
        private int posizioa = 0;

        private Button[] botoiak;


        public MainWindow()
        {
            InitializeComponent();


            botoiak = new Button[]
            {
                Esaldia1Botoia,
                Esaldia2Botoia,
                Esaldia3Botoia,
                Esaldia4Botoia,
                Esaldia5Botoia
             
            };
            for (int i = 0; i < botoiak.Length; i++)
            {
                botoiak[i].IsEnabled = false;
            }

            botoiak[0].IsEnabled = true;
        }

        private void botoia_sakatu(object sender, RoutedEventArgs e)
        {
            Button botoia = (Button)sender;

            if(botoia == BatuBotoia)
            {
                testua_textbox.Text += String.Join(" ", esaldiak);
                return;
            }

            if(botoia == GarbituBotoia)
            {
                garbitu();
                return;
            }

            if(botoia == IrtenBotoia)
            {
                Close();
                return;
            }

            esaldiak[posizioa] = testua_textbox.Text;

            botoia.IsEnabled = false;
            posizioa++;

            if(posizioa < esaldiak.Length)
            {
                botoiak[posizioa].IsEnabled = true;
            }

            testua_textbox.Clear();
        }

        private void garbitu()
        {
            testua_textbox.Text = "";
            for(int i = 0; i < esaldiak.Length; i++)
            {
                esaldiak[i] = "";

            }
        }


    }
}