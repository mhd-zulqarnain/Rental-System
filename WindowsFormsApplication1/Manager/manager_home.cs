using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Manager
{
    public partial class manager_home : Form
    {
        public string username;
        public manager_home()
        {
            InitializeComponent();
        }
        public manager_home(string u )
        {
            InitializeComponent();
            this.username = u;
        }
        private void manager_home_Load(object sender, EventArgs e)
        {
            label1.Text = username;
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pAddHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new add_house(username);
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new sign_in();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
