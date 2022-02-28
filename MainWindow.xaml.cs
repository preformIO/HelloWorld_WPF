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

// file open includes
using System.IO;
using Microsoft.Win32;

namespace HelloWorld_WPF
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

        private void ButtonAddWord_Click(object sender, RoutedEventArgs e)
        {
            // If string in txtWord exists, and is not already in lstWords, add it and clear the text box
            if (!string.IsNullOrWhiteSpace(txtWord.Text) && !lstWords.Items.Contains(txtWord.Text))
            {
                lstWords.Items.Add(txtWord.Text);
                txtWord.Clear();
            }
            // TODO: communicate more clearly with the user when
            // input does not match expectations
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
