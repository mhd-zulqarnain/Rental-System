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
    public partial class rent : Form
    {
        sign_in a = new sign_in();
        public rent()
        {
            InitializeComponent();
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
                    listV.Items.Add(li);


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
        }
        
        
        public void begin() {
            OleDbCommand com = new OleDbCommand("SELECT house_details.house_number FROM house_details LEFT JOIN booking_details ON house_details.house_number=booking_details.house_number WHERE (((booking_details.house_number) Is Null));", a.conn);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                houseBox.Items.Add(rd[0].ToString());
                
            }
            rd.Close();

            tbxDate.Text = DateTime.Now.ToString("MM.dd.yyy");

            OleDbCommand cm = new OleDbCommand("SELECT * FROM agent_details ;", a.conn);
            OleDbDataReader red = cm.ExecuteReader();
            while (red.Read())
            {
                comboarea.Items.Add(red[2].ToString());

            }
            rd.Close();
            
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
                    cmd.Parameters.AddWithValue("@p4", Hnum);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                    listView1.Items.Add(li);
                }


            }
        }
    }
}
