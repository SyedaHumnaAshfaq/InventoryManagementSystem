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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T2FUVHM\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            con.Open();
            string a = dateTimePicker1.Value.ToString();

            //char[] arr = { ' 12:00 AM' };
            List<String> parts=a.Split(' ').Select(p=>p.Trim()).ToList();
            //char[] arr = {' ','1','2',':','0','0','A','M'};
            //MessageBox.Show(parts[0]);


            //a = a.Substring(0, 10);


            string query = $"select employeeID,count(billID) as countOrders from orders where billDate = '{parts[0]}'group by employeeID";
          
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
       
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_One so = new select_One();
            this.Hide();
            so.Show();
        }
    }
}
