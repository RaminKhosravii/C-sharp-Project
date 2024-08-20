namespace C_sharp_Project
{
    partial class addfood
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninput = new System.Windows.Forms.Button();
            this.txttedad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamounts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.take_away_DataBaseDataSet2 = new C_sharp_Project.Take_away_DataBaseDataSet2();
            this.foodAndDrinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_and_drinkTableAdapter = new C_sharp_Project.Take_away_DataBaseDataSet2TableAdapters.food_and_drinkTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodAndDrinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.IndianRed;
            this.btnnew.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(448, 145);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(85, 45);
            this.btnnew.TabIndex = 37;
            this.btnnew.Text = "جدید";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.IndianRed;
            this.btnexit.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnexit.Location = new System.Drawing.Point(24, 145);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 45);
            this.btnexit.TabIndex = 38;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.IndianRed;
            this.btndelete.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndelete.Location = new System.Drawing.Point(131, 145);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(85, 45);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninput
            // 
            this.btninput.BackColor = System.Drawing.Color.IndianRed;
            this.btninput.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btninput.Location = new System.Drawing.Point(235, 145);
            this.btninput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(85, 45);
            this.btninput.TabIndex = 35;
            this.btninput.Text = "ثبت";
            this.btninput.UseVisualStyleBackColor = false;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // txttedad
            // 
            this.txttedad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txttedad.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttedad.Location = new System.Drawing.Point(211, 6);
            this.txttedad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttedad.Multiline = true;
            this.txttedad.Name = "txttedad";
            this.txttedad.Size = new System.Drawing.Size(164, 33);
            this.txttedad.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(394, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "تعداد موجودی :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtname.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(493, 70);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(152, 33);
            this.txtname.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(664, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "نام :";
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcod.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcod.Location = new System.Drawing.Point(573, 6);
            this.txtcod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcod.Multiline = true;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(73, 33);
            this.txtcod.TabIndex = 31;
            this.txtcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(665, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "کد :";
            // 
            // txtamounts
            // 
            this.txtamounts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtamounts.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtamounts.Location = new System.Drawing.Point(171, 71);
            this.txtamounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtamounts.Multiline = true;
            this.txtamounts.Name = "txtamounts";
            this.txtamounts.Size = new System.Drawing.Size(164, 33);
            this.txtamounts.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(354, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "قیمت پایه :";
            // 
            // take_away_DataBaseDataSet2
            // 
            this.take_away_DataBaseDataSet2.DataSetName = "Take_away_DataBaseDataSet2";
            this.take_away_DataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodAndDrinkBindingSource
            // 
            this.foodAndDrinkBindingSource.DataMember = "food and drink";
            this.foodAndDrinkBindingSource.DataSource = this.take_away_DataBaseDataSet2;
            // 
            // food_and_drinkTableAdapter
            // 
            this.food_and_drinkTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fcodDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.ftedadDataGridViewTextBoxColumn,
            this.fAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foodAndDrinkBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 171);
            this.dataGridView1.TabIndex = 43;
            // 
            // fcodDataGridViewTextBoxColumn
            // 
            this.fcodDataGridViewTextBoxColumn.DataPropertyName = "fcod";
            this.fcodDataGridViewTextBoxColumn.HeaderText = "کد غذا یا نوشیدنی";
            this.fcodDataGridViewTextBoxColumn.Name = "fcodDataGridViewTextBoxColumn";
            this.fcodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // ftedadDataGridViewTextBoxColumn
            // 
            this.ftedadDataGridViewTextBoxColumn.DataPropertyName = "ftedad";
            this.ftedadDataGridViewTextBoxColumn.HeaderText = "تعداد موجودی";
            this.ftedadDataGridViewTextBoxColumn.Name = "ftedadDataGridViewTextBoxColumn";
            // 
            // fAmountDataGridViewTextBoxColumn
            // 
            this.fAmountDataGridViewTextBoxColumn.DataPropertyName = "fAmount";
            this.fAmountDataGridViewTextBoxColumn.HeaderText = "قیمت پایه";
            this.fAmountDataGridViewTextBoxColumn.Name = "fAmountDataGridViewTextBoxColumn";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.IndianRed;
            this.btnedit.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(338, 145);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(85, 45);
            this.btnedit.TabIndex = 44;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // addfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_Project.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.txttedad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtamounts);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "addfood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن غذا و نوشیدنی";
            this.Load += new System.EventHandler(this.addfood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodAndDrinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.TextBox txttedad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamounts;
        private System.Windows.Forms.Label label1;
        private Take_away_DataBaseDataSet2 take_away_DataBaseDataSet2;
        private System.Windows.Forms.BindingSource foodAndDrinkBindingSource;
        private Take_away_DataBaseDataSet2TableAdapters.food_and_drinkTableAdapter food_and_drinkTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnedit;
    }
}