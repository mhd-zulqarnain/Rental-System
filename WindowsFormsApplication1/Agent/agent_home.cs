using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            label1.Text ="\n"+username;
        }

        private void pRent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new rent("\n"+username);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new available_houses("\n" + username);
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
    }
}
