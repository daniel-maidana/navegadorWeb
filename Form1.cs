using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk00wGvGfSYNp7KYDf9mFIAV90oY-YA%3A1585961134753&source=hp&ei=rtiHXqvRK-uu5OUPh62fyAQ&q=" + tBuscar.Text +"&oq=" + tBuscar.Text + "&gs_lcp=CgZwc3ktYWIQAzIFCAAQgwEyAggAMgIIADIFCAAQgwEyAggAMgIIADICCAAyAggAMgIIADIECAAQAzoHCCMQ6gIQJzoECCMQJzoECAAQQ0oWCBcSEjBnODdnMTI5ZzEwNmc4N2c4MEoPCBgSCzBnMWcxZzFnMWcxUKjeBVif5wVgrqUHaANwAHgAgAF5iAHCA5IBAzQuMZgBAKABAaoBB2d3cy13aXqwAQo&sclient=psy-ab&ved=0ahUKEwir4L_Qxc3oAhVrF7kGHYfWB0kQ4dUDCAc&uact=5");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string colorHex = "#3C552D";
            this.BackColor = ColorTranslator.FromHtml(colorHex);
        }


        private void bVioleta_Click(object sender, EventArgs e)
        {
            string colorHex = "#4C1F7A"; 
            this.BackColor = ColorTranslator.FromHtml(colorHex);
        }

        private void bNaranja_Click(object sender, EventArgs e)
        {
            string colorHex = "#FF8000";
            this.BackColor = ColorTranslator.FromHtml(colorHex);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string colorHex = "#82D4BB";
            this.BackColor = ColorTranslator.FromHtml(colorHex);
        }

        private void bIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBuscar.Text)) return;
            if (tBuscar.Equals("about:blank")) return;
            if (!tBuscar.Text.StartsWith("http://") &&
            !tBuscar.Text.StartsWith("https://"))
            {
                tBuscar.Text = "http://" + tBuscar.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(tBuscar.Text));
            }
            catch
            {
                MessageBox.Show("Se produjo un error.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
