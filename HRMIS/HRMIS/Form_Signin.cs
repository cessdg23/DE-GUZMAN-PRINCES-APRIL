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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Signup f2 = new Form_Signup();
            f2.Show();
            
            linkLabel1.LinkVisited = true;
        }

        private void login_Load(object sender, EventArgs e)
        {
         
        }

        private void signin_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ITECH\Desktop\HRMIS PA\HRMIS\HRMIS\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (txtuname.Text == "")
            {
                MessageBox.Show("Input your Username or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpword.Text == "")
            {
                MessageBox.Show("Input your Username or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                try
                {
                    
                   string sql="Select * from tblAccount where uname = '" + txtuname.Text + "'and pword = '" + txtpword.Text + "'";
                   SqlCommand cmd = new SqlCommand(sql, cnn);
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   if (dt.Rows.Count > 0)
                   {
                       MessageBox.Show("Login sucessfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       this.Hide();
                       Form_AdminSetting f2 = new Form_AdminSetting(txtuname.Text);
                       f2.ShowDialog(); 
                   }
                   else
                   {
                       MessageBox.Show("Invalid Login please check username and password","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   }
                   
                   
                   cnn.Close();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



            
        }
    }
}
