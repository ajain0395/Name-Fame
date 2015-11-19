using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini
{
    public partial class Bt1 : Form
    {
        public Bt1()
        {
            InitializeComponent();
        }

        private void Bt1_Load(object sender, EventArgs e)
        {

        }
        public SqlConnection sqlConnection = new SqlConnection("Data Source=python;Initial Catalog=ashish;Integrated Security=True");
        private void Continue_Click(object sender, EventArgs e)
        {
            
            if (year.Text.Length == 4 && top.Text.Length > 0)
            {
                int yyear = Convert.ToInt32(year.Text);
                int ttop =Convert.ToInt32( top.Text);
                if (yyear < 1944 || yyear > 2013)
                    MessageBox.Show("Enter Year between 1944 - 2013", "Wrong Input");
                else if(ttop<1)
                    MessageBox.Show("Enter Top > 0", "Wrong Input");
                else
                {
                   string select = "";

                    if (male.Checked == true)
                        select = "select name,amount,position,sex from combine where [position] <=" + ttop + " and year = " + yyear + " and sex = 'm' order by (cast (position as int)) ";
                    else if (both.Checked == true)
                        select = "select name,amount,position,sex from combine where [position] <=" + ttop + " and year = " + yyear + " order by (cast (position as int)) ";
                    else if (female.Checked == true)
                        select = "select name,amount,position,sex from combine where [position] <=" + ttop + " and year = " + yyear + " and sex = 'f' order by (cast (position as int)) ";

                    //select = "select * from combine where position <=" + Convert.ToString(ttop) + " and year = " + yyear + "order by amount desc";
                    //code here
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.CommandText = select;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Top and Year", "Wrong Input");

            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
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
