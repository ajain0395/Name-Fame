using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mini
{
    public partial class Button2 : Form
    {
        public SqlConnection sqlConnection = new SqlConnection("Data Source=python;Initial Catalog=ashish;Integrated Security=True");
        public Button2()
        {
            InitializeComponent();
        }
        private void cont(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            char g;
            string nname = name.Text;
            string select;
            if (year.Text.Length == 4 && nname.Length > 0)
            {
                int yyear = Convert.ToInt32(year.Text);
                if (yyear < 1944 || yyear > 2013)
                    MessageBox.Show("Enter Year between 1944 - 2013", "Wrong Input");
                else
                {
                    if (male.Checked == true)
                     g = 'm';
                    else
                    g = 'f';
                   
                   // select = "select amount from combine where name='" + nname + "' AND year=" + yyear + " and sex='f'";
                    ////code here
                    for (int i = yyear; i <= 2013; i++)
                    {
                        select = "select amount from combine where name='" + nname + "' AND year=" + i + " and sex='"+g+"'";
                        int q, p;
                        string l, n;
                        q = i;
                        l = i.ToString();
                        SqlCommand sqlComman = new SqlCommand();
                        sqlComman.Connection = sqlConnection;
                        sqlConnection.Open();
                        sqlComman.CommandText = select;

                        sqlComman.ExecuteNonQuery();

                        object d = sqlComman.ExecuteScalar();
                        if (d == null || d == DBNull.Value)
                        {
                            p = 0;
                        }
                        else
                        {

                            n = sqlComman.ExecuteScalar().ToString();
                            p = int.Parse(n);

                        }
                        sqlConnection.Close();
                        chart.Series["Amount"].Points.AddXY(q, p);
                        chart.Series["Amount"].ChartType = SeriesChartType.Column;

                    }

                    //
                }
            }
            else
            {               
                            MessageBox.Show("Enter Valid Name and Year", "Wrong Input");
                    
            }
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
            male.Checked = true;
            // TODO: This line of code loads data into the 'ashishDataSet.combine' table. You can move, or remove it, as needed.
            this.combineTableAdapter.Fill(this.ashishDataSet.combine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.CommandText = "select distinct Name from combine";
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            name.AutoCompleteCustomSource = MyCollection;
            reader.Close();
            sqlConnection.Close();
        }
    }
}
