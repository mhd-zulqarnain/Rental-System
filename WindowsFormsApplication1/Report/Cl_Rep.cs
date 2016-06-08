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
    public partial class Clint_Rep : Form
    {
        string clint;
        public Clint_Rep()
        {
            InitializeComponent();
        }
        public Clint_Rep( string CL)
        {
            InitializeComponent();
            this.clint = CL;
        }
        private void Cl_Rep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Clint_B_Det' table. You can move, or remove it, as needed.
            this.Clint_B_DetTableAdapter.Fill(this.DataSet1.Clint_B_Det,clint);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Clint_B_DetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
