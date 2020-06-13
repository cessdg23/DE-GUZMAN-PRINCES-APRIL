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

namespace WindowsFormsApplication1
{
    public partial class Form_AddEmployee : Form
    {
        public Form_AddEmployee()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            disp_data();
            // TODO: This line of code loads data into the 'database1DataSet3position.tblPosition' table. You can move, or remove it, as needed.
            this.tblPositionTableAdapter.Fill(this.database1DataSet3position.tblPosition);
            // TODO: This line of code loads data into the 'database1DataSet3employee.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.database1DataSet3employee.tblEmployee);
            // TODO: This line of code loads data into the 'database1tblEmployee.tblEmployee' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'database1DataSet1.tblCompany' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            if (txtID.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtbday.Text== "" || txtposition.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtstatus.Text == "" || txtsalary.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtage.Text == "" || txtdh.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtcp.Text == "" || txtadd.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                SqlCommand cmd = new SqlCommand("Select * from tblEmployee where ID_No = '" + txtID.Text + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("ID No:" + txtID.Text + " is already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_clear();

                }
                else
                {



                    try
                    {
                        string sql = "INSERT INTO tblEmployee (ID_No,Name,Age,Bday,Address,Position,Date_Hired,Status,Cp_No,Salary) values ('" + txtID.Text + "','" + txtname.Text + "','" + txtage.Text + "','" + txtbday.Value + "','" + txtadd.Text + "','" + txtposition.Text + "','" + txtdh.Value + "','" + txtstatus.Text + "','" + txtcp.Text + "','" + txtsalary.Text + "')";
                        SqlCommand exesql = new SqlCommand(sql, cnn);
                        exesql.ExecuteNonQuery();
                        cnn.Close();
                        disp_data();
                        text_clear();

                        MessageBox.Show("Employee Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            cmd.CommandType =  CommandType.Text;
             cmd.CommandText= "Select * from tblEmployee";
             cmd.ExecuteNonQuery();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             cnn.Close();


        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtbday.Text == "" || txtposition.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtstatus.Text == "" || txtsalary.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtage.Text == "" || txtdh.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtcp.Text == "" || txtadd.Text == "")
            {
                MessageBox.Show("Input Employee's Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                try
                {
                    string sql = "Update tblEmployee set Name = '" + txtname.Text + "',Age ='" + txtage.Text + "' ,Bday='" + txtbday.Value + "',Address='" + txtadd.Text + "',Position='" + txtposition.Text + "',Date_Hired='" + txtdh.Value + "',Status='" + txtstatus.Text + "',Cp_No='" + txtcp.Text + "', Salary='"+txtsalary.Text+"' where ID_No='" + txtID.Text + "'";
                    SqlCommand exesql = new SqlCommand(sql, cnn);
                    exesql.ExecuteNonQuery();
                    cnn.Close();
                    disp_data();
                    text_clear();
                    MessageBox.Show("Employee Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        public void text_clear()
    {
        txtID.Text = "";
        txtname.Text = "";
        txtage.Text = "";
        txtbday.Text = "";
        txtadd.Text = "";
        txtposition.Text = "";
        txtdh.Text = "";
        txtstatus.Text = "";
        txtcp.Text = "";
        txtsalary.Text = "";
    }
        private void txtbday_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtage.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbday.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtposition.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtdh.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtcp.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtsalary.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                try
                {
                    string sql = "Delete from tblEmployee where ID_No = '" + txtID.Text + "'";
                    SqlCommand exesql = new SqlCommand(sql, cnn);
                    exesql.ExecuteNonQuery();
                    cnn.Close();
                    disp_data();
                    text_clear();
                    MessageBox.Show("Employee Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
      
    }

