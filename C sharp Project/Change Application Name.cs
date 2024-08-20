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
    public partial class Change_Application_Name : Form
    {
        public Change_Application_Name()
        {
            InitializeComponent();
        }

        public string Title = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Title = txttitle.Text;
            this.Close();
        }
    }
}
