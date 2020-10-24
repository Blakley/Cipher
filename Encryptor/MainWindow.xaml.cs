using System;
using System.Windows;

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
            string result = cipher.EncryptAtbash(password_input.Text);
            debugger.AppendText("Atbash: " + result + '\n');
        }


        private void BaconianClick(object sender, RoutedEventArgs e)
        {
            Baconian cipher = new Baconian();
            string result = cipher.EncryptBaconian(password_input.Text);
            debugger.AppendText("Baconian: " + result + '\n');
        }

        private void Rot13Click(object sender, RoutedEventArgs e)
        {
            Rot13 cipher = new Rot13();
            string result = cipher.EncryptRot13(password_input.Text);
            debugger.AppendText("Rot13: " + result + '\n');
        }

        private void CaesarClick(object sender, RoutedEventArgs e)
        {
            Caesar cipher = new Caesar();
            string result = cipher.EncryptCaesar(password_input.Text, Int32.Parse(caesarShift.Text));
            debugger.AppendText("Caesar: " + result + '\n');
        }

        private void Base64Click(object sender, RoutedEventArgs e)
        {
            Base64 cipher = new Base64();
            string result = cipher.EncryptBase64(password_input.Text);
            debugger.AppendText("Base64: " + result + '\n');
        }

        private void test_latin_Click(object sender, RoutedEventArgs e)
        {
            Latin cipher = new Latin();
            string result = cipher.EncryptLain(password_input.Text);
            debugger.AppendText("Latin: " + result + '\n');
        }

        private void test_null_Click(object sender, RoutedEventArgs e)
        {
            Null cipher = new Null();
            string result = cipher.EncryptNull(password_input.Text);
            debugger.AppendText("Null: " + result + '\n');
        }

        private void test_xor_Click(object sender, RoutedEventArgs e)
        {
            Xor cipher = new Xor();
            string result = cipher.EncryptXor(password_input.Text, xorKey.Text); // single character key Letter
            debugger.AppendText("Xor: " + result + '\n');
        }

        private void test_polybius_Click(object sender, RoutedEventArgs e)
        {
            Polybius cipher = new Polybius();
            string result = cipher.EncryptPolybuis(password_input.Text);
            debugger.AppendText("Polybius: " + result + '\n');
        }
    }
}
