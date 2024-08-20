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
    public partial class cuslist : Form
    {
        public cuslist()
        {
            InitializeComponent();
        }

        private void cuslist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.take_away_DataBaseDataSet2.customer);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet1.customer' table. You can move, or remove it, as needed.

        }
    }
}
