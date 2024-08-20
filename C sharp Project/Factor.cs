using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace C_sharp_Project
{
    public partial class Factor : Form
    {
        public Factor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcuscod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = customerTableAdapter.Getcustomer(int.Parse(txtcuscod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی موجود نیست ");
                    txtcuscod.Focus();
                    txtcuscod.Clear();
                    return;
                }
                txtcusname.Text = dt.Rows[0][1].ToString();
                txtcusnum.Text = dt.Rows[0][4].ToString();
                txtfcod.Focus();
            }
        }

        private void Factor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.Factdetail' table. You can move, or remove it, as needed.
            this.factdetailTableAdapter.Fill(this.take_away_DataBaseDataSet2.Factdetail);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet21.Factkol' table. You can move, or remove it, as needed.
            this.upper_part_of_factorTableAdapter.Fill(this.take_away_DataBaseDataSet2.upper_part_of_factor);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.food_and_drink' table. You can move, or remove it, as needed.
            this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.take_away_DataBaseDataSet2.customer);

             txtfactdate.Text = $"{pc.GetYear(datetoday)}/{pc.GetMonth(datetoday)}" +
             $"/{pc.GetDayOfMonth(datetoday)}";

          //  txtfactdate.Text = DateTime.Now.ToLongDateString();

        }

        int mojudi;
        private void txtfcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = food_and_drinkTableAdapter.Getfood(int.Parse(txtfcod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی موجود نیست ");
                    txtfcod.Focus();
                    txtfcod.Clear();
                    return;
                }
                txtfname.Text = dt.Rows[0][1].ToString();
                txtfamount.Text = dt.Rows[0][3].ToString();
                mojudi = (int) dt.Rows[0][2];
                txttedad.Focus();
            }
        }

        int radif = 0;
        int jamkol = 0;
        DateTime datetoday = DateTime.Now;
        PersianCalendar pc = new PersianCalendar();

        private void pickalaadd_Click(object sender, EventArgs e)
        {
            string[] satr = new string[6];
            if (mojudi <int.Parse(txttedad.Text))
            {
                MessageBox.Show("موجودی به این تعداد نیست");
                txttedad.Focus();
                txttedad.Clear();
                return;
            }
            radif++;
            satr[0] = radif.ToString();
            satr[1] = txtfcod.Text;
            satr[2] = txtfname.Text;
            satr[3] = txttedad.Text;
            satr[4] = txtfamount.Text;
            satr[5] = (int.Parse(satr[3]) * int.Parse(satr[4])).ToString();
            jamkol += int.Parse(satr[5]);
            dataGridView1.Rows.Add(satr);
            lbljamkol.Text = jamkol.ToString();
            clear();
        }

        void clear()
        {
            txttedad.Clear();
            txtfname.Clear();
            txtfcod.Clear();
            txtfamount.Clear();
            txtfcod.Focus();
        }

        private void txttedad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pickalaadd_Click(null, null);
        }

        private void btnfactsave_Click(object sender, EventArgs e)
        {
            int k = upper_part_of_factorTableAdapter.Insertfacthead(txtfactdate.Text, int.Parse(txtcuscod.Text));
            this.upper_part_of_factorTableAdapter.Fill(this.take_away_DataBaseDataSet2.upper_part_of_factor);
            DataTable dt = upper_part_of_factorTableAdapter.Getfacts();
            int shfact = (int)dt.Rows[dt.Rows.Count -1][0];
            int n = dataGridView1.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                int p = factdetailTableAdapter.InsertFactkol(shfact, 
                    int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                    int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
            }
            MessageBox.Show("فاکتور ثبت گردید");

            txtcusname.Clear();
            txtcuscod.Clear();
            txtcusnum.Clear();
            dataGridView1.Rows.Clear();
            lbljamkol.Text = "0";
        }
    }
}
