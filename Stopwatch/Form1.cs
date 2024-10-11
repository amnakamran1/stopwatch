namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int msecs = Convert.ToInt32(msecslb.Text);
            int secs = Convert.ToInt32(secslb.Text);
            int mins = Convert.ToInt32(minslb.Text);
            int hrs = Convert.ToInt32(hrslb.Text);

            msecs = msecs + 1;
            msecslb.Text = msecs.ToString();
            if (msecs >= 60)
            {
                msecslb.Text = "00";
                secs = secs + 1;
                secslb.Text = secs.ToString();


            }
            else if (secs >= 60)
            {
                secslb.Text = "00";
                mins = mins + 1;
                minslb.Text = mins.ToString();

            }
            else if (mins >= 60)
            {
                minslb.Text = "00";
                hrs = hrs + 1;
                hrslb.Text = hrs.ToString();




            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            msecslb.Text = "00";
            secslb.Text = "00";
            minslb.Text = "00";
            hrslb.Text = "00";
            timer1.Enabled = false;
        }
    }
}
