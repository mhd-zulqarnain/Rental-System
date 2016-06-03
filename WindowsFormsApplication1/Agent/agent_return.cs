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
    public partial class agent_return : Form
    {
        sign_in a = new sign_in();
        agent_home h = new agent_home();
        string username;
        public agent_return()
        {
            InitializeComponent();
        }
        public agent_return(string u)
        {
            InitializeComponent();
            this.username = u;
        }

        private void agent_return_Load(object sender, EventArgs e)
        {
            a.conn.Open();
            OleDbCommand cm = new OleDbCommand("SELECT clint_name FROM clint_details ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                comboclint.Items.Add(red[0].ToString());

            }
            luname.Text = username;
            
            
        }

        private void btnGetRec_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            listView1.Items.Clear();
            combohouse.Items.Clear();
            OleDbCommand cm = new OleDbCommand(" SELECT clint_details.clint_name, clint_details.clint_nic, booking_details.house_number, house_details.house_address, house_details.house_price, booking_details.booking_date FROM house_details INNER JOIN (clint_details INNER JOIN booking_details ON clint_details.CID = booking_details.CID) ON house_details.house_number = booking_details.house_number; ", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
            OleDbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == comboclint.Text)
                {
                    ListViewItem li = new ListViewItem(reader[2].ToString());
                    li.SubItems.Add(reader[3].ToString());
                    listView1.Items.Add(li);
                    combohouse.Items.Add(reader[2].ToString());

                }

            }
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("NO HOUSE BOOKINGS TO RETURN");
                btnreturn.Enabled = false;

            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            combohouse.Items.Clear();
             OleDbCommand cm = new OleDbCommand("DELETE FROM booking_details where house_number=?", a.conn);
            cm.Parameters.AddWithValue("@p1", combohouse.Text);
            cm.ExecuteNonQuery();

            MessageBox.Show("House returned");
            groupBox1.Enabled = false;
            listView1.Items.Clear();
            
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new agent_home(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new available_houses(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pClint_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new agent_clint_details(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pRent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new rent(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new sign_in();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void luname_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        }
    }

