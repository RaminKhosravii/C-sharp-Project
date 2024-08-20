namespace C_sharp_Project
{
    partial class dellist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.take_away_DataBaseDataSet2 = new C_sharp_Project.Take_away_DataBaseDataSet2();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new C_sharp_Project.Take_away_DataBaseDataSet2TableAdapters.deliveryTableAdapter();
            this.delcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delfamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delcodDataGridViewTextBoxColumn,
            this.delnameDataGridViewTextBoxColumn,
            this.delfamilyDataGridViewTextBoxColumn,
            this.delnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // take_away_DataBaseDataSet2
            // 
            this.take_away_DataBaseDataSet2.DataSetName = "Take_away_DataBaseDataSet2";
            this.take_away_DataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.take_away_DataBaseDataSet2;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // delcodDataGridViewTextBoxColumn
            // 
            this.delcodDataGridViewTextBoxColumn.DataPropertyName = "delcod";
            this.delcodDataGridViewTextBoxColumn.HeaderText = "کد پیک";
            this.delcodDataGridViewTextBoxColumn.Name = "delcodDataGridViewTextBoxColumn";
            this.delcodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delnameDataGridViewTextBoxColumn
            // 
            this.delnameDataGridViewTextBoxColumn.DataPropertyName = "delname";
            this.delnameDataGridViewTextBoxColumn.HeaderText = "نام ";
            this.delnameDataGridViewTextBoxColumn.Name = "delnameDataGridViewTextBoxColumn";
            // 
            // delfamilyDataGridViewTextBoxColumn
            // 
            this.delfamilyDataGridViewTextBoxColumn.DataPropertyName = "delfamily";
            this.delfamilyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.delfamilyDataGridViewTextBoxColumn.Name = "delfamilyDataGridViewTextBoxColumn";
            // 
            // delnumberDataGridViewTextBoxColumn
            // 
            this.delnumberDataGridViewTextBoxColumn.DataPropertyName = "delnumber";
            this.delnumberDataGridViewTextBoxColumn.HeaderText = "شماره تلفن";
            this.delnumberDataGridViewTextBoxColumn.Name = "delnumberDataGridViewTextBoxColumn";
            // 
            // dellist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 366);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "dellist";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست پیک ها";
            this.Load += new System.EventHandler(this.dellist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Take_away_DataBaseDataSet2 take_away_DataBaseDataSet2;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private Take_away_DataBaseDataSet2TableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn delcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delfamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delnumberDataGridViewTextBoxColumn;
    }
}