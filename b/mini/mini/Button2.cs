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
    public partial class Button2 : Form
    {
        public Button2()
        {
            InitializeComponent();
        }
        private void cont(object sender, EventArgs e)
        {
            char g;
            string nname = name.Text;
            int yyear = Convert.ToInt32(year.Text);
            if (male.Checked == true)
                g = 'm';
            else
                g = 'f';
        }

        private void home(object sender, EventArgs e)
        {

            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Button2_Load(object sender, EventArgs e)
        {

        }
    }
}
