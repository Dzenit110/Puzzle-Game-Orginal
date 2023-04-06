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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();

            

        }

        SqlConnection con= new SqlConnection("Data Source=DESKTOP-F59JTTH\\SQLEXPRESS;Initial Catalog=puzzleoyunu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kullaniciadi.Text == "" && sifre.Text == "" && sifretekrar.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sifre.Text == sifretekrar.Text)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_users (username,password) values (@p1,@p2)", con);
                komut.Parameters.AddWithValue("@p1", kullaniciadi.Text);
                komut.Parameters.AddWithValue("@p2", sifre.Text);
                komut.ExecuteNonQuery();
                con.Close();

                kullaniciadi.Text = "";
                sifre.Text = "";
                sifretekrar.Text = "";

                MessageBox.Show("Your account has been successfully created", "Registration Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter the password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sifre.Text = "";
                sifretekrar.Text = "";
                sifre.Focus();
            }
        }

        private void chckbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chckbxPassword.Checked)
            {
                sifre.PasswordChar = '\0';
                sifretekrar.PasswordChar = '\0';
            }
            else
            {
                sifre.PasswordChar = '*';
                sifretekrar.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciadi.Text = "";
            sifre.Text = "";
            sifretekrar.Text = "";

            kullaniciadi.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
