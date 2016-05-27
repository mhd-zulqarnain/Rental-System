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

namespace WindowsFormsApplication1.Manager
{
    public partial class manger_clint_details : Form
    {
        string username;
        sign_in a = new sign_in();
        public manger_clint_details()
        {
            InitializeComponent();
        }
        public manger_clint_details( string u)
        {
            InitializeComponent();
            this.username = u;
        }

        private void manger_clint_details_Load(object sender, EventArgs e)
        {
            
            a.conn.Open();
            begin();
            luname.Text = username;
        }
        public void begin()
        {

            OleDbCommand cm = new OleDbCommand("SELECT clint_name FROM clint_details ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                comboclint.Items.Add(red[0].ToString());

            }

        }

        private void btnchkDetail_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbCommand cm = new OleDbCommand(" SELECT clint_details.clint_name, clint_details.clint_nic, booking_details.house_number, house_details.house_address, house_details.house_price, booking_details.booking_date FROM house_details INNER JOIN (clint_details INNER JOIN booking_details ON clint_details.CID = booking_details.CID) ON house_details.house_number = booking_details.house_number; ", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
            OleDbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == comboclint.Text)
                {
                    ListViewItem li = new ListViewItem(reader[2].ToString());
                    li.SubItems.Add(reader[3].ToString());
                    li.SubItems.Add("$" + reader[4].ToString());
                    li.SubItems.Add(reader[5].ToString());
                    listView1.Items.Add(li);

                }

            } if (listView1.Items.Count == 0)
                MessageBox.Show("NO HOUSE BOOKINGS");
        }
    }
}
