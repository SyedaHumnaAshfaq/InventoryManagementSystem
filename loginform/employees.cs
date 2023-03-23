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

namespace loginform
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                Con.Open();
                SqlCommand cmd = new SqlCommand("AddEmp", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMP_ID", SqlDbType.Int).Value = EMP_IDTB.Text;
                cmd.Parameters.AddWithValue("@EMP_NAME", SqlDbType.VarChar).Value = EMPNAMETB.Text;
                cmd.Parameters.AddWithValue("@EMP_AGE", SqlDbType.NChar).Value = EMPAGE.Text;
                cmd.Parameters.AddWithValue("@EMP_PHONE", SqlDbType.VarChar).Value = EMPPHONE.Text;
                cmd.Parameters.AddWithValue("@EMP_SALARY", SqlDbType.Int).Value = EMPSALARY.Text;
                cmd.Parameters.AddWithValue("@EMP_POST", SqlDbType.VarChar).Value = EMPPOST.Text;
                cmd.Parameters.AddWithValue("@HIRE_DATE", SqlDbType.Date).Value = EMPHIREDATE.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("added successfully");
                Con.Close();
                populate();
                EMP_IDTB.Text = "";
                EMPNAMETB.Text = "";
                EMPAGE.Text = "";
                EMPPHONE.Text = "";
                EMPSALARY.Text = "";
                EMPPOST.Text = "";
                EMPHIREDATE.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                Con.Open();
                string query = "insert into empTABLE values (" + EMP_IDTB.Text + ",'" + EMPNAMETB.Text + "','" + EMPAGE.Text + "','" + EMPPHONE.Text + "','" + EMPSALARY.Text + "','" + EMPPOST.Text + "','" + EMPHIREDATE.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("added successfully");
                Con.Close();
                populate();
                EMP_IDTB.Text = "";
                EMPNAMETB.Text = "";
                EMPAGE.Text = "";
                EMPPHONE.Text = "";
                EMPSALARY.Text = "";
                EMPPOST.Text = "";
                EMPHIREDATE.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        private void populate()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            Con.Open();
            string query = "Select * from empTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EMPDGV.DataSource = ds.Tables[0];

            Con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void EMPDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.EMPDGV.Rows[e.RowIndex];
                EMP_IDTB.Text = row.Cells[0].Value.ToString();
                EMPNAMETB.Text = row.Cells[1].Value.ToString();
                EMPAGE.Text = row.Cells[2].Value.ToString();
                EMPPHONE.Text = row.Cells[3].Value.ToString();
                EMPSALARY.Text = row.Cells[4].Value.ToString();
                EMPPOST.Text = row.Cells[5].Value.ToString();
                EMPHIREDATE.Text = row.Cells[6].Value.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (EMP_IDTB.Text == "")
                {
                    MessageBox.Show("select the id to delete");
                }
                else
                {
                    SqlConnection Con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    Con.Open();
                    string query = "delete from empTable where EMP_ID=" + EMP_IDTB.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted successfully");
                    Con.Close();
                    populate();
                    EMP_IDTB.Text = "";
                    EMPNAMETB.Text = "";
                    EMPAGE.Text = "";
                    EMPPHONE.Text = "";
                    EMPSALARY.Text = "";
                    EMPPOST.Text = "";
                    EMPHIREDATE.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (EMPNAMETB.Text == "" || EMP_IDTB.Text == "" || EMPAGE.Text == "" || EMPPOST.Text == "" || EMPPHONE.Text == "" || EMPSALARY.Text == "" || EMPHIREDATE.Text == "")
                {
                    MessageBox.Show("missing information");

                }
                else
                {
                    SqlConnection Con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    Con.Open();
                    string query = "update empTable set EMP_NAME='" + EMPNAMETB.Text + "',EMP_AGE='" + EMPAGE.Text + "',EMP_PHONE='" + EMPPHONE.Text + "',EMP_SALARY='" + EMPSALARY.Text + "',EMP_POST='" + EMPPOST.Text + "',HIRE_DATE='" + EMPHIREDATE.Text + "'where EMP_ID=" + EMP_IDTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("employee updated successfully");
                    Con.Close();
                    populate();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EMP_IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_One so = new select_One();
            this.Hide();
            so.Show();
        }
    }
}
