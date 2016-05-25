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
    public partial class available_houses : Form
    {
        sign_in a = new sign_in();
        string username;
        public available_houses()
        {
            InitializeComponent();
        }
        public available_houses(string u)
        {
            InitializeComponent();
            this.username =u;
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
                    li.SubItems.Add("$"+reader[2].ToString());
                    listV.Items.Add(li);


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

              
            }
        private void available_houses_Load(object sender, EventArgs e)
        {
            a.conn.Open();
            OleDbCommand cm = new OleDbCommand("SELECT house_details.house_number, house_details.house_address, house_details.house_price FROM house_details LEFT JOIN booking_details ON house_details.house_number=booking_details.house_number WHERE (((booking_details.house_number) Is Null));", a.conn);
            populate(listView1, cm);
            luname.Text = username;
            begin();
        }
        public void begin()
        {

            OleDbCommand cm = new OleDbCommand("SELECT * FROM agent_details ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                comboarea.Items.Add(red[2].ToString());

            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
                    li.SubItems.Add("$"+reader[2].ToString());
                    listView1.Items.Add(li);
                }


            }
        }

        private void pRent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new rent( username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new agent_home(username);
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

        private void pAvailable_Click(object sender, EventArgs e)
        {
           
        }
    }
}
