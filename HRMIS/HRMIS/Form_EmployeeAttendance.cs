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
    public partial class Form_EmployeeAttendance : Form
    {
        public Form_EmployeeAttendance()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet9.tblDailyAttendance' table. You can move, or remove it, as needed.
            this.tblDailyAttendanceTableAdapter.Fill(this.database1DataSet9.tblDailyAttendance);
            // TODO: This line of code loads data into the 'database1DataSet8.tblDailyAttendance' table. You can move, or remove it, as needed.
            this.tblDailyAttendanceTableAdapter1.Fill(this.database1DataSet8.tblDailyAttendance);
            disp_data();
            // TODO: This line of code loads data into the 'database1DailyAttendance.tblDailyAttendance' table. You can move, or remove it, as needed.
           
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                    }
                    else
                    {

                        MessageBox.Show("Record was not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cnn.Close();
            }

        }
        public void text_clear()
        {
            txtID.Text = "";
            txtname.Text = "";
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
            cmd.CommandText = "Select * from tblDailyAttendance";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();


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
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from tblDailyAttendance where ID_No='" + txtID.Text + "' and Date='" + dateTimePicker1.Value +"'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                   
                    MessageBox.Show("Your Morning Time In is already recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    try
                    {

                        string sql = "INSERT INTO tblDailyAttendance (ID_No,Name,Date,AM_TimeIn) values ('" + txtID.Text + "','" + txtname.Text + "','" + dateTimePicker1.Value + "','" + label1.Text + "')";
                        SqlCommand exesql = new SqlCommand(sql, cnn);
                        exesql.ExecuteNonQuery();
                        MessageBox.Show("Morning Time In: " + label1.Text + ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disp_data();
                        text_clear();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtID.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from tblDailyAttendance where ID_No='" + txtID.Text + "' and Date='" + dateTimePicker1.Value + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    try
                    {

                        string sql = "Update tblDailyAttendance set AM_TimeOut = '" + label1.Text + "' where Date='"+dateTimePicker1.Value+"' and ID_No='"+txtID.Text+"'";
                        SqlCommand exesql = new SqlCommand(sql, cnn);
                        exesql.ExecuteNonQuery();
                        cnn.Close();
                        disp_data();
                        text_clear();
                        MessageBox.Show("Morning Time Out recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {

                    MessageBox.Show("Your Morning Time Out is already recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtID.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from tblDailyAttendance where ID_No='" + txtID.Text + "' and Date='" + dateTimePicker1.Value + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    try
                    {

                        string sql = "Update tblDailyAttendance set PM_TimeIn = '" + label1.Text + "'where Date='"+dateTimePicker1.Value+"'and ID_No='"+txtID.Text+"'";
                        SqlCommand exesql = new SqlCommand(sql, cnn);
                        exesql.ExecuteNonQuery();
                        cnn.Close();
                        disp_data();
                        text_clear();
                        MessageBox.Show("Afternoon Time Out recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Your Afternoon Time In is already recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtID.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from tblDailyAttendance where ID_No='" + txtID.Text + "' and Date='" + dateTimePicker1.Value + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    try
                    {

                        string sql = "Update tblDailyAttendance set PM_TimeOut = '" + label1.Text + "'where Date='"+dateTimePicker1.Value+"' and ID_No='"+txtID.Text+"'";
                        SqlCommand exesql = new SqlCommand(sql, cnn);
                        exesql.ExecuteNonQuery();
                        cnn.Close();
                        disp_data();
                        text_clear();
                        MessageBox.Show("Afternoon Time Out recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {

                    MessageBox.Show("Your Afternoon Time Out is already recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
          login f2 = new login();
            f2.Show();

            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ViewPayroll f2 = new Form_ViewPayroll();
            f2.Show();

            linkLabel1.LinkVisited = true;
        }
    }
}
