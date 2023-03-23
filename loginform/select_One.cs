using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class select_One : Form
    {
        public select_One()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            this.Hide();
            emp.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails();
            this.Hide();
            ed.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }
    }
}
