using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginform
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static int empID;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");

                con.Open();
                string query2 = "select username,password from tempTable where username= '" + textBox1.Text + "'AND password = '" + textBox2.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    MessageBox.Show("login successful");
                    select_One so = new select_One();
                    this.Hide();
                    so.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Login");

                }
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                con1.Open();

                string query3 = "select username,password from tempTable1 where username= '" + textBox1.Text + "'AND password = '" + textBox2.Text + "'";
                SqlCommand cmd3 = new SqlCommand(query3, con1);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.HasRows)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    con.Open();
                    string q1 = ("select emp_ID from empTable where emp_name = '" + textBox1.Text + "'");
                    SqlCommand cm = new SqlCommand(q1, con);
                    empID = (int)cm.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("login successful");
                    ChooseOption CO = new ChooseOption();
                    this.Hide();
                    CO.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
                con1.Close();
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //bool check = checkBox1.Checked();
            if (checkBox1.Checked == true) { textBox2.UseSystemPasswordChar = false; }
            else { textBox2.UseSystemPasswordChar = true; }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                con.Open();
                //SqlCommand cmd = new SqlCommand("select username,password from tblogin where employeepost ='A'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                da.SelectCommand = new SqlCommand("select username,password from tblogin where employeepost ='A'", con);
                da.Fill(ds, "tblogin");
                dt = ds.Tables["tblogin"];



             
                foreach (DataRow dr in dt.Rows)
                {
                   
                    int rowNum=0;
                    string columnName1 = "username";
                    string columnName2 = "password";
                    string s = dt.Rows[rowNum][columnName1].ToString();
                    string r = dt.Rows[rowNum][columnName2].ToString();

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into tempTable(username,password) values ('"+s+"','"+r+"')", conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();

                    rowNum++;

                }
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                da.SelectCommand = new SqlCommand("select username,password from tblogin where employeepost ='E'", con);
                da.Fill(ds, "tblogin");
                dt = ds.Tables["tblogin"];



                int rowNum = 0;
                foreach (DataRow dr in dt.Rows)
                {

                    
                    string columnName1 = "username";
                    string columnName2 = "password";
                    string s = dt.Rows[rowNum][columnName1].ToString();
                    string r = dt.Rows[rowNum][columnName2].ToString();

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into tempTable1(username,password) values ('" + s + "','" + r + "')", conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();

                    rowNum++;

                }
                


                con.Close();
               

            }
        }
    }
}
