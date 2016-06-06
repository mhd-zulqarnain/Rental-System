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
    public partial class manager_avliablehouse : Form
    {
        string username;
        sign_in a = new sign_in();
        public manager_avliablehouse()
        {
            InitializeComponent();
        }
        public manager_avliablehouse(String u)
        {
            InitializeComponent();
            this.username = u;
        }

        private void manager_avliablehouse_Load(object sender, EventArgs e)
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
                    li.SubItems.Add("$" + reader[2].ToString());
                    listV.Items.Add(li);


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    li.SubItems.Add("$" + reader[2].ToString());
                    listView1.Items.Add(li);
                    l1.Text = "Avaliable Houses at " + comboarea.Text;
                }


            }
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new manager_home(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pAgent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new manager_agent_details(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pAddHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new add_house(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pClint_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new manger_clint_details(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pAvailable_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new sign_in();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pReser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new maanger_rec_handle(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

    }
}
