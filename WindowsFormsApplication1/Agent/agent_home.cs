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
            label1.Text = username;
        }
    }
}
