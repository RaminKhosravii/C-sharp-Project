using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace C_sharp_Project
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void تغییررنگمنوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                menuStrip1.BackColor = cd.Color;
        }

        private void تغییرنوعقلمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                menuStrip1.Font = fd.Font;
        }

        private void تغییررنگقلمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                menuStrip1.ForeColor = cd.Color;
        }

        private void تغییرپسزمینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "تصاویر | *.jpg; *.png";
            if (of.ShowDialog() == DialogResult.OK)
                picmianback.ImageLocation = of.FileName;

        }

        private void عوضکردنعنوانبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Application_Name frmtitr = new Change_Application_Name();
            frmtitr.ShowDialog();
            this.Text = frmtitr.Title;
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("config.ini", this.Text + ","
                + menuStrip1.BackColor.ToArgb() + ","
                + menuStrip1.ForeColor.ToArgb() + ","
                + menuStrip1.Font.Name + "," +
                (int) menuStrip1.Font.Size);
            picmianback.Image.Save("image.jpg", ImageFormat.Jpeg);
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            string p;
            if (File.Exists("config.ini"))
            {
                p = File.ReadAllText("config.ini");
                string [] s = p.Split(',');
                this.Text = s[0];
                menuStrip1.BackColor = Color.FromArgb(int.Parse(s[1]));
                menuStrip1.ForeColor = Color.FromArgb(int.Parse(s[2]));
                menuStrip1.Font = new Font(s[3], int.Parse(s[4]));
            }
            if (File.Exists("image.jpg"))
                picmianback.ImageLocation = "image.jpg";
        }

        private void پرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void پیکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpeik addpeik = new addpeik();
            addpeik.ShowDialog();
        }

        private void اضافهکردنمشترکجدیدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Addcus addcus = new Addcus();
            addcus.ShowDialog();
        }

        private void لیستمشترکینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addper addper = new addper();
            addper.ShowDialog();
        }

        private void لیستغذاونوشیدنیهاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addfood addfood = new addfood();
            addfood.ShowDialog();
        }

        private void اضافهکردنغذاونوشیدنیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void پرسنلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void پیکهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dellist dellist = new dellist();
            dellist.ShowDialog();
        }

        private void ثبتحضوریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void حضوریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void اضافهکردممشترکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addcus addcus = new Addcus();
            addcus.ShowDialog();
        }

        private void پرسنلToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addper addper = new addper();
            addper.ShowDialog();
        }

        private void پیکToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addpeik addpeik = new addpeik();
            addpeik.ShowDialog();
        }

        private void اضافهکردنغذاونوشیدنیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addfood addfood = new addfood();
            addfood.ShowDialog();
        }

        private void ثبتسفارشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Factor factor = new Factor();
            factor.ShowDialog();
        }

        private void اضافهکردنمشترکجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addper addper = new addper();
            addper.ShowDialog();
        }

        private void لیستغذاونوشیدنیهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ثبتسفارشاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factor factor = new Factor();
            factor.ShowDialog();
        }

        private void گزارشفاکتورهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportfact reportfact = new reportfact();
            reportfact.ShowDialog();
        }

        private void لیستپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perlist perlist = new perlist();
            perlist.ShowDialog();
        }

        private void لیستغذاونوشیدنیهاToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foodlist foodlist = new foodlist();
            foodlist.ShowDialog();
        }

        private void لیستمشترکینToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cuslist cuslist = new cuslist();
            cuslist.ShowDialog();
        }
    }
}
