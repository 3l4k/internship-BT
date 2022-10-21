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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace task10
{
    public partial class Search : Form
    {
        //string connection
        string path = "Data Source=DESKTOP-KHBO368;Initial Catalog=registration2;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID, ID2;
        public Search()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            //disable();
            conn = new SqlConnection(path);
            display();
            groupBox4.Visible = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adpt = new SqlDataAdapter("select * from Players", conn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtUName2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPass2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtName2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtFamily2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPhone2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMobile2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBDate2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtBPlace2.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            groupBox4.Visible = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("update Players set Username='" + txtUName2.Text + "', Email='" + txtEmail2.Text + "', Pssword='" + txtPass2.Text + "', Name='" + txtName2.Text + "', Family='" + txtFamily2.Text + "', Phone='" + txtPhone2.Text + "', Mobile='" + txtMobile2.Text + "', Birth_Date='" + txtBDate2.Text + "', Birth_Place='" + txtBPlace2.Text + "' where Player_Id='" + ID + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("YOUR DATA HAS BEEN UPDATED");
                txtPC.Text = "";
                txtSearch.Text = txtUName2.Text;
                txtPC.Text = txtPass2.Text;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                groupBox4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("delete from Players where Player_Id='" + ID + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("YOUR DATA HAS BEEN DELETED");
                clear();
                txtSearch.Text = "";
                txtPC.Text = "";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                groupBox4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (txtPC.Text == "1111" && txtSearch.Text == "Lotanna")
            {
                display();
            }
            else
            {
                MessageBox.Show("Enter classified username and password");
            }
        }

        public void clear()
        {
            txtUName2.Text = "";
            txtEmail2.Text = "";
            txtPass2.Text = "";
            txtName2.Text = "";
            txtFamily2.Text = "";
            txtPhone2.Text = "";
            txtMobile2.Text = "";
            txtBDate2.Text = "";
            txtBPlace2.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            adpt = new SqlDataAdapter("select * from Players where Username = '" + txtSearch.Text + "' ", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() == txtPC.Text && i < dataGridView1.Rows.Count)
                    {
                        ID2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        break;
                    }
                    else
                    {
                        dataGridView1.Visible = false;
                        ID2 = 0;
                    }
                }
                if (ID2 > 0)
                {
                    conn.Open();
                    adpt = new SqlDataAdapter("select * from Players where Player_ID = '" + ID2 + "'", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    dataGridView1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Wrong Username or password");
                    txtSearch.Text = "";
                    txtPC.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtPC_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            adpt = new SqlDataAdapter("select * from Players where Pssword = '" + txtPC.Text + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            dataGridView1.Visible = true;
            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txtSearch.Text && i < dataGridView1.Rows.Count)
                    {
                        ID2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        break;
                    }
                    else
                    {
                        dataGridView1.Visible = false;
                        ID2 = 0;
                    }
                }
                if (ID2 > 0)
                {
                    conn.Open();
                    adpt = new SqlDataAdapter("select * from Players where Player_ID = '" + ID2 + "'", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    dataGridView1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Wrong Username or password");
                    txtSearch.Text = "";
                    txtPC.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
