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
    }
}
