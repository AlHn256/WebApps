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


namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
            Edit e = new Edit(this);
            e.Show();
        }

        private string GetText(RichTextBox artb)
        {
            TextRange textRange = new TextRange(
                artb.Document.ContentStart,
                artb.Document.ContentEnd);
            return textRange.Text;
        }

        private void richTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        public void RTBedit(string Text)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();


            paragraph.Inlines.Add(new Bold(new Run(Text+"\n\n")));

            paragraph.Inlines.Add(new Bold(new Run("Textasdgasdg\\SDGF\\ASDG\\SDG2 \n")));

            paragraph.Inlines.Add(new Bold(new Run("Textasdgasdg\\SDGF\\ASDG\\SDG2 \n")));
            document.Blocks.Add(paragraph);

            richTextBox.Document = document;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();

            
            paragraph.Inlines.Add(new Bold(new Run("Textasdgasdg\\SDGF\\ASDG\\SDG \n")));

            paragraph.Inlines.Add(new Bold(new Run("Textasdgasdg\\SDGF\\ASDG\\SDG2 \n")));

            paragraph.Inlines.Add(new Bold(new Run("Textasdgasdg\\SDGF\\ASDG\\SDG2 \n")));
            document.Blocks.Add(paragraph);
            
            richTextBox.Document = document;
        }
    }
}
