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
    public partial class agent_home : Form
    {
        public string username;
        int ren, all;
        OleDbCommand cmd;
        OleDbDataReader read;
        sign_in a = new sign_in();
        public agent_home()
        {
            InitializeComponent();
        }
        public agent_home(string u)
        {
            InitializeComponent();
            this.username = u;
           
        }
        
        private void agent_home_Load(object sender, EventArgs e)
        {
            
            a.conn.Open();
            label1.Text =username;
            cmd =new OleDbCommand("Select Count(CID) from booking_details", a.conn);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                rent.Text = read[0].ToString();
                ren =Convert.ToInt16( read[0].ToString());
            }


            cmd = new OleDbCommand("Select count(house_number) from house_details", a.conn);
            read = cmd.ExecuteReader();
            if(read.Read())
            all = Convert.ToInt16(read[0].ToString());

            laAVA.Text = Math.Abs(all - ren).ToString();
            begin();
        }
        void begin() { 
        cmd = new OleDbCommand("Select COUNT(CID) from clint_details", a.conn);
        read = cmd.ExecuteReader();
        if (read.Read())
        {
            laCli.Text = read[0].ToString();

        }
            
        
        }
        private void pRent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new rent(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new available_houses(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new sign_in();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new agent_return(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pClint_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new agent_clint_details(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pHome_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lableDes.Visible = false;
            listView1.Items.Clear();
            OleDbCommand cm = new OleDbCommand(" SELECT house_details.house_number, house_details.house_address, house_details.house_price, house_details.agent_id, house_details.area FROM house_details LEFT JOIN booking_details ON house_details.house_number = booking_details.house_number WHERE (((booking_details.house_number) Is Null));", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
            OleDbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                if (comboarea.Text == reader[4].ToString())
                {
                    ListViewItem li = new ListViewItem(reader[0].ToString());
                    li.SubItems.Add(reader[1].ToString());
                    listView1.Items.Add(li);
                }


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
