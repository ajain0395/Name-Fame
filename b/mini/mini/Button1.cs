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
    public partial class Button1 : Form
    {
        public Button1()
        {
            InitializeComponent();
        }

        private void Button1_Load(object sender, EventArgs e)
        {

        }
        private void home(object sender, EventArgs e)
        {
Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void cont(object sender, EventArgs e)
        {
            char g;
            int yyear = Convert.ToInt32(year.Text);
            int ttop = Convert.ToInt32(top.Text);
            if (male.Checked == true)
               g = 'm';
            else if (female.Checked == true)
               g = 'f';
            else
                g = 'b';
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void top_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
