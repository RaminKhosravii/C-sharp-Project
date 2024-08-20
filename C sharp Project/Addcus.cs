using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Project
{
    public partial class Addcus : Form
    {
        public Addcus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtaddress.Clear();
            txtcod.Focus();
        }

        private void Addcus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.take_away_DataBaseDataSet2.customer);

        }

        private void btninput_Click(object sender, EventArgs e)
        {
            int k = customerTableAdapter.Insertcustomer(txtname.Text, txtlastname.Text, txtaddress.Text, txtnum.Text);
            if (k == 0)
            {
                MessageBox.Show("مشکلی در ذخیره رکورد به وجود آمده");
                return;
            }

            this.customerTableAdapter.Fill(this.take_away_DataBaseDataSet2.customer);
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");

            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtaddress.Clear();
            txtcod.Focus();
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = customerTableAdapter.Getcustomer(int.Parse(txtcod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی برای مشترکین ثبت نشده است");
                    txtcod.Focus();
                    return;
                }
                txtname.Text = dt.Rows[0][1].ToString();
                txtlastname.Text = dt.Rows[0][2].ToString();
                txtaddress.Text = dt.Rows[0][3].ToString();
                txtnum.Text = dt.Rows[0][4].ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int k = customerTableAdapter.Deletecustomer(int.Parse(txtcod.Text));
            if (k == 0)
            {
                MessageBox.Show("حذف انجام نشد ");
                return;
            }

            this.customerTableAdapter.Fill(this.take_away_DataBaseDataSet2.customer);
            MessageBox.Show("مشترک  حذف گردید");
            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtaddress.Clear();
            txtcod.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int k = customerTableAdapter.Updatecustomer(txtname.Text, txtlastname.Text, txtaddress.Text, txtnum.Text, int.Parse(txtcod.Text));
            this.customerTableAdapter.Fill(this.take_away_DataBaseDataSet2.customer);

            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtaddress.Clear();
            txtcod.Focus();
        }
    }
}
