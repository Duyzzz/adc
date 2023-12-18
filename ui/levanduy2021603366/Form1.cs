using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace levanduy2021603366
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.Open();
            textBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            serialPort.Write("o");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            serialPort.Write("n");
        }
        int data = 0;
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int result = 0;
            string receive = serialPort.ReadLine();
            if (int.TryParse(receive, out result))
            {
                data = result;
            }
            Invoke(new MethodInvoker(() => ok()));
        }
        void ok()
        {
            textBox1.Text = (data * 0.4).ToString();
        }
    }
}
