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
        }

        void begin() {
            Random rd = new Random();
            housenumber = rd.Next(3000, 9999);
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

            OleDbCommand ins = new OleDbCommand("insert into house_details(house_number,house_address,agent_id,MID,area) values(?,?,?,?,?) ",a.conn);
            ins.Parameters.AddWithValue("@p1", housenumber);
            ins.Parameters.AddWithValue("@p2", tbxAdress.Text);
            ins.Parameters.AddWithValue("@p1", agent_id);
            ins.Parameters.AddWithValue("@p1", 1);
            ins.Parameters.AddWithValue("@p1", comboArea.Text);
            ins.ExecuteNonQuery();
            Random rd = new Random();
            housenumber = rd.Next(3000, 9999);
            tbxhnum.Text = housenumber.ToString();
        }
    }
}
