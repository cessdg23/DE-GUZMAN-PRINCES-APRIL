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
    public partial class Form_AdminSetting : Form
    {
        public Form_AdminSetting(string Str_Value)
        {
            InitializeComponent();
            label3.Text = Str_Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcpass.Visible = true;
            label14.Visible = true;
            button2.Visible = true;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddPosition f2 = new Form_AddPosition();
            f2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_AddEmployee f2 = new Form_AddEmployee();
            f2.Show();
        }

        private void Form_AdminSetting_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database1DataSet4.tblAccount' table. You can move, or remove it, as needed.
            this.tblAccountTableAdapter.Fill(this.database1DataSet4.tblAccount);
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string sql = "Select * from tblAccount where uname = '" + label3.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlDataReader reader = null;

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtcompname.Text = reader.GetValue(1).ToString();
                txtcompadd.Text = reader.GetValue(2).ToString();
                comboBox1.Text = reader.GetValue(3).ToString();
                txtuname.Text = reader.GetValue(4).ToString();
                txtpword.Text = reader.GetValue(5).ToString();
                txtcpass.Text = reader.GetValue(6).ToString();
                txtID.Text = reader.GetValue(7).ToString();




            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtcpass.Text == txtpword.Text)
            {

                try
                {
                    string sql = "Update tblAccount set name = '" + txtcompname.Text + "', address='" + txtcompadd.Text + "', position = '" + comboBox1.Text + "', uname = '" + txtuname.Text + "',pword='" + txtpword.Text + "',confirmpword ='" + txtcpass.Text + "' where Id_no='" + txtID.Text + "'";
                    SqlCommand exesql = new SqlCommand(sql, cnn);
                    exesql.ExecuteNonQuery();
                    cnn.Close();
                    Form_AdminSetting_Load(sender, e);
                    MessageBox.Show("Account Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EmployeesPayroll f2 = new Form_EmployeesPayroll();
            f2.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AdminSetting f2 = new Form_AdminSetting(label3.Text);
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

