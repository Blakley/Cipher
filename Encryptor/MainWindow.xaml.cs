using System.Windows;
using System.Windows.Documents;

namespace Encryptor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AtbashClick(object sender, RoutedEventArgs e)
        {
            Atbash cipher = new Atbash();
            string result = cipher.EncryptAtbash(input_box.Text);

            output_box.Text = "";
            output_box.AppendText("Atbash: \n");
            output_box.AppendText(result);
        }

        private void BaconianClick(object sender, RoutedEventArgs e)
        {
            Baconian cipher = new Baconian();
            string result = cipher.EncryptBaconian(input_box.Text);

            output_box.Text = "";
            output_box.AppendText("Baconian: \n");
            output_box.AppendText(result);
        }

        private void Rot13Click(object sender, RoutedEventArgs e)
        {
            Rot13 cipher = new Rot13();
            string result = cipher.EncryptRot13(input_box.Text);

            output_box.Text = "";
            output_box.AppendText("Rot13: \n");
            output_box.AppendText(result);
        }

        private void Base64Click(object sender, RoutedEventArgs e)
        {
            Base64 cipher = new Base64();
            string result = cipher.EncryptBase64(input_box.Text);

            output_box.Text = "";
            output_box.AppendText("Base64: \n");
            output_box.AppendText(result);
        }

        private void LatinClick(object sender, RoutedEventArgs e)
        {
            Latin cipher = new Latin();
            string result = cipher.EncryptLain(input_box.Text);

            output_box.Text = "";
            output_box.AppendText("Latin: \n");
            output_box.AppendText(result);
        }

        private void PolybiusClick(object sender, RoutedEventArgs e)
        {
            Polybius cipher = new Polybius();
            string result = cipher.EncryptPolybuis(input_box.Text);

            output_box.Text = "";
            output_box.AppendText("Polybius: \n");
            output_box.AppendText(result);
        }

    }
}
