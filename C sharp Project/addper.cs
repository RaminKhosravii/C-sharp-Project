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
    public partial class addper : Form
    {
        public addper()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtname.Clear();
            txtlastname.Clear();
            txtuser.Clear();
            txtpass.Clear();
            txtnum.Clear();
            txtside.Clear();
            txtcod.Focus();
        }

        private void addper_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.take_away_DataBaseDataSet2.personnel);

        }

        private void btninput_Click(object sender, EventArgs e)
        {
            int k = personnelTableAdapter.Insertpersonnel(txtuser.Text, txtpass.Text, txtname.Text, txtlastname.Text, txtnum.Text, txtside.Text);
            if (k == 0)
            {
                MessageBox.Show("مشکلی در ذخیره رکورد به وجود آمده");
                return;
            }
            this.personnelTableAdapter.Fill(this.take_away_DataBaseDataSet2.personnel);
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
            txtcod.ResetText();
            txtuser.Clear();
            txtpass.Clear();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtside.Clear();
            txtcod.Focus();
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = personnelTableAdapter.Getpersonnel(int.Parse(txtcod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی برای پرسنل ثبت نشده است");
                    txtcod.Focus();
                    return;
                }

                txtuser.Text = dt.Rows[0][1].ToString();
                txtpass.Text = dt.Rows[0][2].ToString();
                txtname.Text = dt.Rows[0][3].ToString();
                txtlastname.Text = dt.Rows[0][4].ToString();
                txtnum.Text = dt.Rows[0][5].ToString();
                txtside.Text = dt.Rows[0][6].ToString();    
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int k = personnelTableAdapter.Deletepersonnel(int.Parse(txtcod.Text));
            if (k == 0)
            {
                MessageBox.Show("حذف انجام نشد ");
                return;
            }
            this.personnelTableAdapter.Fill(this.take_away_DataBaseDataSet2.personnel);
            MessageBox.Show("پرسنل حذف گردید");
            txtcod.ResetText();
            txtuser.Clear();
            txtpass.Clear();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtside.Clear();
            txtcod.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int k = personnelTableAdapter.Updatepersonnel(txtuser.Text, txtpass.Text, txtname.Text, txtlastname.Text, txtnum.Text, txtside.Text, int.Parse(txtcod.Text));
            this.personnelTableAdapter.Fill(this.take_away_DataBaseDataSet2.personnel);

            txtcod.ResetText();
            txtuser.Clear();
            txtpass.Clear();
            txtname.Clear();
            txtlastname.Clear();
            txtnum.Clear();
            txtside.Clear();
            txtcod.Focus();
        }
    }
}
