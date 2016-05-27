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
using WindowsFormsApplication1.Agent;
using WindowsFormsApplication1.Manager;

namespace WindowsFormsApplication1
{
    public partial class sign_in : Form
    {
        
        public sign_in()
        {
            InitializeComponent();
        }

        public OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ANDB.accdb");
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (combotype.Text == "AGENT")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from agent_details where user_name='" + tbxuName.Text + "' and password='" + tbxpass.Text + "'  ", conn);
                login(cmd);            
            }
            else if (combotype.Text == "MANAGER")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from manager where user_name='" + tbxuName.Text + "' and password='" + tbxpass.Text + "'  ", conn);
                login(cmd);
                 
            }
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
        public void login(OleDbCommand cmd)
        { 
         try{
               

                if (combotype.Text == "AGENT")
                {
                    OleDbDataReader red = cmd.ExecuteReader();
                    if (red.Read())
                    {
                        this.Hide();
                        var form = new agent_home(red[1].ToString());
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        
                    }
                    else
                        MessageBox.Show("invalid Password");
                }
                else if (combotype.Text =="MANAGER")
                {
                    OleDbDataReader red = cmd.ExecuteReader();
                    if (red.Read())
                    {
                        this.Hide();
                        var form = new manager_home(red[1].ToString());
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                    else
                        MessageBox.Show("invalid Password");
                }
                

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
