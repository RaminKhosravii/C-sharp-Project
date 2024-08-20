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
    public partial class addpeik : Form
    {
        public addpeik()
        {
            InitializeComponent();
        }

        private void addpeik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.take_away_DataBaseDataSet2.delivery);

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
            txtcod.Focus();
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            int k = deliveryTableAdapter.Insertdelivery(txtname.Text, txtlastname.Text, txtnum.Text);
            if (k == 0)
            {
                MessageBox.Show("مشکلی در ذخیره رکورد به وجود آمده");
                return;
            }
            this.deliveryTableAdapter.Fill(this.take_away_DataBaseDataSet2.delivery);
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtcod.Focus();
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = deliveryTableAdapter.Getdelivery(int.Parse(txtcod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی برای پیک ها ثبت نشده است");
                    txtcod.Focus();
                    return;
                }
                txtname.Text = dt.Rows[0][1].ToString();
                txtlastname.Text = dt.Rows[0][2].ToString();
                txtnum.Text = dt.Rows[0][3].ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int k = deliveryTableAdapter.Deletedelivery(int.Parse(txtcod.Text));
            if (k == 0)
            {
                MessageBox.Show("حذف انجام نشد ");
                return;
            }
            this.deliveryTableAdapter.Fill(this.take_away_DataBaseDataSet2.delivery);
            MessageBox.Show("پیک حذف گردید");
            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtcod.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int k = deliveryTableAdapter.Updatedelivery(txtname.Text, txtlastname.Text, txtnum.Text, int.Parse(txtcod.Text));
            this.deliveryTableAdapter.Fill(this.take_away_DataBaseDataSet2.delivery);
            MessageBox.Show("پیک ویرایش شد");

            txtcod.ResetText();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtcod.Focus();
        }
    }
}
