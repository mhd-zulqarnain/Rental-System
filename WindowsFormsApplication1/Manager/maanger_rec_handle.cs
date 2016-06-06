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
using WindowsFormsApplication1.Report;

namespace WindowsFormsApplication1.Manager
{
    public partial class maanger_rec_handle : Form
    {
        string username;
        sign_in a = new sign_in();
        OleDbCommand cmd;
        OleDbDataReader reader;
        string name;
        string cnic;
        string uname;
        string pass;

        public maanger_rec_handle()
        {
            InitializeComponent();
        }
            public maanger_rec_handle( string u)
        {
            InitializeComponent();
            this.username = u;
        }

        private void maanger_rec_handle_Load(object sender, EventArgs e)
        {
            a.conn.Open();
            begin();
            luname.Text = username;
        }

        void begin()
        {

             cmd = new OleDbCommand("Select * from agent_details ", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
             reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboagentname.Items.Add(reader[1].ToString());

            }
            cmd = new OleDbCommand("Select * from clint_details ", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboclint.Items.Add(reader[1].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled =false;
            name = tbxname.Text;
            cnic = tbxnic.Text;
            uname = tbxuname.Text;
            pass = tbxpass.Text;
            string na =comboagentname.Text;
            try
            {
                if (name != "" && uname != "" && cnic != "" && pass != "") //&& comboCus.Text=="new"
                {
                    //cmd = new OleDbCommand("UPDATE agent_details SET agent_name=@p1,agent_cnum=@p2,user_name=@p3,password=@p4 ", a.conn);
                    //cmd = new OleDbCommand("UPDATE agent_details SET agent_name='" + name + "',agent_cnum='" + cnic + "',user_name='" + uname + "',password='" + pass + "';", a.conn);
                    //cmd = new OleDbCommand("UPDATE agent_details SET agent_name=@p1, agent_cnum =@p2, user_name= @p3,password=@p4 WHERE agent_name='"+na+"' " , a.conn);
                    //cmd.Parameters.AddWithValue("@p1", name);
                    //cmd.Parameters.AddWithValue("@p2", cnic);
                    //cmd.Parameters.AddWithValue("@p3", uname);
                    //cmd.Parameters.AddWithValue("@p4", pass);

                    //cmd.Parameters.AddWithValue("@p1", "test2");
                    //cmd.Parameters.AddWithValue("@p2", "2131");
                    //cmd.Parameters.AddWithValue("@p3", "test");
                    //cmd.Parameters.AddWithValue("@p4", "12345");

                    cmd = new OleDbCommand("UPDATE agent_details SET agent_name=@p1,user_name= @p3,agent_cnumber =@p2 WHERE agent_name='" + na + "' ", a.conn);
                    cmd.Parameters.AddWithValue("@p1", name);
                    cmd.Parameters.AddWithValue("@p3", uname);
                    cmd.Parameters.AddWithValue("@p2", cnic);
                    cmd.Parameters.AddWithValue("@p4", pass);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            cmd = new OleDbCommand(" Select * from agent_details;", a.conn);
            //cmd.Parameters.AddWithValue("@p1", comboarea.Text);
             reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (comboagentname.Text == reader[1].ToString())
                {
                    tbxname.Text = (reader[1].ToString());
                    tbxnic.Text = (reader[3].ToString());
                    tbxuname.Text = (reader[5].ToString());
                    tbxpass.Text = (reader[6].ToString());
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboclint.Text!="") //&& comboCus.Text=="new"
                {
                    cmd = new OleDbCommand("DELETE FROM clint_details WHERE clint_name='"+comboclint.Text+"'", a.conn);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clint record remove");
                }
                else
                    MessageBox.Show("Select Clint");
            }
            catch (Exception )
            {

                MessageBox.Show("Make sure clint does not have house on rent");
            }
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new sign_in();
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
    }
}
