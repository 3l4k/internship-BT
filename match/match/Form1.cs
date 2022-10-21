namespace match
{
    public partial class Form1 : Form
    {
        int clicks1 = 0, counter = 121;
        sbyte clicks2;
        int[] row = { 12, 194, 380 };
        int[] col = {14, 223, 432, 639};
        public Form1()
        {
            InitializeComponent();
            shuffler();
          //  MessageBox.Show("\t            Welcome to PICS MATCH.\n\t             _________________________\n\nOnce a picture is seleceted, it's match must be chosen next.\nYou have 3 minutes ti finish. Good Luck   ;)");
            timer5.Enabled = true;
        }

        public void randomizer()
        {
            Random random = new Random();
            //shuffler rows
            row = row.OrderBy(x => random.Next()).ToArray();

            //shuffler columns
            col = col.OrderBy(x => random.Next()).ToArray();
        }

        public void shuffler()
        {
            randomizer();
            //assign them to their shuffled locations
            btn1a.Location = new Point(col[0], row[0]);
            pb1a.Location = btn1a.Location;

            btn1b.Location = new Point(col[1], row[0]);
            pb1b.Location = btn1b.Location;

            btn1c.Location = new Point(col[2], row[0]);
            pb1c.Location = btn1c.Location;

            btn1d.Location = new Point(col[3], row[0]);
            pb1d.Location = btn1d.Location;

            btn1e.Location = new Point(col[0], row[1]);
            pb1e.Location = btn1e.Location;

            btn1f.Location = new Point(col[1], row[1]);
            pb1f.Location = btn1f.Location;

            btn2a.Location = new Point(col[2], row[1]);
            pb2a.Location = btn2a.Location;

            btn2b.Location = new Point(col[3], row[1]);
            pb2b.Location = btn2b.Location;

            btn2c.Location = new Point(col[0], row[2]);
            pb2c.Location = btn2c.Location;

            btn2d.Location = new Point(col[1], row[2]);
            pb2d.Location = btn2d.Location;

            btn2e.Location = new Point(col[2], row[2]);
            pb2e.Location = btn2e.Location;

            btn2f.Location = new Point(col[3], row[2]);
            pb2f.Location = btn2f.Location;
        }

        private void btn1a_Click(object sender, EventArgs e)
        {
            btn1a.Visible = false;
            clicks1++;
            pb1a.Visible = true;
            clicks2 = 1;

            timer2.Enabled = true;
        }

        private void btn1b_Click(object sender, EventArgs e)
        {
            btn1b.Visible = false;
            clicks1++;
            pb1b.Visible = true;
            clicks2 = 2;

            timer2.Enabled = true;
        }

        private void btn1c_Click(object sender, EventArgs e)
        {
            btn1c.Visible = false;
            clicks1++;
            pb1c.Visible = true;
            clicks2 = 3;

            timer2.Enabled = true;
        }

        private void btn1d_Click(object sender, EventArgs e)
        {
            btn1d.Visible = false;
            clicks1++;
            pb1d.Visible = true;
            clicks2 = 4;

            timer2.Enabled = true;
        }

        private void btn2c_Click(object sender, EventArgs e)
        {
            btn2c.Visible = false;
            clicks1++;
            pb2c.Visible = true;
            clicks2 = 5;

            timer2.Enabled = true;
        }

        private void btn2d_Click(object sender, EventArgs e)
        {
            btn2d.Visible = false;
            clicks1++;
            pb2d.Visible = true;
            clicks2 = 6;

            timer2.Enabled = true;
        }

        private void btn2a_Click(object sender, EventArgs e)
        {
            btn2a.Visible = false;
            clicks1++;
            pb2a.Visible = true;
            clicks2 = 7;

            timer2.Enabled = true;
        }

        private void btn1e_Click(object sender, EventArgs e)
        {
            btn1e.Visible = false;
            clicks1++;
            pb1e.Visible = true;
            clicks2 = 8;

            timer2.Enabled = true;
        }

        private void btn1f_Click(object sender, EventArgs e)
        {
            btn1f.Visible = false;
            clicks1++;
            pb1f.Visible = true;
            clicks2 = 9;

            timer2.Enabled = true;
        }

        private void btn2e_Click(object sender, EventArgs e)
        {
            btn2e.Visible = false;
            clicks1++;
            pb2e.Visible = true;
            clicks2 = 10;

            timer2.Enabled = true;
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            btn2b.Visible = false;
            clicks1++;
            pb2b.Visible = true;
            clicks2 = 11;

            timer2.Enabled = true;
        }

        private void btn2f_Click(object sender, EventArgs e)
        {
            btn2f.Visible = false;
            clicks1++;
            pb2f.Visible = true;
            clicks2 = 12;

            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //end quiz
            if (pb1a.Visible && pb1b.Visible && pb1c.Visible && pb1d.Visible && pb1e.Visible && pb1f.Visible && pb2a.Visible && pb2b.Visible && pb2c.Visible && pb2d.Visible && pb2e.Visible && pb2f.Visible)
            {
                clicks2 = -1;
                timer1.Interval = 100000;
                end();
            }
            //cant click again
            if (timer2.Enabled == true)
            {
                disable();
            }
            else
            {
                enable();
            }

        }

        public void end()
        {
            if (clicks2 == -1)
            {
                timer5.Enabled = false;
                MessageBox.Show("You've matched everything :)");
                Close();
            }

        }

        public void disable()
        {
            btn1a.Enabled = false;
            btn2a.Enabled = false;
            btn1b.Enabled = false;
            btn2b.Enabled = false;
            btn1c.Enabled = false;
            btn2c.Enabled = false;
            btn1d.Enabled = false;
            btn2d.Enabled = false;
            btn1e.Enabled = false;
            btn2e.Enabled = false;
            btn1f.Enabled = false;
            btn2f.Enabled = false;
        }
        public void enable()
        {
            btn1a.Enabled = true;
            btn2a.Enabled = true;
            btn1b.Enabled = true;
            btn2b.Enabled = true;
            btn1c.Enabled = true;
            btn2c.Enabled = true;
            btn1d.Enabled = true;
            btn2d.Enabled = true;
            btn1e.Enabled = true;
            btn2e.Enabled = true;
            btn1f.Enabled = true;
            btn2f.Enabled = true;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            //disable();
            if (clicks1 % 2 == 0)
            {
                switch (clicks2)
                {
                    case 1:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb2a.Visible != true)
                            {
                                clicks1--;
                                btn1a.Visible = true;
                                pb1a.Visible = false;
                            }
                        }
                        break;
                    case 2:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb2b.Visible != true)
                            {
                                clicks1--;
                                btn1b.Visible = true;
                                pb1b.Visible = false;
                            }
                        }
                        break;
                    case 3:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb2c.Visible != true)
                            {
                                clicks1--;
                                btn1c.Visible = true;
                                pb1c.Visible = false;
                            }
                        }
                        break;
                    case 4:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb2d.Visible != true)
                            {
                                clicks1--;
                                btn1d.Visible = true;
                                pb1d.Visible = false;
                            }
                        }
                        break;
                    case 5:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb1c.Visible != true)
                            {
                                clicks1--;
                                btn2c.Visible = true;
                                pb2c.Visible = false;
                            }
                        }
                        break;
                    case 6:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb1d.Visible != true)
                            {
                                clicks1--;
                                btn2d.Visible = true;
                                pb2d.Visible = false;
                            }
                        }
                        break;
                    case 7:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb1a.Visible != true)
                            {
                                clicks1--;
                                btn2a.Visible = true;
                                pb2a.Visible = false;
                            }
                        }
                        break;
                    case 8:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb2e.Visible != true)
                            {
                                clicks1--;
                                btn1e.Visible = true;
                                pb1e.Visible = false;
                            }
                        }
                        break;
                    case 9:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb2f.Visible != true)
                            {
                                clicks1--;
                                btn1f.Visible = true;
                                pb1f.Visible = false;
                            }
                        }
                        break;
                    case 10:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb1e.Visible != true)
                            {
                                clicks1--;
                                btn2e.Visible = true;
                                pb2e.Visible = false;
                            }
                        }
                        break;
                    case 11:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb1b.Visible != true)
                            {
                                clicks1--;
                                btn2b.Visible = true;
                                pb2b.Visible = false;
                            }
                        }
                        break;
                    case 12:
                        if (clicks1 % 2 == 0)
                        {
                            if (pb1f.Visible != true)
                            {
                                clicks1--;
                                btn2f.Visible = true;
                                pb2f.Visible = false;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            // enable();
            timer2.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer5.Stop();
            this.Controls.Clear();
            this.InitializeComponent();
            counter = 120;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (counter >= 0)
            {
                counter -= 1;
                label1.Text = "You have " + counter.ToString() + " seconds left";
                if (counter < 61 && counter>=31)
                {
                    label1.ForeColor = Color.Purple;
                }
                else if (counter < 31 && counter >=11)
                {
                    label1.ForeColor = Color.DarkOrange;
                }else if (counter<11)
                {
                    label1.ForeColor = Color.Red;
                }
            }
            
            else
            {
                label1.Text = "Time's Up";
                MessageBox.Show("OOps, Looks like you didn't finish on time. :`(");
                Close();
            }
        }
    }
}