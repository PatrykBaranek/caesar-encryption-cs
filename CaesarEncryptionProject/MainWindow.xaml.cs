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
            if (!string.IsNullOrEmpty(encryptionInputTxt.Text))
            {
                encryptionResultTxt.Text = encryptionKey.SelectedItem.ToString();

            }
        }

        private void ButtonStartDecrypiton_Click(object sender, RoutedEventArgs e)
        {

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
