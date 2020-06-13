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
    public partial class Form_Signup : Form
    {
        public Form_Signup()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtadd.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtname.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtpword.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtuname.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtcpword.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtposition.Text == "")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ( txtID.Text=="")
            {
                MessageBox.Show("Input your Personal Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                SqlCommand cmd = new SqlCommand("Select * from tblAccount where uname = '" + txtuname.Text + "'", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Username:" + txtuname.Text + " is already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {

                    if (txtcpword.Text == txtpword.Text)
                    {


                        try
                        {
                            string sql = "INSERT INTO tblAccount (name,address,position,uname,pword,confirmpword,Id_no) values ('" + txtname.Text + "','" + txtadd.Text + "','" + txtposition.Text + "','" + txtuname.Text + "','" + txtpword.Text + "','" + txtcpword.Text + "','"+txtID.Text+"')";
                            SqlCommand exesql = new SqlCommand(sql, cnn);
                            exesql.ExecuteNonQuery();
                            MessageBox.Show("Account Registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Hide();
                        login f2 = new login();
                        f2.Show();

                    }

                    else
                    {
                        MessageBox.Show("Password not Match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login f2 = new login();
            f2.Show();
            
            linkLabel1.LinkVisited = true;
        }
    }
}
