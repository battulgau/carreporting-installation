using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FReport : Form
    {
        public FReport()
        {
            InitializeComponent();
        }

        private void FReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CarDataSet.Car' table. You can move, or remove it, as needed.
            this.CarTableAdapter.Fill(this.CarDataSet.Car);

            this.reportViewer1.RefreshReport();
        }
    }
}
