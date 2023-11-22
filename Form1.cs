namespace NotifyApp
{
    public partial class Form1 : Form
    {
        private int hourNotify;
        private int minNotify;
        private int secNotify;
        private DateTime endTime;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNow();
        }

        private void timeNow()
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            lb_hour.Text = hour.ToString("00");
            lb_min.Text = minute.ToString("00");
            lb_sec.Text = second.ToString("00");
        }

        private void btn_cancel_Paint(object sender, PaintEventArgs e)
        {
            int width = btn_cancel.Width;
            int height = btn_cancel.Height;
            int x = btn_cancel.Location.X;
            int y = btn_cancel.Location.Y;

            // Draw the circle
            e.Graphics.DrawEllipse(Pens.Black, x, y, width, height);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_hourNotify.Text = hourNotify.ToString("00");
            lb_minNotify.Text = minNotify.ToString("00");
            lb_secNotify.Text = secNotify.ToString("00");
           
            DateTime startTime = DateTime.Now;
            endTime = startTime.AddHours(hourNotify).AddMinutes(minNotify).AddSeconds(secNotify);
            timer2.Start();
        }

        private void comb_hour_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strHour = comb_hour.SelectedItem as string;
            if (strHour != null)
            {
                hourNotify = int.Parse(strHour);
            }
            else
            {
                hourNotify = 0;
            }

        }

        private void comb_min_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strMin = comb_min.SelectedItem as string;
            if (strMin != null)
            {
                minNotify = int.Parse(strMin);
            }
            else
            {
                minNotify = 0;
            }
        }

        private void comb_sec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strSec = comb_sec.SelectedItem as string;
            if (strSec != null)
            {
                secNotify = int.Parse(strSec);
            }
            else
            {
                secNotify = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lb_hourNotify.Text = (endTime - DateTime.Now).ToString("hh");
            lb_minNotify.Text = (endTime - DateTime.Now).ToString("mm");
            lb_secNotify.Text = (endTime - DateTime.Now).ToString("ss");
            if(DateTime.Now >= endTime)
            {
                timer2.Stop();
                MessageBox.Show("Time Over!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            lb_hourNotify.Text = "00";
            lb_minNotify.Text = "00";
            lb_secNotify.Text = "00";
        }
    }
}
