using System;
using System.Windows;
using System.Windows.Input;

namespace Browser
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            backButton.IsEnabled = false;
        }

        private void srcButton_onClick(object sender, RoutedEventArgs e)
        {
            try
            {
                myWebview.Navigate(URLBox.Text.ToString());
            } catch(Exception ex)
            {
                MessageBox.Show("Insert a valid URL: " + ex.Message);
            }
        }

        private void URLBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                try
                {
                    myWebview.Navigate(URLBox.Text.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert a valid URL: " + ex.Message);
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {

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
