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
    public partial class Cl_Rep : Form
    {
        public Cl_Rep()
        {
            InitializeComponent();
        }

        private void Cl_Rep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Clint_B_Det' table. You can move, or remove it, as needed.
            this.Clint_B_DetTableAdapter.Fill(this.DataSet1.Clint_B_Det);

            this.reportViewer1.RefreshReport();
        }
    }
}
