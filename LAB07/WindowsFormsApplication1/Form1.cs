using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Car myCar;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Car.mdf;Integrated Security=True");
        public void showData() {
            if (con.State != ConnectionState.Open) con.Open();
            SqlCommand cmd = new SqlCommand("select *from Car", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gvCar.DataSource = dt;
            con.Close();
        }
        public void clearData() {
            txtZagvar.Clear();
            txtAralDugaar.Clear();
            txtUngu.Clear();
            maskOn.Clear();
            cmbAngilal.SelectedIndex = 0;
            maskUlsDugaar.Clear();
            txtZagvar.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbAngilal.SelectedItem.ToString());
            if (txtZagvar.Text.Trim().Length == 0)
            {
                MessageBox.Show("Моделоо оруулна уу!");
                txtZagvar.Focus();
            }
            else if (txtAralDugaar.Text.Trim().Length == 0)
            {
                MessageBox.Show("Аралын дугаараа оруулна уу!");
                txtAralDugaar.Focus();
            }
            else if (txtUngu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Өнгө оруулна уу!");
                txtUngu.Focus();
            }
            else if (maskOn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Он оруулна уу!");
                maskOn.Focus();
            }
            else if (cmbAngilal.SelectedIndex < 0)
            {
                MessageBox.Show("Ангилал сонгоно уу!");
                cmbAngilal.Focus();
            }
            else if (maskUlsDugaar.Text.Trim().Length == 1)
            {
                MessageBox.Show("Улсын дугаар оруулна уу!");
                maskUlsDugaar.Focus();
            }
            else
            {
                myCar = new Car(txtZagvar.Text.Trim(), txtAralDugaar.Text.Trim(), txtUngu.Text.Trim(), Convert.ToInt32(maskOn.Text.Trim()), Convert.ToChar(cmbAngilal.SelectedItem.ToString()), maskUlsDugaar.Text.Trim());


                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    MessageBox.Show("Холболт амжилттай");
                }

                SqlCommand cmd = new SqlCommand("insert into Car " +
                    "values(" +
                    "N'" + myCar.Zagvar + "', " +
                    "N'" + myCar.AralDugaar + "'," +
                    "N'" + myCar.Ungu + "','"
                    + myCar.On + "'," +
                    "N'" + myCar.Angilal + "'," +
                    "N'" + myCar.UlsDugaar + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Амжилттай бүртгэлээ");
                showData();
                clearData();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            showData();
            clearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open) con.Open();
            int rind = gvCar.SelectedCells[0].RowIndex;

            SqlCommand cmd = new SqlCommand("delete from Car where Id = "
                + gvCar.Rows[rind].Cells["Id"].Value.ToString() + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearData();
            showData();
            MessageBox.Show("Машины бүртгэл амжилттай устгалаа");
        }

        private void gvCar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rind = gvCar.SelectedCells[0].RowIndex;
                txtZagvar.Text = gvCar.Rows[rind].Cells["Zagvar"].Value.ToString();
                txtAralDugaar.Text = gvCar.Rows[rind].Cells["AralDugaar"].Value.ToString();
                txtUngu.Text = gvCar.Rows[rind].Cells["Ungu"].Value.ToString();

                cmbAngilal.SelectedIndex = 
                cmbAngilal.Items.IndexOf(gvCar.Rows[rind].Cells["Angilal"].
                Value.ToString().Trim());
                //MessageBox.Show(cmbAngilal.Items.IndexOf(gvCar.Rows[rind].Cells["Angilal"].Value.ToString().Trim()).ToString());
                maskOn.Text = gvCar.Rows[rind].Cells["UildverOn"].Value.ToString();
                maskUlsDugaar.Text = gvCar.Rows[rind].Cells["UlsDugaar"].Value.ToString();
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open) con.Open();
            int rind = gvCar.SelectedCells[0].RowIndex;
            myCar = new Car(txtZagvar.Text.Trim(),
                txtAralDugaar.Text.Trim(), txtUngu.Text.Trim(),
                Convert.ToInt32(maskOn.Text.Trim()),
                Convert.ToChar(cmbAngilal.SelectedItem.ToString()),
                maskUlsDugaar.Text.Trim());
            SqlCommand cmd = new SqlCommand("update Car set Zagvar = N'"
                + myCar.Zagvar + "', AralDugaar = N'"
                + myCar.AralDugaar + "', Ungu = N'"
                + myCar.Ungu + "', UildverOn = "
                + myCar.On + ", Angilal = '"
                + myCar.Angilal + "', UlsDugaar = N'"
                + myCar.UlsDugaar + "' where Id = "
                + gvCar.Rows[rind].Cells["Id"].Value.ToString()
                + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearData();
            showData();
            MessageBox.Show("Машины бүртгэл амжилттай заслаа");
        }

        private void машиныБүртгэлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReport rep = new FReport();
            rep.Show();
        }
    }
}
