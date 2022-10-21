using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sope
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();


        string name, city, address, phone, facebook, image, website, description, talent;
        string genre;
        string state;
        int saved = 0;

        

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenre.Items.Add("Alternative");
            cmbGenre.Items.Add("Blues");
            cmbGenre.Items.Add("Classical");
            cmbGenre.Items.Add("Country");
            cmbGenre.Items.Add("Electronic");
            cmbState.Items.Add("PortHacourt");
            cmbState.Items.Add("Lagos");
            cmbState.Items.Add("Abuja");
            cmbState.Items.Add("Calabar");
            cmbState.Items.Add("Enugu");
            dtDataGridView.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saved += 1;
            dtDataGridView.Visible = true;
            name = txtName.Text;
            city = txtCity.Text;
            state = cmbState.SelectedItem.ToString();
            address = txtAddress.Text;
            phone = txtPhone.Text;
            genre = cmbGenre.SelectedItem.ToString();
            facebook = txtFbk.Text;
            image = txtImg.Text;
            website = txtWww.Text;
            description = txtDescription.Text;
            if (chkTalent.Checked)
            {
                talent = "Yes";
            }
            else
            {
                talent = "No";
            }
            if (saved < 2)
            {
                display();
            }

            display2();

            //MessageBox.Show("Venture created and genre is "+genre);
        }

        public void display()
        {
            dt.Columns.Add("ID ");
            dt.Columns.Add("Name ");
            dt.Columns.Add("City ");
            dt.Columns.Add("State ");
            dt.Columns.Add("Address ");
            dt.Columns.Add("Phone ");
            dt.Columns.Add("Genre ");
            dt.Columns.Add("Description ");
        }
        public void display2()
        {
            DataRow dr = dt.NewRow();
            dr[0] = saved;
            dr[1] = name;
            dr[2] = city;
            dr[3] = state;
            dr[4] = address;
            dr[5] = phone;
            dr[6] = genre;
            dr[7] = description;

            dt.Rows.Add(dr);
            dtDataGridView.DataSource = dt;
        }

        private void txtCity_MouseClick(object sender, MouseEventArgs e)
        {
            txtCity.Text = "";
            txtCity.ForeColor = Color.Black;
        }
        private void txtPhone_MouseClick(object sender, MouseEventArgs e)
        {
            txtPhone.Text = "";
            txtPhone.ForeColor = Color.Black;
        }

        private void txtDescription_MouseClick(object sender, MouseEventArgs e)
        {
            txtDescription.Text = "";
            txtDescription.ForeColor = Color.Black;
        }
        private void txtFbk_MouseClick(object sender, MouseEventArgs e)
        {
            txtFbk.ForeColor = Color.Black;
        }

        private void txtImg_MouseClick(object sender, MouseEventArgs e)
        {
            txtImg.ForeColor = Color.Black;
        }

        private void txtWww_MouseClick(object sender, MouseEventArgs e)
        {
            txtWww.ForeColor = Color.Black;
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}