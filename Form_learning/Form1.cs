using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        bool click_odd1 = true;
        bool click_odd2 = true;
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Transparent;
            button1.Text = "Connect";
            button2.BackColor = Color.Transparent;
            button2.Text = "Listening";
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            
            comboBox.Items.Add("TcpServer");
            comboBox.Items.Add("TcpClient");
            comboBox.Items.Add("UDP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click_odd1 == true)
            {
                click_odd1 = !click_odd1;
                button1.BackColor = Color.Red;
                button1.Text = "DisConnect";
            }
            else
            {
                click_odd1 = !click_odd1;
                button1.BackColor = Color.Transparent;
                button1.Text = "Connect";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Run" + this.comboBox.SelectedItem.ToString();

            if (click_odd2 == true)
            {
                click_odd2 = !click_odd2;
                button2.BackColor = Color.Red;
                button2.Text = "DisConnect";
            }
            else
            {
                click_odd2 = !click_odd2;
                button2.BackColor = Color.Transparent;
                button2.Text = "Listening";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = this.comboBox.SelectedItem.ToString();
       }
    }
}
