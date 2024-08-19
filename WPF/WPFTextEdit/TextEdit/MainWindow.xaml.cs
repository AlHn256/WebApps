using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TextEdit.Model;

namespace TextEdit
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in FirstGrid.Children)
            {
                if(el is TextBox)
                {
                    ((TextBox)el).TextChanged += TextBoxChanged;
                }
            }

            foreach (UIElement el in SecondGrid.Children)
            {
                if (el is TextBox)
                {
                    ((TextBox)el).TextChanged += MailTextBoxChanged;
                }
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        } 

        private void TextBoxChanged(object sender, TextChangedEventArgs e)
        {
            int Number = 0;
            int.TryParse(TextToEditTextBox.Text, out Number);
            if (Number > 10)
            {
                Number = 10;
                TextToEditTextBox.Text = "10";
            }

            ResultTextBlock.Text = Number.GetFibonacciArray();
            SummTextBlock.Text = ResultTextBlock.Text.GetFibonacciArraySumm();
        }

        private void MailTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            ResultMailBlock.Text = txtEditor.Text.GetMailList();

            ResultWordsBlock.Text = txtEditor.Text.GetWordList(5, AdditionalFilter.Text);

            //if (string.IsNullOrEmpty(AdditionalFilter.Text))
            //{
            //    ResultWordsBlock.Text = txtEditor.Text.GetWordList(5);
            //}
            //else
            //{
            //    ResultWordsBlock.Text = txtEditor.Text.GetWordList(5, AdditionalFilter.Text);
            //}
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }
        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, ResultMailBlock.Text);
        }
    }
}
