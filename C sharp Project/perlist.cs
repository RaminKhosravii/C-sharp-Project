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
    public partial class perlist : Form
    {
        public perlist()
        {
            InitializeComponent();
        }

        private void perlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.take_away_DataBaseDataSet2.personnel);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet.personnel' table. You can move, or remove it, as needed.

        }
    }
}
