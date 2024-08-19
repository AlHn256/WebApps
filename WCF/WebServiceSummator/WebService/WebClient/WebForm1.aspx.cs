using System;
using System.Web.UI;
using WebClient.SummatorService;

namespace WebClient
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var client = new SummatorSoapClient();
            Label1.Text = client.GetSumm(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text)).ToString();
        }
    }
}