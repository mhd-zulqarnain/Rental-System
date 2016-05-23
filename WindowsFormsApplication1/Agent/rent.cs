using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Agent
{
    public partial class rent : Form
    {
        sign_in a = new sign_in();
        public rent()
        {
            InitializeComponent();
        }
        public void populate(ListView listV, OleDbCommand cmd)
        {
            
            try
            {
                listV.Items.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem li = new ListViewItem(reader[0].ToString());
                    li.SubItems.Add(reader[1].ToString());
                    listV.Items.Add(li);


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

              
            }
        }
        private void rent_Load(object sender, EventArgs e)
        {
            a.conn.Open();
            OleDbCommand cm = new OleDbCommand("SELECT house_details.house_number, house_details.house_address, house_details.house_price FROM house_details LEFT JOIN booking_details ON house_details.house_number=booking_details.house_number WHERE (((booking_details.house_number) Is Null));", a.conn);
            populate(listView1, cm); 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
