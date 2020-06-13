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
    public partial class Form_EmployeesPayroll : Form
    {
        public Form_EmployeesPayroll()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            if (txtID.Text == "")
            {
                MessageBox.Show("Input Employee's ID No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {

                    string sql = "Select * from tblEmployee where ID_No = '" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader reader = null;

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtname.Text = reader.GetValue(2).ToString();
                        txtposition.Text = reader.GetValue(6).ToString();
                        txtmsalary.Text = reader.GetValue(10).ToString();
                    }
                    else
                    {

                        MessageBox.Show("Record was not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1st")
            {
                
                decimal a, b=0.0363m, c=0.0m;
                var bi= decimal.TryParse(txtmsalary.Text,out a);
                if (bi) c = (a * b)/2;
                txtsss.Text = c.ToString("F");

                decimal a1, b1 = 0.03m, c1 = 0.0m;
                var bi1 = decimal.TryParse(txtmsalary.Text, out a1);
                if (bi1) c1 = (a1 * b1)/2;
                txtph.Text = c1.ToString("F");

                decimal a2, b2 = 0.02m, c2 = 0.0m;
                var bi2 = decimal.TryParse(txtmsalary.Text, out a2);
                if (bi2) c2 = (a2 * b2)/2;
                txtpi.Text = c2.ToString("F");

                decimal aa,bb,cc=0.0m;
                var cc1 = decimal.TryParse(txtsss.Text, out aa);
                var cc2 = decimal.TryParse(txtph.Text, out bb);
                var cc3 = decimal.TryParse(txtpi.Text, out cc);
                if (cc1 && cc2 && cc3) cc = aa + bb + cc;
                txttotal.Text = cc.ToString("F");

                


            }
            else
            {

                decimal a, b = 0.0363m, c = 0.0m;
                var bi = decimal.TryParse(txtmsalary.Text, out a);
                if (bi) c = (a * b) / 2;
                txtsss.Text = c.ToString("F");

                decimal a1, b1 = 0.03m, c1 = 0.0m;
                var bi1 = decimal.TryParse(txtmsalary.Text, out a1);
                if (bi1) c1 = (a1 * b1) / 2;
                txtph.Text = c1.ToString("F");

                decimal a2, b2 = 0.02m, c2 = 0.0m;
                var bi2 = decimal.TryParse(txtmsalary.Text, out a2);
                if (bi2) c2 = (a2 * b2) / 2;
                txtpi.Text = c2.ToString("F");

                decimal aa, bb, cc = 0.0m;
                var cc1 = decimal.TryParse(txtsss.Text, out aa);
                var cc2 = decimal.TryParse(txtph.Text, out bb);
                var cc3 = decimal.TryParse(txtpi.Text, out cc);
                if (cc1 && cc2 && cc3) cc = aa + bb + cc;
                txttotal.Text = cc.ToString("F");



            }
        }
        public void text_clear()
        {
            txtID.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtmsalary.Text = "";
            txtdr.Text = "";
            txthr.Text = "";
            txttotal.Text = "";
            textBox8.Text = "";
            txtsss.Text = "";
            txtph.Text = "";
            txtearn.Text = "";
            txtdeduct.Text = "";
            txtnet.Text = "";
            txtot.Text = "";
            txtpi.Text = "";
            txtwd.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text="";
            textBox8.Text="";



        }

        private void txtmsalary_TextChanged(object sender, EventArgs e)
        {
           
            decimal a, b = 26.0m, c = 0.0m;
            var bi = decimal.TryParse(txtmsalary.Text, out a);
            if (bi) c = a / b; ;
            txtdr.Text = c.ToString("F");
            decimal a1, b1 = 8, c1 = 0.0m;
            var bi1 = decimal.TryParse(txtdr.Text, out a1);
            if (bi1) c1 = a1 / b1; ;
            txthr.Text = c1.ToString("F");
        }

        private void Form9_Load(object sender, EventArgs e)
        {

            disp_data();
            // TODO: This line of code loads data into the 'tblPayrollDataSet.tblPayroll' table. You can move, or remove it, as needed.
            this.tblPayrollTableAdapter.Fill(this.tblPayrollDataSet.tblPayroll);


            //this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            decimal a, b=60, c = 0.0m,d;
            var bi = decimal.TryParse(txthr.Text, out a);
            var bi1 = decimal.TryParse(textBox8.Text, out d);
            if (bi && bi1) c = (a / b)*d;
            textBox3.Text = c.ToString("F");

            decimal a1, b1 = 60, c1 = 0.0m;
            var bi2 = decimal.TryParse(txttotal.Text, out a1);
            var bi11 = decimal.TryParse(textBox8.Text, out b1);
            if (bi2 && bi11) c1= a1+ b1;
            txtdeduct.Text = c1.ToString("F");

            decimal a2, b2, c2 = 0.0m;
            var bi3 = decimal.TryParse(txtearn.Text, out a2);
            var bi113 = decimal.TryParse(txtdeduct.Text, out b2);
            if (bi2 && bi11) c2 = a2 - b2;
            txtnet.Text = c2.ToString("F");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            decimal a, b, c = 0.0m;
            var bi = decimal.TryParse(txtdr.Text, out a);
            var bo = decimal.TryParse(txtwd.Text, out b);
            if (bi && bo) c = a * b;
            textBox1.Text = c.ToString("F");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtID.Text == "")
            {
                MessageBox.Show("Input Employee's ID No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else                 
            {

                SqlCommand cmd = new SqlCommand("Select * from tblPayroll where ID_No = '"+txtID.Text+"'and From1 = '" + dateTimePicker1.Value + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Already Input the data from" + dateTimePicker1.Value + " to " + dateTimePicker2.Value + "", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    try
                    {
                        string sql = "INSERT INTO tblPayroll (ID_No,Name,Position,M_Salary,CutOff,From1,To1,Tw_Days,Tm_Late,Ot,sss,pagibig,philhealth,others,daily_Rate,Hour_Rate,benefits,total_earnings,total_deduct,net_salary) values ('" + txtID.Text + "','" + txtname.Text + "','" + txtposition.Text + "','" + txtmsalary.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + txtwd.Text + "','" + textBox8.Text + "','" + txtot.Text + "','" + txtsss.Text + "','" + txtpi.Text + "','" + txtph.Text + "','" + textBox7.Text + "','" + txtdr.Text + "','" + txthr.Text + "','" + txttotal.Text + "','" + txtearn.Text + "','" + txtdeduct.Text + "','" + txtnet.Text + "')";
                        SqlCommand exesql = new SqlCommand(sql, cnn);
                        exesql.ExecuteNonQuery();
                     
                        disp_data();
                        text_clear();

                        MessageBox.Show("Payroll Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


                }
        }
        public void disp_data()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tblPayroll";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();


        }
        private void txtearn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            decimal a, b, c = 0.0m;
            var bi = decimal.TryParse(txthr.Text, out a);
            var bo = decimal.TryParse(txtot.Text, out b);
            if (bi && bo) c = a * b;
           textBox2.Text = c.ToString("F");

           decimal a1, b1, c1 = 0.0m;
           var bi1 = decimal.TryParse(textBox1.Text, out a1);
           var bo1 = decimal.TryParse(textBox2.Text, out b1);
           if (bi1 && bo1) c1 = a1 + b1;
           txtearn.Text = c1.ToString("F");
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            decimal aa, bb, cc = 0.0m;
            var cc1 = decimal.TryParse(textBox7.Text, out aa);
            var cc2 = decimal.TryParse(txttotal.Text, out bb);
            
            if (cc1 && cc2) cc = aa + bb;
            txttotal.Text = cc.ToString("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViewPayroll f2 = new Form_ViewPayroll();
            f2.Show();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button2_Click(object sender, EventArgs e)
        {
             string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                try
                {
                    string sql = "Delete from tblPayroll where ID_No = '" + txtID.Text + "'  and From1='"+dateTimePicker1.Value+"'";
                    SqlCommand exesql = new SqlCommand(sql, cnn);
                    exesql.ExecuteNonQuery();
                    cnn.Close();
                    disp_data();
                    text_clear();
                    MessageBox.Show("Employee Payroll Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViewPayslip f2 = new Form_ViewPayslip();
            f2.Show();
        }
        }


    }

