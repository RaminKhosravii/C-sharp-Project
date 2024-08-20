namespace C_sharp_Project
{
    partial class addper
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtside = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btninput = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.take_away_DataBaseDataSet2 = new C_sharp_Project.Take_away_DataBaseDataSet2();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelTableAdapter = new C_sharp_Project.Take_away_DataBaseDataSet2TableAdapters.personnelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.percodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peruserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtuser.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtuser.Location = new System.Drawing.Point(535, 194);
            this.txtuser.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(227, 35);
            this.txtuser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(388, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "رمز عبور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(776, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام کاربری :";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpass.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtpass.Location = new System.Drawing.Point(135, 194);
            this.txtpass.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(239, 35);
            this.txtpass.TabIndex = 4;
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcod.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcod.Location = new System.Drawing.Point(732, 57);
            this.txtcod.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtcod.Multiline = true;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(75, 32);
            this.txtcod.TabIndex = 0;
            this.txtcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(822, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "کد :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtname.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(579, 118);
            this.txtname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(229, 37);
            this.txtname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(822, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "نام :";
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtlastname.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtlastname.Location = new System.Drawing.Point(114, 113);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtlastname.Multiline = true;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(236, 37);
            this.txtlastname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(364, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "نام خانوادگی:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtside
            // 
            this.txtside.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtside.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtside.Location = new System.Drawing.Point(565, 277);
            this.txtside.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtside.Multiline = true;
            this.txtside.Name = "txtside";
            this.txtside.Size = new System.Drawing.Size(230, 38);
            this.txtside.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(809, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "سمت :";
            // 
            // btninput
            // 
            this.btninput.BackColor = System.Drawing.Color.IndianRed;
            this.btninput.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btninput.Location = new System.Drawing.Point(314, 362);
            this.btninput.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(114, 56);
            this.btninput.TabIndex = 7;
            this.btninput.Text = "ثبت";
            this.btninput.UseVisualStyleBackColor = false;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.IndianRed;
            this.btndelete.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndelete.Location = new System.Drawing.Point(156, 362);
            this.btndelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(114, 56);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.IndianRed;
            this.btnexit.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnexit.Location = new System.Drawing.Point(16, 362);
            this.btnexit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 56);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(377, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "شماره تلفن :";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnum.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnum.Location = new System.Drawing.Point(125, 283);
            this.txtnum.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(238, 36);
            this.txtnum.TabIndex = 6;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.IndianRed;
            this.btnnew.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(601, 362);
            this.btnnew.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(114, 56);
            this.btnnew.TabIndex = 23;
            this.btnnew.Text = "جدید";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.button3_Click);
            // 
            // take_away_DataBaseDataSet2
            // 
            this.take_away_DataBaseDataSet2.DataSetName = "Take_away_DataBaseDataSet2";
            this.take_away_DataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "personnel";
            this.personnelBindingSource.DataSource = this.take_away_DataBaseDataSet2;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percodDataGridViewTextBoxColumn,
            this.peruserDataGridViewTextBoxColumn,
            this.perpassDataGridViewTextBoxColumn,
            this.pernameDataGridViewTextBoxColumn,
            this.perfamilyDataGridViewTextBoxColumn,
            this.pernumberDataGridViewTextBoxColumn,
            this.persideDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 443);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 219);
            this.dataGridView1.TabIndex = 24;
            // 
            // percodDataGridViewTextBoxColumn
            // 
            this.percodDataGridViewTextBoxColumn.DataPropertyName = "percod";
            this.percodDataGridViewTextBoxColumn.HeaderText = "کد پرسنل";
            this.percodDataGridViewTextBoxColumn.Name = "percodDataGridViewTextBoxColumn";
            // 
            // peruserDataGridViewTextBoxColumn
            // 
            this.peruserDataGridViewTextBoxColumn.DataPropertyName = "peruser";
            this.peruserDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.peruserDataGridViewTextBoxColumn.Name = "peruserDataGridViewTextBoxColumn";
            // 
            // perpassDataGridViewTextBoxColumn
            // 
            this.perpassDataGridViewTextBoxColumn.DataPropertyName = "perpass";
            this.perpassDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.perpassDataGridViewTextBoxColumn.Name = "perpassDataGridViewTextBoxColumn";
            // 
            // pernameDataGridViewTextBoxColumn
            // 
            this.pernameDataGridViewTextBoxColumn.DataPropertyName = "pername";
            this.pernameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.pernameDataGridViewTextBoxColumn.Name = "pernameDataGridViewTextBoxColumn";
            // 
            // perfamilyDataGridViewTextBoxColumn
            // 
            this.perfamilyDataGridViewTextBoxColumn.DataPropertyName = "perfamily";
            this.perfamilyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.perfamilyDataGridViewTextBoxColumn.Name = "perfamilyDataGridViewTextBoxColumn";
            // 
            // pernumberDataGridViewTextBoxColumn
            // 
            this.pernumberDataGridViewTextBoxColumn.DataPropertyName = "pernumber";
            this.pernumberDataGridViewTextBoxColumn.HeaderText = "شماره تلفن";
            this.pernumberDataGridViewTextBoxColumn.Name = "pernumberDataGridViewTextBoxColumn";
            // 
            // persideDataGridViewTextBoxColumn
            // 
            this.persideDataGridViewTextBoxColumn.DataPropertyName = "perside";
            this.persideDataGridViewTextBoxColumn.HeaderText = "سمت";
            this.persideDataGridViewTextBoxColumn.Name = "persideDataGridViewTextBoxColumn";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.IndianRed;
            this.btnedit.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(461, 362);
            this.btnedit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(114, 56);
            this.btnedit.TabIndex = 25;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // addper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_Project.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtside);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "addper";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن پرسنل";
            this.Load += new System.EventHandler(this.addper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtside;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnnew;
        private Take_away_DataBaseDataSet2 take_away_DataBaseDataSet2;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private Take_away_DataBaseDataSet2TableAdapters.personnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn percodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peruserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persideDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnedit;
    }
}