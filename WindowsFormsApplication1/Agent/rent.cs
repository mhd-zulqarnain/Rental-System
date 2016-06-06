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


namespace WindowsFormsApplication1.Agent
{
    public partial class rent : Form
    {
        sign_in a = new sign_in();
        string username;
        int id;
        public rent()
        {
            InitializeComponent();
        }
        public rent(string u)
        {
            InitializeComponent();
            this.username = u;
        }
        public void populate(ListView listV, OleDbCommand cmd)
        {

            houseBox.Items.Clear();
            try
            {
                listV.Items.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem li = new ListViewItem(reader[0].ToString());
                    li.SubItems.Add(reader[1].ToString());
                    listV.Items.Add(li);

                    houseBox.Items.Add(reader[0].ToString());


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
            begin();
            lusername.Text = username;
        }


        public void begin()
        {
           

            tbxDate.Text = DateTime.Now.ToString("MM.dd.yyy");

            OleDbCommand cm = new OleDbCommand("SELECT * FROM agent_details ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                comboarea.Items.Add(red[2].ToString());

            }

        }
        
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int id = r.Next(1, 900);
            String cname = tbxCuName.Text;
            String cAdress = tbxadrs.Text;
            String cNic = tbxnic.Text;
            String Hnum = houseBox.Text;
            String d = DateTime.Now.ToShortDateString();

            try
            {
                if (cname != "" && cAdress != "" && cNic != "" && Hnum != "")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into clint_details(CID,clint_name,clint_address,clint_nic) values(?,?,?,?); ", a.conn);
                    cmd.Parameters.AddWithValue("@p1", id);
                    cmd.Parameters.AddWithValue("@p2", cname);
                    cmd.Parameters.AddWithValue("@p3", cAdress);
                    cmd.Parameters.AddWithValue("@p4", cNic);
                    cmd.ExecuteNonQuery();
                    OleDbCommand rmd = new OleDbCommand("Insert into  booking_details(CID,house_number,booking_date) values('" + id + "','" + Hnum + "','" + d + "'); ", a.conn);
                    rmd.ExecuteNonQuery();


                }
                else
                {
                    MessageBox.Show("Fill all Tables");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clearBox(){
            tbxCuName.Clear();
            tbxnic.Clear();
            houseBox.Text = "";
            
            
        
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            houseBox.Items.Clear();
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

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            a.conn.Close();
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
            this.Hide();
            var form = new available_houses(username);
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

        private void pClint_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new agent_clint_details(username);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
             
            String cname = tbxCuName.Text;
            String cAdress = tbxadrs.Text;
            String cNic = tbxnic.Text;
            String Hnum = houseBox.Text;
            String d = DateTime.Now.ToShortDateString();
            Random r = new Random();
            id = r.Next(200, 999);
            DialogResult result;
            try
            {
                if (cname != "" && cAdress != "" && cNic != "" && Hnum != ""&& comboCus.Text=="new") //&& comboCus.Text=="new"
                {
                    
                    OleDbCommand cmd = new OleDbCommand("Insert into clint_details(CID,clint_name,clint_address,clint_nic) values(?,?,?,?); ", a.conn);
                    cmd.Parameters.AddWithValue("@p1",id);
                    cmd.Parameters.AddWithValue("@p2", cname);
                    cmd.Parameters.AddWithValue("@p3", cAdress);
                    cmd.Parameters.AddWithValue("@p4", cNic);
                    cmd.ExecuteNonQuery();
                    OleDbCommand rmd = new OleDbCommand("Insert into  booking_details(CID,house_number,booking_date) values('" +id + "','" + Hnum + "','" + d + "'); ", a.conn);
                    rmd.ExecuteNonQuery();
                    result = MessageBox.Show("Do you want Generate Report?", "Question", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Clint_Script sc = new Clint_Script(Convert.ToInt32(houseBox.Text));
                        sc.Show();
                    }

                }
                else if (comboCus.Text == "Old")
                {
                    OleDbCommand cmd = new OleDbCommand("Select* from clint_details where clint_name='" + combocusName.Text + "'", a.conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    //int iid = Convert.ToInt16(rd[0]);
                    if (rd.Read())
                    {
                        OleDbCommand rmd = new OleDbCommand("Insert into  booking_details(CID,house_number,booking_date) values('" + Convert.ToInt16(rd[0]) + "','" + Hnum + "','" + d + "'); ", a.conn);
                        rmd.ExecuteNonQuery();
                    }
                    result = MessageBox.Show("Do you want Generate Report?", "Question", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) {
                        Clint_Script sc = new Clint_Script(Convert.ToInt32(houseBox.Text));
                        sc.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Fill all Tables");
                }

                   OleDbCommand cm = new OleDbCommand("SELECT house_details.house_number, house_details.house_address, house_details.house_price FROM house_details LEFT JOIN booking_details ON house_details.house_number=booking_details.house_number WHERE (((booking_details.house_number) Is Null));", a.conn);
            populate(listView1, cm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            houseBox.Items.Clear();
            houseBox.Text="";
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
                    houseBox.Items.Add(reader[0].ToString());
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             groupBox1.Visible = true;
             groupBox1.Enabled = true;
            
            if (comboCus.Text == "new")
            {
                oldCUs_Visible();
                newCus_In_visible();
                
            }
            else if (comboCus.Text == "Old")
            {
                OleDbCommand cmd = new OleDbCommand("Select clint_name from clint_details", a.conn);
                OleDbDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    combocusName.Items.Add(re[0].ToString());
                }
                newCus_visible();
                oldCUs_in_Visible();
                
            }
            else if (comboCus.Text == "")
            {
                MessageBox.Show("select Customer");
                groupBox1.Enabled = false;
            }
        }
        void oldCUs_Visible()
        {


            tbxadrs.Visible = true;
            tbxCuName.Visible = true;
            tbxnic.Visible = true;
            lcus.Visible = true;
            lnic.Visible = true;
            ladres.Visible = true;
          

        }
        void oldCUs_in_Visible()
        {


            tbxadrs.Visible = false;
            tbxCuName.Visible = false;
            tbxnic.Visible = false;
            lcus.Visible = false;
            lnic.Visible = false;
            ladres.Visible = false;
            
        }
        void newCus_visible()
        {
            combocusName.Visible = true;
            lCcus.Visible = true;
        }
        void newCus_In_visible()
        {
            combocusName.Visible = false;
            lCcus.Visible = false;
        }

        private void pRent_Click(object sender, EventArgs e)
        {

        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            Clint_Script sc = new Clint_Script(Convert.ToInt32(houseBox.Text));
            sc.Show();
        }
        
    }
}
