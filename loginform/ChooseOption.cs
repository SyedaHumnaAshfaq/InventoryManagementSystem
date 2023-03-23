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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginform
{
    public partial class ChooseOption : Form
    {
        public ChooseOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enter_stock es = new enter_stock();
            this.Hide();
            es.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generate_bill gb = new generate_bill();
            this.Hide();
            gb.Show();

        }




        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con1.Open();
            //string query3 = "CREATE VIEW employee AS SELECT emp_name, emp_id,emp_post,hire_date FROM empTable WHERE emp_post='Employee'";
            //SqlCommand cmd3 = new SqlCommand(query3, con1);
            //cmd3.ExecuteNonQuery();


            string q = "select * from employee";
            //SqlCommand cmd4 = new SqlCommand(q, con1);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand(q, con1);
            da.Fill(ds, "empTable");
            dt = ds.Tables["empTable"];


            int rowNum = 0;

            foreach (DataRow dr in dt.Rows)
            {
                string columnName1 = "emp_name";
                string columnName2 = "emp_ID";
                string columnName3 = "emp_post";
                string columnName4 = "hire_date";
                MessageBox.Show(dt.Rows[rowNum][columnName1].ToString() + " " + dt.Rows[rowNum][columnName2].ToString() + " " + dt.Rows[rowNum][columnName3].ToString() + " " + dt.Rows[rowNum][columnName4].ToString());
                rowNum++;
              

                
            }
            con1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con1.Open();
            //string query3 = "CREATE VIEW employee AS SELECT emp_name, emp_id,emp_post,hire_date FROM empTable WHERE emp_post='Employee'";
            //SqlCommand cmd3 = new SqlCommand(query3, con1);
            //cmd3.ExecuteNonQuery();


            string q = "select * from employeeADMIN";
            //SqlCommand cmd4 = new SqlCommand(q, con1);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand(q, con1);
            da.Fill(ds, "empTable");
            dt = ds.Tables["empTable"];


            int rowNum = 0;

            foreach (DataRow dr in dt.Rows)
            {
                string columnName1 = "emp_name";
                string columnName2 = "emp_ID";
                string columnName3 = "emp_post";
                string columnName4 = "hire_date";
                MessageBox.Show(dt.Rows[rowNum][columnName1].ToString() + " " + dt.Rows[rowNum][columnName2].ToString() + " " + dt.Rows[rowNum][columnName3].ToString() + " " + dt.Rows[rowNum][columnName4].ToString());
                rowNum++;



            }
            con1.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }

        private void ChooseOption_Load(object sender, EventArgs e)
        {

        }
    } }
