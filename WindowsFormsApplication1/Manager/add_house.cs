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
    public partial class add_house : Form
    {
        sign_in a = new sign_in();
        string username;
        int housenumber;
        int agent_id;
        public add_house()
        {
            InitializeComponent();
        }
        public add_house(string u)
        {
            InitializeComponent();
            this.username = u;
        }
        private void add_house_Load(object sender, EventArgs e)
        {
            a.conn.Open();
            begin();
            label1.Text = username;
        }

        void begin() {
            Random rd = new Random();
            housenumber = rd.Next(100, 999);
            tbxhnum.Text = housenumber.ToString();

            OleDbCommand cm = new OleDbCommand("SELECT * FROM agent_details ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                comboArea.Items.Add(red[2].ToString());

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
              OleDbCommand cm = new OleDbCommand("SELECT agent_id FROM agent_details where area='"+comboArea.Text+"' ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
               agent_id=Convert.ToInt32(red[0]);

            }
            if (tbxAdress.Text != "")
            {
                OleDbCommand ins = new OleDbCommand("insert into house_details(house_number,house_address,agent_id,MID,area,house_price) values(?,?,?,?,?,?) ", a.conn);
                ins.Parameters.AddWithValue("@p1", housenumber);
                ins.Parameters.AddWithValue("@p2", tbxAdress.Text);
                ins.Parameters.AddWithValue("@p3", agent_id);
                ins.Parameters.AddWithValue("@p4", 1);
                ins.Parameters.AddWithValue("@p5", comboArea.Text);
                ins.Parameters.AddWithValue("@p6", comboPric.Text);
                ins.ExecuteNonQuery();
                Random rd = new Random();
                housenumber = rd.Next(100, 999);
                tbxhnum.Text = housenumber.ToString();
                MessageBox.Show("House added Successfully");
                clearBox();
            }
            else {
                MessageBox.Show("Fill all fields");
            }
        }
        void clearBox() {
            tbxAdress.Clear();
            
            Random rd = new Random();
            housenumber = rd.Next(3000, 9999);
            tbxhnum.Text = housenumber.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new sign_in();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new manager_home(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void pAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new manager_avliablehouse(username);
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

        private void pReser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new maanger_rec_handle(username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
