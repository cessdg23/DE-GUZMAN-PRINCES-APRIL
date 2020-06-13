using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class Form_ViewPayslip : Form
    {
        public Form_ViewPayslip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;

          SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();



            SqlDataAdapter da = new SqlDataAdapter("Select * from tblPayroll where  ID_No ='" + txtID.Text + "' and From1 ='" + dateTimePicker2.Value + "'", cnn);
          DataTable dt = new DataTable();
         da.Fill(dt);
          dataGridView1.DataSource = dt;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'database1DataSet11.tblPayroll' table. You can move, or remove it, as needed.
this.tblPayrollTableAdapter.Fill(this.database1DataSet11.tblPayroll);

this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            string connetionString;
            
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();



            SqlDataAdapter da = new SqlDataAdapter("Select * from tblPayroll where  ID_No ='" + txtID.Text + "' and From1 ='" + dateTimePicker2.Value + "'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
           



           ReportDataSource rds = new ReportDataSource("DataSet1", dt);
           reportViewer1.LocalReport.ReportPath = @"C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Report1.rdlc";
           reportViewer1.LocalReport.DataSources.Clear();
           reportViewer1.LocalReport.DataSources.Add(rds);
           reportViewer1.RefreshReport();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form_AdminSetting f2 = new Form_AdminSetting(label3.Text);
            f2.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddPosition f2 = new Form_AddPosition();
            f2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddEmployee f2 = new Form_AddEmployee();
            f2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EmployeesPayroll f2 = new Form_EmployeesPayroll();
            f2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EmployeeAttendance f2 = new Form_EmployeeAttendance();
            f2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        }

        }
    

