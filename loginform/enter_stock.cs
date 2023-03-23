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
    public partial class enter_stock : Form
    {
        public enter_stock()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                con.Open();
                string query = "insert into Products values("+IDtb.Text+",'"+nametb.Text+"','"+unittb.Text+ "','"+pricetb.Text+ "','"+qtytb.Text+ "','"+discounttb.Text+"')";
                SqlCommand cmd =new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                populate();
                con.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con.Open();
            string query = "select * from Products";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            productdatagrid.DataSource = ds.Tables[0];
            con.Close();


        }
        private void enter_stock_Load(object sender, EventArgs e)
        {
            populate();
            datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.productdatagrid.Rows[e.RowIndex];
                IDtb.Text = row.Cells[0].Value.ToString();
                nametb.Text = row.Cells[1].Value.ToString();
                unittb.Text = row.Cells[2].Value.ToString();
                pricetb.Text = row.Cells[3].Value.ToString();
                qtytb.Text = row.Cells[4].Value.ToString();
                discounttb.Text = row.Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDtb.Text == "")
                {
                    MessageBox.Show("Please enter product id to be deleted");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    con.Open();
                    string query = "delete from Products where Prod_ID = " + IDtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Deleted successfully");
                    con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDtb.Text == "")
                {
                    MessageBox.Show("Please enter product id to be updated");
                }
                else
                {
                    if (IDtb.Text == "" || nametb.Text == "" || pricetb.Text == "" || unittb.Text == "" || qtytb.Text == "")
                    { MessageBox.Show("Missing information"); }
                    else
                    {
                        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                        con.Open();
                        string query = "update Products set Prod_ID ='" + IDtb.Text + "',Prod_name ='" + nametb.Text + "',Prod_unit ='" + unittb.Text + "',Prod_price = '" + pricetb.Text + "',Quantity = '" + qtytb.Text + "',Discount ='" + discounttb.Text + "'where Prod_ID=" + IDtb.Text + "";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("updated successfully");
                        con.Close();
                        populate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChooseOption co = new ChooseOption();
            this.Hide();
            co.Show();
        }
    }
}
