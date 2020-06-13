namespace WindowsFormsApplication1
{
    partial class Form_ViewPayroll
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewPayroll));
            this.tblPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new WindowsFormsApplication1.Database1DataSet3();
            this.tblPayrollTableAdapter = new WindowsFormsApplication1.Database1DataSet3TableAdapters.tblPayrollTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutOffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmLateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagibigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.philhealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benefitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalearningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldeductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPayrollBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet7 = new WindowsFormsApplication1.Database1DataSet7();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.database1DataSet6 = new WindowsFormsApplication1.Database1DataSet6();
            this.tblPayrollBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPayrollTableAdapter1 = new WindowsFormsApplication1.Database1DataSet6TableAdapters.tblPayrollTableAdapter();
            this.tblPayrollTableAdapter2 = new WindowsFormsApplication1.Database1DataSet7TableAdapters.tblPayrollTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet5 = new WindowsFormsApplication1.Database1DataSet5();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPayrollBindingSource
            // 
            this.tblPayrollBindingSource.DataMember = "tblPayroll";
            this.tblPayrollBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPayrollTableAdapter
            // 
            this.tblPayrollTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(710, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 49);
            this.button1.TabIndex = 426;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iDNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.mSalaryDataGridViewTextBoxColumn,
            this.cutOffDataGridViewTextBoxColumn,
            this.from1DataGridViewTextBoxColumn,
            this.to1DataGridViewTextBoxColumn,
            this.twDaysDataGridViewTextBoxColumn,
            this.tmLateDataGridViewTextBoxColumn,
            this.otDataGridViewTextBoxColumn,
            this.sssDataGridViewTextBoxColumn,
            this.pagibigDataGridViewTextBoxColumn,
            this.philhealthDataGridViewTextBoxColumn,
            this.othersDataGridViewTextBoxColumn,
            this.dailyRateDataGridViewTextBoxColumn,
            this.hourRateDataGridViewTextBoxColumn,
            this.benefitsDataGridViewTextBoxColumn,
            this.totalearningsDataGridViewTextBoxColumn,
            this.totaldeductDataGridViewTextBoxColumn,
            this.netsalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPayrollBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(146, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 185);
            this.dataGridView1.TabIndex = 427;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDNoDataGridViewTextBoxColumn
            // 
            this.iDNoDataGridViewTextBoxColumn.DataPropertyName = "ID_No";
            this.iDNoDataGridViewTextBoxColumn.HeaderText = "ID No";
            this.iDNoDataGridViewTextBoxColumn.Name = "iDNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // mSalaryDataGridViewTextBoxColumn
            // 
            this.mSalaryDataGridViewTextBoxColumn.DataPropertyName = "M_Salary";
            this.mSalaryDataGridViewTextBoxColumn.HeaderText = "Monthly Salary";
            this.mSalaryDataGridViewTextBoxColumn.Name = "mSalaryDataGridViewTextBoxColumn";
            // 
            // cutOffDataGridViewTextBoxColumn
            // 
            this.cutOffDataGridViewTextBoxColumn.DataPropertyName = "CutOff";
            this.cutOffDataGridViewTextBoxColumn.HeaderText = "Cut Off";
            this.cutOffDataGridViewTextBoxColumn.Name = "cutOffDataGridViewTextBoxColumn";
            // 
            // from1DataGridViewTextBoxColumn
            // 
            this.from1DataGridViewTextBoxColumn.DataPropertyName = "From1";
            this.from1DataGridViewTextBoxColumn.HeaderText = "From";
            this.from1DataGridViewTextBoxColumn.Name = "from1DataGridViewTextBoxColumn";
            // 
            // to1DataGridViewTextBoxColumn
            // 
            this.to1DataGridViewTextBoxColumn.DataPropertyName = "To1";
            this.to1DataGridViewTextBoxColumn.HeaderText = "To";
            this.to1DataGridViewTextBoxColumn.Name = "to1DataGridViewTextBoxColumn";
            // 
            // twDaysDataGridViewTextBoxColumn
            // 
            this.twDaysDataGridViewTextBoxColumn.DataPropertyName = "Tw_Days";
            this.twDaysDataGridViewTextBoxColumn.HeaderText = "Worked Days";
            this.twDaysDataGridViewTextBoxColumn.Name = "twDaysDataGridViewTextBoxColumn";
            // 
            // tmLateDataGridViewTextBoxColumn
            // 
            this.tmLateDataGridViewTextBoxColumn.DataPropertyName = "Tm_Late";
            this.tmLateDataGridViewTextBoxColumn.HeaderText = "Tardiness (Min)";
            this.tmLateDataGridViewTextBoxColumn.Name = "tmLateDataGridViewTextBoxColumn";
            // 
            // otDataGridViewTextBoxColumn
            // 
            this.otDataGridViewTextBoxColumn.DataPropertyName = "Ot";
            this.otDataGridViewTextBoxColumn.HeaderText = "Overtime";
            this.otDataGridViewTextBoxColumn.Name = "otDataGridViewTextBoxColumn";
            // 
            // sssDataGridViewTextBoxColumn
            // 
            this.sssDataGridViewTextBoxColumn.DataPropertyName = "sss";
            this.sssDataGridViewTextBoxColumn.HeaderText = "SSS";
            this.sssDataGridViewTextBoxColumn.Name = "sssDataGridViewTextBoxColumn";
            // 
            // pagibigDataGridViewTextBoxColumn
            // 
            this.pagibigDataGridViewTextBoxColumn.DataPropertyName = "pagibig";
            this.pagibigDataGridViewTextBoxColumn.HeaderText = "Pag Ibig";
            this.pagibigDataGridViewTextBoxColumn.Name = "pagibigDataGridViewTextBoxColumn";
            // 
            // philhealthDataGridViewTextBoxColumn
            // 
            this.philhealthDataGridViewTextBoxColumn.DataPropertyName = "philhealth";
            this.philhealthDataGridViewTextBoxColumn.HeaderText = "PhilHealth";
            this.philhealthDataGridViewTextBoxColumn.Name = "philhealthDataGridViewTextBoxColumn";
            // 
            // othersDataGridViewTextBoxColumn
            // 
            this.othersDataGridViewTextBoxColumn.DataPropertyName = "others";
            this.othersDataGridViewTextBoxColumn.HeaderText = "Others";
            this.othersDataGridViewTextBoxColumn.Name = "othersDataGridViewTextBoxColumn";
            // 
            // dailyRateDataGridViewTextBoxColumn
            // 
            this.dailyRateDataGridViewTextBoxColumn.DataPropertyName = "daily_Rate";
            this.dailyRateDataGridViewTextBoxColumn.HeaderText = "daily_Rate";
            this.dailyRateDataGridViewTextBoxColumn.Name = "dailyRateDataGridViewTextBoxColumn";
            this.dailyRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // hourRateDataGridViewTextBoxColumn
            // 
            this.hourRateDataGridViewTextBoxColumn.DataPropertyName = "Hour_Rate";
            this.hourRateDataGridViewTextBoxColumn.HeaderText = "Hour_Rate";
            this.hourRateDataGridViewTextBoxColumn.Name = "hourRateDataGridViewTextBoxColumn";
            this.hourRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // benefitsDataGridViewTextBoxColumn
            // 
            this.benefitsDataGridViewTextBoxColumn.DataPropertyName = "benefits";
            this.benefitsDataGridViewTextBoxColumn.HeaderText = "Total Benefits";
            this.benefitsDataGridViewTextBoxColumn.Name = "benefitsDataGridViewTextBoxColumn";
            // 
            // totalearningsDataGridViewTextBoxColumn
            // 
            this.totalearningsDataGridViewTextBoxColumn.DataPropertyName = "total_earnings";
            this.totalearningsDataGridViewTextBoxColumn.HeaderText = "Earnings";
            this.totalearningsDataGridViewTextBoxColumn.Name = "totalearningsDataGridViewTextBoxColumn";
            // 
            // totaldeductDataGridViewTextBoxColumn
            // 
            this.totaldeductDataGridViewTextBoxColumn.DataPropertyName = "total_deduct";
            this.totaldeductDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.totaldeductDataGridViewTextBoxColumn.Name = "totaldeductDataGridViewTextBoxColumn";
            // 
            // netsalaryDataGridViewTextBoxColumn
            // 
            this.netsalaryDataGridViewTextBoxColumn.DataPropertyName = "net_salary";
            this.netsalaryDataGridViewTextBoxColumn.HeaderText = "NET SALARY";
            this.netsalaryDataGridViewTextBoxColumn.Name = "netsalaryDataGridViewTextBoxColumn";
            // 
            // tblPayrollBindingSource2
            // 
            this.tblPayrollBindingSource2.DataMember = "tblPayroll";
            this.tblPayrollBindingSource2.DataSource = this.database1DataSet7;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 428;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(501, 145);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 429;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 431;
            this.label1.Text = "FROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 432;
            this.label2.Text = "TO:";
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPayrollBindingSource1
            // 
            this.tblPayrollBindingSource1.DataMember = "tblPayroll";
            this.tblPayrollBindingSource1.DataSource = this.database1DataSet6;
            // 
            // tblPayrollTableAdapter1
            // 
            this.tblPayrollTableAdapter1.ClearBeforeFill = true;
            // 
            // tblPayrollTableAdapter2
            // 
            this.tblPayrollTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(823, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 49);
            this.button2.TabIndex = 433;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblPayrollBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(146, 407);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(859, 388);
            this.reportViewer1.TabIndex = 434;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Database1DataSet5
            // 
            this.Database1DataSet5.DataSetName = "Database1DataSet5";
            this.Database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 20);
            this.label3.TabIndex = 442;
            this.label3.Text = "(043)-441-6121/09091234534/phileastwood@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 20);
            this.label4.TabIndex = 441;
            this.label4.Text = "3rd Floor De Guzman Bldg., Camia St., Camilmil, Calapan City Oriental Mindoro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(691, 38);
            this.label5.TabIndex = 440;
            this.label5.Text = "PHILIPPINE EASTWOOD ACADEMY, INC.";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.ErrorImage")));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 442);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(95, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 439;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.ErrorImage")));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 219);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(95, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 438;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.ErrorImage")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(12, 329);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(95, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 437;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.ErrorImage")));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.InitialImage")));
            this.pictureBox9.Location = new System.Drawing.Point(12, 112);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(95, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 436;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(117, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 443;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 444;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 555);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 448;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form_ViewPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 807);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_ViewPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource tblPayrollBindingSource;
        private Database1DataSet3TableAdapters.tblPayrollTableAdapter tblPayrollTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource tblPayrollBindingSource1;
        private Database1DataSet6TableAdapters.tblPayrollTableAdapter tblPayrollTableAdapter1;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource tblPayrollBindingSource2;
        private Database1DataSet7TableAdapters.tblPayrollTableAdapter tblPayrollTableAdapter2;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Database1DataSet5 Database1DataSet5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutOffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn from1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn to1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmLateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagibigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn philhealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn benefitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalearningsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldeductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}