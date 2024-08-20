namespace C_sharp_Project
{
    partial class addpeik
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninput = new System.Windows.Forms.Button();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.take_away_DataBaseDataSet2 = new C_sharp_Project.Take_away_DataBaseDataSet2();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new C_sharp_Project.Take_away_DataBaseDataSet2TableAdapters.deliveryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delfamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.IndianRed;
            this.btnexit.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnexit.Location = new System.Drawing.Point(16, 180);
            this.btnexit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(70, 50);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.IndianRed;
            this.btndelete.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndelete.Location = new System.Drawing.Point(114, 180);
            this.btndelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(70, 50);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninput
            // 
            this.btninput.BackColor = System.Drawing.Color.IndianRed;
            this.btninput.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btninput.Location = new System.Drawing.Point(225, 180);
            this.btninput.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(70, 50);
            this.btninput.TabIndex = 4;
            this.btninput.Text = "ثبت";
            this.btninput.UseVisualStyleBackColor = false;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtlastname.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtlastname.Location = new System.Drawing.Point(498, 112);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtlastname.Multiline = true;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(212, 33);
            this.txtlastname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(724, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "نام خانوادگی:";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtname.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(225, 22);
            this.txtname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(212, 35);
            this.txtname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(451, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "نام :";
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcod.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcod.Location = new System.Drawing.Point(661, 22);
            this.txtcod.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtcod.Multiline = true;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(94, 35);
            this.txtcod.TabIndex = 0;
            this.txtcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(783, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "کد :";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnum.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnum.Location = new System.Drawing.Point(49, 115);
            this.txtnum.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(297, 35);
            this.txtnum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(360, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "شماره تلفن :";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.IndianRed;
            this.btnnew.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(414, 180);
            this.btnnew.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(70, 50);
            this.btnnew.TabIndex = 6;
            this.btnnew.Text = "جدید";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.button3_Click);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 269);
            this.dataGridView1.TabIndex = 31;
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
            this.delnameDataGridViewTextBoxColumn.HeaderText = "نام";
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
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.IndianRed;
            this.btnedit.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(321, 180);
            this.btnedit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(79, 50);
            this.btnedit.TabIndex = 32;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // addpeik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_Project.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(856, 537);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "addpeik";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addpeik";
            this.Load += new System.EventHandler(this.addpeik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private Take_away_DataBaseDataSet2 take_away_DataBaseDataSet2;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private Take_away_DataBaseDataSet2TableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn delcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delfamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnedit;
    }
}