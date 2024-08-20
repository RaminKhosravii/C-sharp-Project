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
    public partial class reportfact : Form
    {
        public reportfact()
        {
            InitializeComponent();
        }

        DateTime datetoday = DateTime.Now;
        PersianCalendar pc = new PersianCalendar();
        private void reportfact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.Factdetail' table. You can move, or remove it, as needed.
            this.factdetailTableAdapter.Fill(this.take_away_DataBaseDataSet2.Factdetail);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.reportfactor' table. You can move, or remove it, as needed.
            this.reportfactorTableAdapter.Fill(this.take_away_DataBaseDataSet2.reportfactor);

            txtfactdate.Text = $"{pc.GetYear(datetoday)}/{pc.GetMonth(datetoday)}" +
            $"/{pc.GetDayOfMonth(datetoday)}";

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (
            //        MessageBox.Show("آیا از حذف سطر فعلی مطمئن هستید؟","هشدار!",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning,
            //        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes
            //)
            
            //{
            //    //int k = factdetailTableAdapter.DeleteRec(int.Parse(dataGridView1.Rows))
            //}
        }

        private void btnfactsave_Click(object sender, EventArgs e)
        {
            DataTable dt = reportfactorTableAdapter.GetData();
            dt.Rows[0][0].ToString();
            dt.Rows[0][1].ToString();
            dt.Rows[0][2].ToString();
            dt.Rows[0][3].ToString();
            dt.Rows[0][4].ToString();
            dt.Rows[0][5].ToString();
            dt.Rows[0][6].ToString();
            stiReport1.Load(Application.StartupPath + "/Report.mrt");
            stiReport1.RegData("DT", dt);
            stiReport1.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int k = factdetailTableAdapter.DeleteRec(int.Parse(txtdel.Text));
            if (k == 0)
            {
                MessageBox.Show("حذف انجام نشد ");
                return;
            }
            this.reportfactorTableAdapter.Fill(this.take_away_DataBaseDataSet2.reportfactor);
            MessageBox.Show("گزارش پاک شد");
            txtdel.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
