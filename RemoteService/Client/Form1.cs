using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteService;

namespace Client
{
    public partial class Form1 : Form
    {

        ISummatorRemoteService Instance;
        public Form1()
        {
            InitializeComponent();
            var channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel,false);
            Instance = (ISummatorRemoteService)Activator.GetObject(typeof(ISummatorRemoteService), "tcp://localhost:55211/Summator");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Instance.GetSum(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
