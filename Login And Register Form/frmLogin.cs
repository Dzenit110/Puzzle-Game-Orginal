using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Login_And_Register_Form
    
{
    public partial class frmLogin : Form
    {
       
       
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F59JTTH\\SQLEXPRESS;Initial Catalog=puzzleoyunu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        
        private void button1_Click(object sender, EventArgs e)
        {
             
            
            string login = "SELECT * FROM tbl_users WHERE username= '" + kullaniciadi.Text + "' and password= '" + sifre.Text + "'";
            cmd = new SqlCommand(login, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                dashboard frm = new dashboard();
                frm.kullanici = kullaniciadi.Text;
                frm.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password, please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kullaniciadi.Text = "";
                sifre.Text = "";
                kullaniciadi.Focus();
            }
            con.Close();
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciadi.Text = "";
            sifre.Text = "";
            kullaniciadi.Focus();
        }

        private void chckbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxPassword.Checked)
            {
                sifre.PasswordChar = '\0';
              
            }
            else
            {
                sifre.PasswordChar = '*';
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new registerForm().Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
