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


namespace Queen
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-HO3LU9Q\\M;database=BikeStores ;integrated security =true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listOrder();
        }

        private void text_order_id_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int  customer_id = int.Parse(text_customer_id.Text);
            int order_status = int.Parse(text_order_status.Text);
            DateTime Order_date = DateTime.Parse(order_date.Text);
            DateTime Required_date = DateTime.Parse(required_date.Text);
            DateTime Shipped_date = DateTime.Parse(shipped_date.Text);
            int store_id = int.Parse(text_store_id.Text);
            int staff_id = int.Parse(text_staff_id.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec Insert_oreder '" + customer_id + "'," +
                                                                   "'" + order_status + "'," +
                                                                   "'" + Order_date + "'," +
                                                                   "'" + Required_date + "'," +
                                                                   "'" + Shipped_date + "'," +
                                                                   "'" + store_id + "'," +
                                                                   "'" + staff_id + "'",con);
            MessageBox.Show("successfully");
            cmd.ExecuteNonQuery();
            con.Close();

        }

        void clear()
        {
            text_customer_id.Clear();
            text_order_status.Clear();
            text_store_id.Clear();
            text_staff_id.Clear();
            text_order_id.Text = "";
            order_date.Text = DateTime.Now.ToString();
            required_date.Text = DateTime.Now.ToString();
            shipped_date.Text = DateTime.Now.ToString();


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void listOrder()
        {
            SqlCommand cmd = new SqlCommand("exec List_oreder", con);
            SqlDataAdapter sqldata = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqldata.Fill(dt);
            dgv.DataSource = dt;

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            int order_id = int.Parse(text_order_id.Text);
            int customer_id = int.Parse(text_customer_id.Text);
            int order_status = int.Parse(text_order_status.Text);
            DateTime Order_date = DateTime.Parse(order_date.Text);
            DateTime Required_date = DateTime.Parse(required_date.Text);
            DateTime Shipped_date = DateTime.Parse(shipped_date.Text);
            int store_id = int.Parse(text_store_id.Text);
            int staff_id = int.Parse(text_staff_id.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec Update_order '" + order_id + "','"
                                                                    + customer_id + "','"
                                                                    + order_status + "','"
                                                                    + Order_date + "','"
                                                                    + Required_date + "','"
                                                                    + Shipped_date + "','"
                                                                    + store_id + "','"
                                                                    + staff_id + "'", con);
            MessageBox.Show("Update successfully");
            cmd.ExecuteNonQuery();
            con.Close();
            listOrder();
        }
        
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            text_order_id.Text = dgv.CurrentRow.Cells[0].Value.ToString();

            text_customer_id.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            text_order_status.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            order_date.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            required_date.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            shipped_date.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            text_store_id.Text = dgv.CurrentRow.Cells[6].Value.ToString();
            text_staff_id.Text = dgv.CurrentRow.Cells[7].Value.ToString();


        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_SelectionChanged(null, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text_order_id.Text);


            SqlCommand cmd = new SqlCommand("exec Delete_order '"+id+"'", con);
           
            

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted..");
            con.Close();
            listOrder();
        }
    }
}
