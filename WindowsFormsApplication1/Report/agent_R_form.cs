using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Report
{
    public partial class agent_R_form : Form
    {
        string agent;
        public agent_R_form()
        {
            InitializeComponent();
        }
        public agent_R_form( string u)
        {
            InitializeComponent();
            this.agent = u;
          }
        private void agent_R_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.agent_details' table. You can move, or remove it, as needed.
            this.agent_detailsTableAdapter.Fill(this.DataSet1.agent_details,agent);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
