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

namespace WindowsFormsApp1
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            var con = new SqlConnection("data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=LPRShoeStore;integrated security=True;Encrypt=False");
            con.Open();
            string StringCommand = "select * from Productsprice";
            SqlCommand com = new SqlCommand(StringCommand, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
