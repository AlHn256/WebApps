using System;
using System.Windows.Forms;
using WinFormClient.ServiceReference1;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new SummatorClient("NetTcpBinding_ISummator");
            label1.Text = client.GetSumm(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
