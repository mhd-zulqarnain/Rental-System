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
    public partial class manager_agent_details : Form
    {
        string username;
        sign_in a = new sign_in();
        public manager_agent_details()
        {
            InitializeComponent();
        }

        public manager_agent_details( string u)
        {
            InitializeComponent();
            this.username = u;
        }
        private void manager_agent_details_Load(object sender, EventArgs e)
        {
            a.conn.Open(); 
            begin();
            luname.Text = username;
        }
        void begin() {
            
            OleDbCommand cm = new OleDbCommand("Select * from agent_details ", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
            OleDbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                
                    ListViewItem li = new ListViewItem(reader[1].ToString());
                    li.SubItems.Add(reader[2].ToString());
                    li.SubItems.Add(reader[3].ToString());
                    li.SubItems.Add(reader[5].ToString());
                    li.SubItems.Add(reader[6].ToString());
                    listView1.Items.Add(li);

                    comboagentname.Items.Add(reader[1].ToString());

            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = true;
            listView2.Items.Clear();
            if (comboagentname.Text != "")
            {
                
                OleDbCommand cm = new OleDbCommand("SELECT house_details.house_number, house_details.house_address, house_details.house_price, clint_details.clint_name, booking_details.booking_date, agent_details.agent_name FROM (agent_details INNER JOIN house_details ON agent_details.agent_id = house_details.agent_id) INNER JOIN (clint_details INNER JOIN booking_details ON clint_details.CID = booking_details.CID) ON house_details.house_number = booking_details.house_number; ", a.conn);
                //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
                OleDbDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[5].ToString() == comboagentname.Text)
                    {
                        ListViewItem li = new ListViewItem(reader[0].ToString());
                        li.SubItems.Add(reader[1].ToString());
                        li.SubItems.Add(reader[3].ToString());
                        li.SubItems.Add(reader[4].ToString());
                        listView2.Items.Add(li);
                        l1.Text ="Details of Agent "+comboagentname.Text;
                    }
                    
                }
                if (listView2.Items.Count == 0)
                    MessageBox.Show("NO BOOKINGS TO SHOW");
                l1.Text = "No details for " + comboagentname.Text;
            }
            
            else 
            {
                MessageBox.Show("Select Agent name");
            }


        }
    }
}
