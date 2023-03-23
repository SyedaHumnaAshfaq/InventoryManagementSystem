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
    public partial class generate_bill : Form
    {
        public generate_bill()
        {
            InitializeComponent();
        }
        private void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con.Open();
            string query = "select Prod_ID,Prod_name,Quantity,Prod_price,Discount from Products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billdatagrid1.DataSource = ds.Tables[0];
            con.Close();


        }
        private void populatebill()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con.Open();
            string query = "select billID,employeeID,billDate from Orders";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billdatagrid3.DataSource = ds.Tables[0];
            con.Close();


        }
        
        private void generate_bill_Load(object sender, EventArgs e)
        {
            //int x = 0;
            populate();
            populatebill();
            datelbl.Text = datelbl.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con.Open();
            string query = "select top 1 billID from Orders order by billID desc  ";
            SqlCommand cmd = new SqlCommand(query, con);
            int x = (int)cmd.ExecuteScalar()+1;
            billidtb.Text = x.ToString();
            employeeIDlbl.Text = login.empID.ToString();

            

            
            


        }

        private void billdatagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.billdatagrid1.Rows[e.RowIndex];
                prodIDtb.Text = row.Cells[0].Value.ToString();
                nametb.Text = row.Cells[1].Value.ToString();
                qtytb.Text = row.Cells[2].Value.ToString();
                pricetb.Text = row.Cells[3].Value.ToString();
                discounttb.Text = row.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        decimal grdtotal = 0;
        //int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con.Open();
            string query = "select Quantity from Products where prod_ID = " + prodIDtb.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int result = (int)cmd.ExecuteScalar();


            if (int.Parse(qtytb.Text) > result)
            {
                MessageBox.Show("This quantity is not available in stock");
            }
            else if (int.Parse(qtytb.Text) == 0)
            {
                MessageBox.Show("You cannot order zero quantity of anything!");
            }
            else if (billidtb.Text == "")
            {
                MessageBox.Show("Please enter BillID");
            }
            
            else if (nametb.Text == "" || qtytb.Text == "" || pricetb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {

                decimal total = (int.Parse(pricetb.Text) * int.Parse(qtytb.Text)) - ((decimal)int.Parse(discounttb.Text) / 100) * int.Parse(pricetb.Text);
                try
                {
                    
               
                    
                  
                    string query3 = "insert into Orderline values(" + billidtb.Text + ",'" + prodIDtb.Text + "','" + qtytb.Text + "')";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully");
                    DataGridViewRow newrow = new DataGridViewRow();
                    billdatagrid2.ColumnCount = 6;
                    newrow.CreateCells(billdatagrid2);
                    newrow.Cells[0].Value = billidtb.Text;
                    newrow.Cells[1].Value = prodIDtb.Text;
                    newrow.Cells[2].Value = nametb.Text;
                    newrow.Cells[3].Value = qtytb.Text;
                    newrow.Cells[4].Value = pricetb.Text;
                    newrow.Cells[5].Value = total;
                    billdatagrid2.Rows.Add(newrow);
                    grdtotal = grdtotal + total;
                    amountlbl.Text = "" + grdtotal;
                    
                    string query1 = "update Products set Quantity = Quantity - '" + qtytb.Text + "'where prod_ID = '" + prodIDtb.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    populate();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            } 
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (billidtb.Text == "")
            {
                MessageBox.Show("Please enter BillID");
            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
                    con.Open();
                    string query = "insert into Orders values('" + employeeIDlbl.Text + "','" + datelbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully");
                    populatebill();
                    con.Close();


                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show(ex.Message);
                   
                    
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChooseOption co = new ChooseOption();
            this.Hide();
            co.Show();
        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bill is printing.....");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            generate_bill gb = new generate_bill();
            this.Hide();
            gb.Show();
        }
    }
}
