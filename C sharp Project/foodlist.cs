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
    public partial class foodlist : Form
    {
        public foodlist()
        {
            InitializeComponent();
        }

        private void foodlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet2.food_and_drink' table. You can move, or remove it, as needed.
            this.food_and_drinkTableAdapter.Fill(this.take_away_DataBaseDataSet2.food_and_drink);
            // TODO: This line of code loads data into the 'take_away_DataBaseDataSet1.food_and_drink' table. You can move, or remove it, as needed.

        }
    }
}
