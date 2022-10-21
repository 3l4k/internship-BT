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
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace task10
{
    public partial class Form1 : Form
    {
        //string connection
        string path = "Data Source=DESKTOP-KHBO368;Initial Catalog=registration2;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        string date;
        char[] charArray;

        public Form1()
        {
            InitializeComponent();
            disable();
            conn = new SqlConnection(path);
            dateTimePicker2.Visible = false;
            lblDate.Visible = false;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtUName.Text==""||txtEmail.Text==""||txtPass.Text==""||txtCPass.Text!=txtPass.Text||txtName.Text==""||txtFamily.Text==""||txtPhone.Text==""||txtMobile.Text==""||txtBDate.Text==""||txtBPlace.Text==""||lblDate.Visible==true)
            {
                MessageBox.Show("PLEASE FILL IN THE BLANKS\n CONFIRM THAT PASSWORD IS THE SAME AS CONFIRM PASSWORD\nAnd ensure you selected a date");
            }
            else
            {
                try
                {
                    conn.Open();
                    //cmd = new SqlCommand("insert into Player (Username,Email,Pssword,Name,Family,Phone,Mobile,Birth_Date,Birth_Place) values ('" + txtUName.Text+ "','"+txtEmail.Text+ "','"+txtPass.Text+ "','"+txtName.Text+ "','"+txtFamily.Text+ "','"+txtPhone.Text+ "','"+txtMobile.Text+ "','"+txtBDate.Text+ "','"+txtBPlace.Text+"')", conn);
                    cmd = new SqlCommand("insert into Players values ('" + txtUName.Text+ "','"+txtEmail.Text+ "','"+txtPass.Text+ "','"+txtName.Text+ "','"+txtFamily.Text+ "','"+txtPhone.Text+ "','"+txtMobile.Text+ "','"+txtBDate.Text+ "','"+txtBPlace.Text+"')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your Data has Been Saved in the Database");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search sch = new Search();
            sch.Show();
            this.Hide();
        }





        //Extras
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Silver);
            e.Graphics.DrawLine(pen, 22, 100, 740, 100);
            e.Graphics.DrawLine(pen, 22, 423, 740, 423);
            e.Graphics.DrawLine(pen, 22, 615, 740, 615);
        }
        public void disable()
        {
            button2.Enabled = false;
            buttonp.Enabled = false;
        }

        public void clear()
        {
            txtUName.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtCPass.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";
            txtPhone.Text = "";
            txtMobile.Text = "";
            txtBDate.Text = "";
            txtBPlace.Text = "";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string time = "";
            txtBDate.Text = dateTimePicker2.Value.ToString();
            date = txtBDate.Text;
            charArray = date.ToCharArray();
            foreach(char c in charArray)
            {
                if(c==' ')
                {
                    break;
                }
                else
                {
                    time += c;
                }
            }
            txtBDate.Text = time;
            dateTimePicker2.Visible = false;
            lblDate.Visible = false;
        }

        private void txtBDate_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            lblDate.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            lblDate.Visible = true;
        }

        private void txtBDate_Enter(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            lblDate.Visible = true;
        }

        private void txtBDate_Leave(object sender, EventArgs e)
        {
            string time = "";
            date = dateTimePicker2.Value.ToString();
            charArray = date.ToCharArray();
            foreach (char c in charArray)
            {
                if (c == ' ')
                {
                    break;
                }
                else
                {
                    time += c;
                }
            }
            if(txtBDate.Text != time)
            {
                txtBDate.Text = time;
                dateTimePicker2_ValueChanged(sender, e);
            }
            
            //dateTimePicker2.Visible = false;
        }

        private void btnsee1_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                lblsee1.Text = "Hide Password";
            }
            else
            {
                txtPass.PasswordChar = '*';
                lblsee1.Text = "Show Password";
            }
            txtPass.Focus();
        }

        private void btnsee2_Click(object sender, EventArgs e)
        {
            if (txtCPass.PasswordChar == '*')
            {
                txtCPass.PasswordChar = '\0';
                lblsee2.Text = "Hide Password";
            }
            else
            {
                txtCPass.PasswordChar = '*';
                lblsee2.Text = "Show Password";
            }
            txtCPass.Focus();
        }

        private void btnsee1_MouseHover(object sender, EventArgs e)
        {

            lblsee1.Visible = true;
        }

        private void btnsee1_MouseLeave(object sender, EventArgs e)
        {
            lblsee1.Visible = false;
        }

        private void btnsee2_MouseHover(object sender, EventArgs e)
        {
            lblsee2.Visible = true;
        }

        private void btnsee2_MouseLeave(object sender, EventArgs e)
        {
            lblsee2.Visible = false;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            btnsee1.Visible = true;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (!btnsee1.Focused)
            {
               btnsee1.Visible = false;
            }
        }

        private void txtCPass_Enter(object sender, EventArgs e)
        {
            btnsee2.Visible = true;
        }

        private void txtCPass_Leave(object sender, EventArgs e)
        {
            if (!btnsee2.Focused)
            {
                btnsee2.Visible = false;
            }
        }
    }
}