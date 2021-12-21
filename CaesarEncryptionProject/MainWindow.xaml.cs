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

namespace CaesarEncryptionProject
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

        private void ButtonStartEncrypiton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(encryptionInputTxt.Text))
                {
                    var inputString = encryptionInputTxt.Text;
                    var encryptionKeyValue = encryptionKey.SelectedItem.ToString();

                    var encryptionString = new CaesarEncryption(inputString, encryptionKeyValue);

                    encryptionResultTxt.Text = encryptionString.GetEncryptedValue();


                }
                else
                {
                    throw new Exception("Insert Key Value or String Value");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonStartDecrypiton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(decryptionInputTxt.Text))
                {
                    var inputString = decryptionInputTxt.Text;
                    var decryptionKeyValue = decyptionKey.SelectedItem.ToString();

                    var encryptionString = new CaesarEncryption(inputString, decryptionKeyValue);

                    decryptionResultTxt.Text = encryptionString.GetDecryptedValue();


                }
                else
                {
                    throw new Exception("Insert Key Value or String Value");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertValuesToComboBox(object sender, RoutedEventArgs e)
        {

            for (int i = 1; i <= 34; i++)
            {
                encryptionKey.Items.Add(i.ToString());
                decyptionKey.Items.Add(i.ToString());
            }
            
        }
    }
}
