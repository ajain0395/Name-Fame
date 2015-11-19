using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Bt1 Check = new Bt1();
        Check.Show();
         Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button2 Check = new Button2();
            Check.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            about Check = new about();
            Check.Show();
            Hide();
        }
    }
}
