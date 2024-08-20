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
    public partial class addfood : Form
    {
        public addfood()
        {
            InitializeComponent();
        }

        private void addfood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.food_and_drink' table. You can move, or remove it, as needed.
            this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            int k = food_and_drinkTableAdapter.Insertfood(txtname.Text, int.Parse(txttedad.Text), int.Parse(txtamounts.Text));
            if (k == 0)
            {
                MessageBox.Show("مشکلی در ذخیره رکورد به وجود آمده");
                return;
            }
            this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
            
            btnnew_Click(null, null);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtcod.ResetText();
            txtname.Clear();
            txttedad.Clear();
            txtamounts.Clear();
            txtcod.Focus();
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = food_and_drinkTableAdapter.Getfood(int.Parse(txtcod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی برای مشترکین ثبت نشده است");
                    txtcod.Focus();
                    return;
                }
                txtname.Text = dt.Rows[0][1].ToString();
                txttedad.Text = dt.Rows[0][2].ToString();
                txtamounts.Text = dt.Rows[0][3].ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            //food_and_drinkTableAdapter.Deletefood(int.Parse(txtcod.Text));
            //this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);
            //MessageBox.Show("غذا و یا نوشیدنی حذف گردید");

            int k = food_and_drinkTableAdapter.Deletefood(int.Parse(txtcod.Text));
            if (k == 0)
            {
                MessageBox.Show("حذف انجام نشد ");
                return;
            }
            this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);
            MessageBox.Show("غذا و یا نوشیدنی حذف گردید");

            btnnew_Click(null, null);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int k = food_and_drinkTableAdapter.Updatefood(txtname.Text, int.Parse(txttedad.Text), int.Parse(txtamounts.Text), int.Parse(txtcod.Text));
            this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);

            btnnew_Click(null, null);
        }
    }   
}
