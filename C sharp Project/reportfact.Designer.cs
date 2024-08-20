namespace C_sharp_Project
{
    partial class reportfact
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
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportfactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.take_away_DataBaseDataSet2 = new C_sharp_Project.Take_away_DataBaseDataSet2();
            this.reportfactorTableAdapter = new C_sharp_Project.Take_away_DataBaseDataSet2TableAdapters.reportfactorTableAdapter();
            this.btnfactsave = new System.Windows.Forms.Button();
            this.txtfactdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.factdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factdetailTableAdapter = new C_sharp_Project.Take_away_DataBaseDataSet2TableAdapters.FactdetailTableAdapter();
            this.btndel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportfactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factdetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusnameDataGridViewTextBoxColumn,
            this.cusnumberDataGridViewTextBoxColumn,
            this.factcodDataGridViewTextBoxColumn,
            this.factdateDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.fAmountDataGridViewTextBoxColumn,
            this.ftedadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportfactorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cusname";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "نام مشترک";
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            // 
            // cusnumberDataGridViewTextBoxColumn
            // 
            this.cusnumberDataGridViewTextBoxColumn.DataPropertyName = "cusnumber";
            this.cusnumberDataGridViewTextBoxColumn.HeaderText = "شماره تلفن م";
            this.cusnumberDataGridViewTextBoxColumn.Name = "cusnumberDataGridViewTextBoxColumn";
            // 
            // factcodDataGridViewTextBoxColumn
            // 
            this.factcodDataGridViewTextBoxColumn.DataPropertyName = "factcod";
            this.factcodDataGridViewTextBoxColumn.HeaderText = "کد فاکتور";
            this.factcodDataGridViewTextBoxColumn.Name = "factcodDataGridViewTextBoxColumn";
            this.factcodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factdateDataGridViewTextBoxColumn
            // 
            this.factdateDataGridViewTextBoxColumn.DataPropertyName = "factdate";
            this.factdateDataGridViewTextBoxColumn.HeaderText = "تاریخ فاکتور";
            this.factdateDataGridViewTextBoxColumn.Name = "factdateDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "نام غذا";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // fAmountDataGridViewTextBoxColumn
            // 
            this.fAmountDataGridViewTextBoxColumn.DataPropertyName = "fAmount";
            this.fAmountDataGridViewTextBoxColumn.HeaderText = "قیمت غذا";
            this.fAmountDataGridViewTextBoxColumn.Name = "fAmountDataGridViewTextBoxColumn";
            // 
            // ftedadDataGridViewTextBoxColumn
            // 
            this.ftedadDataGridViewTextBoxColumn.DataPropertyName = "ftedad";
            this.ftedadDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.ftedadDataGridViewTextBoxColumn.Name = "ftedadDataGridViewTextBoxColumn";
            // 
            // reportfactorBindingSource
            // 
            this.reportfactorBindingSource.DataMember = "reportfactor";
            this.reportfactorBindingSource.DataSource = this.take_away_DataBaseDataSet2;
            // 
            // take_away_DataBaseDataSet2
            // 
            this.take_away_DataBaseDataSet2.DataSetName = "Take_away_DataBaseDataSet2";
            this.take_away_DataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportfactorTableAdapter
            // 
            this.reportfactorTableAdapter.ClearBeforeFill = true;
            // 
            // btnfactsave
            // 
            this.btnfactsave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnfactsave.Location = new System.Drawing.Point(854, 430);
            this.btnfactsave.Name = "btnfactsave";
            this.btnfactsave.Size = new System.Drawing.Size(196, 48);
            this.btnfactsave.TabIndex = 13;
            this.btnfactsave.Text = "چاپ گزارش";
            this.btnfactsave.UseVisualStyleBackColor = false;
            this.btnfactsave.Click += new System.EventHandler(this.btnfactsave_Click);
            // 
            // txtfactdate
            // 
            this.txtfactdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtfactdate.Location = new System.Drawing.Point(28, 442);
            this.txtfactdate.Name = "txtfactdate";
            this.txtfactdate.Size = new System.Drawing.Size(98, 36);
            this.txtfactdate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(132, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "تاریخ روز :";
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "953bc4d21aaf45b48c72241bfd322d6d";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // factdetailBindingSource
            // 
            this.factdetailBindingSource.DataMember = "Factdetail";
            this.factdetailBindingSource.DataSource = this.take_away_DataBaseDataSet2;
            // 
            // factdetailTableAdapter
            // 
            this.factdetailTableAdapter.ClearBeforeFill = true;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btndel.Location = new System.Drawing.Point(444, 435);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(111, 48);
            this.btndel.TabIndex = 16;
            this.btndel.Text = "پاک کردن";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(668, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "کد فاکتور :";
            // 
            // txtdel
            // 
            this.txtdel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtdel.Location = new System.Drawing.Point(564, 440);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(98, 36);
            this.txtdel.TabIndex = 17;
            // 
            // reportfact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdel);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfactdate);
            this.Controls.Add(this.btnfactsave);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "reportfact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارشات";
            this.Load += new System.EventHandler(this.reportfact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportfactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_away_DataBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factdetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Take_away_DataBaseDataSet2 take_away_DataBaseDataSet2;
        private System.Windows.Forms.BindingSource reportfactorBindingSource;
        private Take_away_DataBaseDataSet2TableAdapters.reportfactorTableAdapter reportfactorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamekolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnfactsave;
        private System.Windows.Forms.TextBox txtfactdate;
        private System.Windows.Forms.Label label1;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.BindingSource factdetailBindingSource;
        private Take_away_DataBaseDataSet2TableAdapters.FactdetailTableAdapter factdetailTableAdapter;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdel;
    }
}