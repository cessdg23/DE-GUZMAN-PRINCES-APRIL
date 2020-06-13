namespace WindowsFormsApplication1
{
    partial class Form_ViewPayslip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewPayslip));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.tblPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet11 = new WindowsFormsApplication1.Database1DataSet11();
            this.tblPayrollDataSet = new WindowsFormsApplication1.tblPayrollDataSet();
            this.tblPayrollDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPayrollTableAdapter = new WindowsFormsApplication1.Database1DataSet11TableAdapters.tblPayrollTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(698, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 49);
            this.button1.TabIndex = 427;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(811, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 49);
            this.button2.TabIndex = 434;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(477, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 435;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 436;
            this.label2.Text = "FROM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 437;
            this.label1.Text = "ID NO.:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(254, 117);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 26);
            this.txtID.TabIndex = 442;
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
            this.dataGridView1.DataSource = this.tblPayrollBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(154, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 254);
            this.dataGridView1.TabIndex = 443;
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
            this.iDNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDNoDataGridViewTextBoxColumn.DataPropertyName = "ID_No";
            this.iDNoDataGridViewTextBoxColumn.HeaderText = "ID No";
            this.iDNoDataGridViewTextBoxColumn.Name = "iDNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // mSalaryDataGridViewTextBoxColumn
            // 
            this.mSalaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mSalaryDataGridViewTextBoxColumn.DataPropertyName = "M_Salary";
            this.mSalaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.mSalaryDataGridViewTextBoxColumn.Name = "mSalaryDataGridViewTextBoxColumn";
            // 
            // cutOffDataGridViewTextBoxColumn
            // 
            this.cutOffDataGridViewTextBoxColumn.DataPropertyName = "CutOff";
            this.cutOffDataGridViewTextBoxColumn.HeaderText = "CutOff";
            this.cutOffDataGridViewTextBoxColumn.Name = "cutOffDataGridViewTextBoxColumn";
            this.cutOffDataGridViewTextBoxColumn.Visible = false;
            // 
            // from1DataGridViewTextBoxColumn
            // 
            this.from1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.from1DataGridViewTextBoxColumn.DataPropertyName = "From1";
            this.from1DataGridViewTextBoxColumn.HeaderText = "From";
            this.from1DataGridViewTextBoxColumn.Name = "from1DataGridViewTextBoxColumn";
            // 
            // to1DataGridViewTextBoxColumn
            // 
            this.to1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.to1DataGridViewTextBoxColumn.DataPropertyName = "To1";
            this.to1DataGridViewTextBoxColumn.HeaderText = "To";
            this.to1DataGridViewTextBoxColumn.Name = "to1DataGridViewTextBoxColumn";
            // 
            // twDaysDataGridViewTextBoxColumn
            // 
            this.twDaysDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.twDaysDataGridViewTextBoxColumn.DataPropertyName = "Tw_Days";
            this.twDaysDataGridViewTextBoxColumn.HeaderText = "Worked Days";
            this.twDaysDataGridViewTextBoxColumn.Name = "twDaysDataGridViewTextBoxColumn";
            // 
            // tmLateDataGridViewTextBoxColumn
            // 
            this.tmLateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tmLateDataGridViewTextBoxColumn.DataPropertyName = "Tm_Late";
            this.tmLateDataGridViewTextBoxColumn.HeaderText = "Tardiness (Min)";
            this.tmLateDataGridViewTextBoxColumn.Name = "tmLateDataGridViewTextBoxColumn";
            // 
            // otDataGridViewTextBoxColumn
            // 
            this.otDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.otDataGridViewTextBoxColumn.DataPropertyName = "Ot";
            this.otDataGridViewTextBoxColumn.HeaderText = "Overtime";
            this.otDataGridViewTextBoxColumn.Name = "otDataGridViewTextBoxColumn";
            // 
            // sssDataGridViewTextBoxColumn
            // 
            this.sssDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sssDataGridViewTextBoxColumn.DataPropertyName = "sss";
            this.sssDataGridViewTextBoxColumn.HeaderText = "SSS";
            this.sssDataGridViewTextBoxColumn.Name = "sssDataGridViewTextBoxColumn";
            // 
            // pagibigDataGridViewTextBoxColumn
            // 
            this.pagibigDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pagibigDataGridViewTextBoxColumn.DataPropertyName = "pagibig";
            this.pagibigDataGridViewTextBoxColumn.HeaderText = "Pag-Ibig";
            this.pagibigDataGridViewTextBoxColumn.Name = "pagibigDataGridViewTextBoxColumn";
            // 
            // philhealthDataGridViewTextBoxColumn
            // 
            this.philhealthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.philhealthDataGridViewTextBoxColumn.DataPropertyName = "philhealth";
            this.philhealthDataGridViewTextBoxColumn.HeaderText = "PhilHealth";
            this.philhealthDataGridViewTextBoxColumn.Name = "philhealthDataGridViewTextBoxColumn";
            // 
            // othersDataGridViewTextBoxColumn
            // 
            this.othersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.benefitsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.benefitsDataGridViewTextBoxColumn.DataPropertyName = "benefits";
            this.benefitsDataGridViewTextBoxColumn.HeaderText = "Total Benefits";
            this.benefitsDataGridViewTextBoxColumn.Name = "benefitsDataGridViewTextBoxColumn";
            // 
            // totalearningsDataGridViewTextBoxColumn
            // 
            this.totalearningsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalearningsDataGridViewTextBoxColumn.DataPropertyName = "total_earnings";
            this.totalearningsDataGridViewTextBoxColumn.HeaderText = "Earnings";
            this.totalearningsDataGridViewTextBoxColumn.Name = "totalearningsDataGridViewTextBoxColumn";
            // 
            // totaldeductDataGridViewTextBoxColumn
            // 
            this.totaldeductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totaldeductDataGridViewTextBoxColumn.DataPropertyName = "total_deduct";
            this.totaldeductDataGridViewTextBoxColumn.HeaderText = "Deductions";
            this.totaldeductDataGridViewTextBoxColumn.Name = "totaldeductDataGridViewTextBoxColumn";
            // 
            // netsalaryDataGridViewTextBoxColumn
            // 
            this.netsalaryDataGridViewTextBoxColumn.DataPropertyName = "net_salary";
            this.netsalaryDataGridViewTextBoxColumn.HeaderText = "NET Salary";
            this.netsalaryDataGridViewTextBoxColumn.Name = "netsalaryDataGridViewTextBoxColumn";
            // 
            // tblPayrollBindingSource
            // 
            this.tblPayrollBindingSource.DataMember = "tblPayroll";
            this.tblPayrollBindingSource.DataSource = this.database1DataSet11;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet11";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPayrollDataSet
            // 
            this.tblPayrollDataSet.DataSetName = "tblPayrollDataSet";
            this.tblPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPayrollDataSetBindingSource
            // 
            this.tblPayrollDataSetBindingSource.DataSource = this.tblPayrollDataSet;
            this.tblPayrollDataSetBindingSource.Position = 0;
            // 
            // tblPayrollTableAdapter
            // 
            this.tblPayrollTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(154, 409);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(786, 253);
            this.reportViewer1.TabIndex = 444;
            this.reportViewer1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 20);
            this.label3.TabIndex = 452;
            this.label3.Text = "(043)-441-6121/09091234534/phileastwood@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 20);
            this.label4.TabIndex = 451;
            this.label4.Text = "3rd Floor De Guzman Bldg., Camia St., Camilmil, Calapan City Oriental Mindoro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(691, 38);
            this.label5.TabIndex = 450;
            this.label5.Text = "PHILIPPINE EASTWOOD ACADEMY, INC.";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.ErrorImage")));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(28, 438);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(95, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 449;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.ErrorImage")));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(28, 215);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(95, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 448;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.ErrorImage")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(28, 325);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(95, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 447;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.ErrorImage")));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.InitialImage")));
            this.pictureBox9.Location = new System.Drawing.Point(28, 108);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(95, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 446;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(89, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 453;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 454;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 548);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 455;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form_ViewPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 674);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_ViewPayslip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollDataSetBindingSource)).EndInit();
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblPayrollDataSetBindingSource;
        private tblPayrollDataSet tblPayrollDataSet;
        private Database1DataSet11 database1DataSet11;
        private System.Windows.Forms.BindingSource tblPayrollBindingSource;
        private Database1DataSet11TableAdapters.tblPayrollTableAdapter tblPayrollTableAdapter;
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
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