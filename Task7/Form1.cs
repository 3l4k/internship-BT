namespace Task7
{
    public partial class Form1 : Form
    {
        char c1 = '*';
        char c2 = '/';
        char c3 = '+';
        char c4 = '-';
        char c5 = '=';
        decimal entry1=0;
        decimal entry2=0;
        decimal ans;
        string display,function;
        double root;
        public Form1()
        {
            InitializeComponent();
          //  txt1.Text = "0";
            //txt2.Text = "0";
            txt2.Visible = false;
            btn8.Enabled = false;
            lblGuide.Text = "Type a number";
            disable_Functions();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            txt1.Focus();
        }

        public void disable_Functions()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
        }
        public void enable_Functions()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            string s;
            s = txt1.Text;
            foreach (char tt1 in txt1.Text)
            {
                if (tt1 == c1)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt1.Text = s;
                    btn1.PerformClick();
                    break;
                }
                if (tt1 == c2)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt1.Text = s;
                    btn2.PerformClick();
                    break;
                }
                if (tt1 == c3)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt1.Text = s;
                    btn3.PerformClick();
                    break;
                }
                if (tt1 == c4)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt1.Text = s;
                    btn4.PerformClick();
                    break;
                }
                if(tt1 == c5)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt1.Text = s;
                    MessageBox.Show("That operations can't be entered here");
                }
            }
           // disable_Functions();
           if(txt1.Text == "")
            {
                disable_Functions();
            }
            else
            {
                enable_Functions();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            string s;
            s = txt2.Text;
            foreach (char tt1 in txt2.Text)
            {
                if (tt1 == c1 || tt1 == c2 || tt1 == c3 || tt1 == c4)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt2.Text = s;
                    MessageBox.Show("Operations can't be entered here");
                    break;
                }
                if (tt1 == c5)
                {
                    s = s.Substring(0, s.Length - 1);
                    txt2.Text = s;
                    btn8.PerformClick();
                    break;
                }
            }
            if (txt2.Text == "")
            {
                btn8.Enabled = false;
            }
            else
            {
                btn8.Enabled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                entry1 = decimal.Parse(txt1.Text);
                txt1.Text = "";
                display = entry1.ToString() + " X ";
                lblShow.Text = display;
                txt2.Visible = true;
                txt1.Visible = false;
                txt2.Focus();
                function = "a";
                lblGuide.Text = "Type in the next number to complete the calculation\nOperations can't be inputed here";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input must be a number\nDo well to follow the guide");
                txt1.Focus();

            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            try
            {
                entry1 = decimal.Parse(txt1.Text);
                txt1.Text = "";
                display = entry1.ToString() + " / ";
                lblShow.Text = display;
                txt2.Visible = true;
                txt1.Visible = false;
                txt2.Focus();
                function = "b";
                lblGuide.Text = "Type in the next number to complete the calculation\nOperations can't be inputed here";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input must be a number\nDo well to follow the guide");
                txt1.Focus();

            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            try
            {
                entry1 = decimal.Parse(txt1.Text);
                txt1.Text = "";
                display = entry1.ToString() + " + ";
                lblShow.Text = display;
                txt2.Visible = true;
                txt1.Visible = false;
                txt2.Focus();
                function = "c";
                lblGuide.Text = "Type in the next number to complete the calculation\nOperations can't be inputed here";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input must be a number\nDo well to follow the guide");
                txt1.Focus();

            }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            try
            {
                entry1 = decimal.Parse(txt1.Text);
                txt1.Text = "";
                display = entry1.ToString() + " - ";
                lblShow.Text = display;
                txt2.Visible = true;
                txt1.Visible = false;
                txt2.Focus();
                function = "d";
                lblGuide.Text = "Type in the next number to complete the calculation\nOperations can't be inputed here";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input must be a number\nDo well to follow the guide");
                txt1.Focus();
            }
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            try
            {
                root = Math.Pow(double.Parse(txt1.Text), 0.5);
                display = "sqrt(" + txt1.Text + ") = " + root.ToString();
                txt1.Text = "";
                lblShow.Text = display;
                txt1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input must be a number\nDo well to follow the guide");
                txt1.Focus();
            }
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            try
            {
                ans = decimal.Parse(txt1.Text);
                ans *= ans;
                display = txt1.Text + "^2 = " + ans;
                txt1.Text = "";
                lblShow.Text = display;
                txt1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input must be a number\nDo well to follow the guide");
                txt1.Focus();
            }
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            lblShow.Text = "...";
            txt1.Text = "";
            txt2.Text = "";
            txt1.Visible = true;
            txt2.Visible = false;
            btn8.Enabled = false;
            lblGuide.Text = "Type a number";
            txt1.Focus();
            disable_Functions();
        }



        private void btn8_Click_1(object sender, EventArgs e)
        {
            try
            {
                entry2 = decimal.Parse(txt2.Text);
                txt2.Text = "";
                switch (function)
                {
                    case "a":
                        ans = entry1 * entry2;
                        display = entry1.ToString() + " X " + entry2.ToString() + " = " + ans.ToString();

                        break;
                    case "b":
                        ans = entry1 / entry2;
                        display = entry1.ToString() + " / " + entry2.ToString() + " = " + ans.ToString();

                        break;
                    case "c":
                        ans = entry1 + entry2;
                        display = entry1.ToString() + " + " + entry2.ToString() + " = " + ans.ToString();

                        break;
                    case "d":
                        ans = entry1 - entry2;
                        display = entry1.ToString() + " - " + entry2.ToString() + " = " + ans.ToString();

                        break;
                    default:
                        break;
                }
                lblShow.Text = display;
                txt2.Visible = false;
                txt1.Visible = true;
                txt1.Focus();
                lblGuide.Text = "Type in any number";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDo well to follow the guide");
                txt2.Focus();
            }
        }
    }
}