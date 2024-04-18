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
    public partial class AddToForm : Form
    {
        public AddToForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection("data source=PC22\\SQLEXPRESS;initial catalog=LoginPage;integrated security=True;Encrypt=False");
            con.Open();
            SqlCommand AddInto = new SqlCommand("AddNew", con);
            AddInto.CommandType = CommandType.StoredProcedure;
            AddInto.Parameters.AddWithValue("@UPC", SqlDbType.Char).Value = UPCIn.Text;
            AddInto.Parameters.AddWithValue("@Description", SqlDbType.Char).Value = UPCIn.Text;
            AddInto.Parameters.AddWithValue("@Quantity", SqlDbType.Char).Value = UPCIn.Text;
            AddInto.Parameters.AddWithValue("@Listprice", SqlDbType.Char).Value = UPCIn.Text;

            /*create procedure dbo.AddNew
	            @UPC char(20),
	            @Description char(50),
	            @Quantity int,
	            @Listprice smallmoney
            as 
                declare @Retailprice smallmoney
                if(Quantity < 50,  )
	            insert into ProductsPrice (UPCNum, ItemDescription, Quantity, listPrice, RetailPrice)
	            values(@UPC, @Description, @Quantity, @Listprice, @Retailprice)
	        return 
            
             create table Productsprice 
            (
                UOCNum char(10) primary key not null, 
                ItemDescription char(30)
                Quantity int, 
                listPrice smallmoney,
                Retailprice smallmoney
            )
             
             
             
             
             */

        }
    }
}
