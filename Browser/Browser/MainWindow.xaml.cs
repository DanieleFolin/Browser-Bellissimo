using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Browser
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

        private void srcButton_onClick(object sender, RoutedEventArgs e)
        {

            myWebview.Navigate(URLBox.Text.ToString());
            
        }

        private void URLBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                myWebview.Navigate(URLBox.Text.ToString());
            }
        }

        /*
         * ROBA DA VEDERE PROSSIMAMENTE
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var result = await client.GetAsync("http://webcode.me");
            Console.WriteLine(result.StatusCode);

            //PRENDO IL CODICE HTML DELLA PAGINA
            var content = await client.GetStringAsync("http://webcode.me");
            Console.WriteLine(content);
        }
        */

    }
}
