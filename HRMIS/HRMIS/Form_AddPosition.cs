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
    public partial class Form_AddPosition : Form
    {
        public Form_AddPosition()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddEmployee f2 = new Form_AddEmployee();
            f2.Show();

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
            cmd.CommandText = "Select * from tblPosition";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            if (txtposition.Text == "")
            {
                MessageBox.Show("Input School Position", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtdate.Text == "")
            {
                MessageBox.Show("Input School Position", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                SqlCommand cmd = new SqlCommand("Select * from tblPosition where Position = '" + txtposition.Text + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Position: " + txtposition.Text + " is already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_clear();

                }
                else
                {

                try
                {
                    string sql = "INSERT INTO tblPosition (Position,Date) values ('" + txtposition.Text + "','" + txtdate.Text + "')";
                    SqlCommand exesql = new SqlCommand(sql, cnn);
                    exesql.ExecuteNonQuery();
                    cnn.Close();
                    disp_data();
                    text_clear();
                    MessageBox.Show("Position is Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
             
            }
            }
        }
        public void text_clear()
        {
            txtposition.Text = "";
            txtdate.Text = "";
           



        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form_AdminSetting f2 = new Form_AdminSetting(label3.Text);
            f2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddPosition f2 = new Form_AddPosition();
            f2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtposition.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void Form_AddPosition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tblPositionDataSet.tblPosition' table. You can move, or remove it, as needed.
            disp_data();
            this.tblPositionTableAdapter.Fill(this.tblPositionDataSet.tblPosition);

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
                    string sql = "Delete from tblPosition where Position= '" + txtposition.Text + "'";
                    SqlCommand exesql = new SqlCommand(sql, cnn);
                    exesql.ExecuteNonQuery();
                    cnn.Close();
                    disp_data();
                    text_clear();
                    MessageBox.Show("Position Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtposition.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

