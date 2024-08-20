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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.take_away_DataBaseDataSet2.personnel);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet.personnel' table. You can move, or remove it, as needed.

        }

        private void btninput_Click(object sender, EventArgs e)
        {
            DataTable dt = personnelTableAdapter.Getuser(txtuser.Text, txtpass.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد !");
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
                return;
            }
            Mainform frmmain = new Mainform();
            if (dt.Rows[0][6].ToString() == "منشی")
                frmmain.گزارشاتToolStripMenuItem.Visible = false;
            frmmain.ShowDialog();
        }
    }
}
