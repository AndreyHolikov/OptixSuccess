//using System.Diagnostics;

using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace CheckThunderbird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        //System.Threading.Timer Timer1 = new (tm, null, 0, 2000);
        Timer Timer1 = new Timer();

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            Timer1.Interval = 5000;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            Timer1.Enabled = true;

            btnCheckThunderbird.Text = "Stop";
            btnCheckThunderbird.Click += new EventHandler(btnCheckThunderbird_Click);
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName(tbxProcessName.Text);
            if (processList.Length > 0)
            {
                rtbResult.Text = DateTime.Now + "\t" + "Запущен" + "\n" 
                    + rtbResult.Text;
                //MessageBox.Show("Запущен");
            }
            else
            {
                rtbResult.Text = DateTime.Now + "\t" + "Не запущен" + "\n"
                    + rtbResult.Text; 
                //MessageBox.Show("Не запущен");
            }
            Timer1.Interval = (int)nudTimerInterval.Value;
            //getUptime();
        }

        private void btnCheckThunderbird_Click(object sender, EventArgs e)
        {
            if (btnCheckThunderbird.Text == "Stop")
            {
                btnCheckThunderbird.Text = "Start";
                Timer1.Enabled = false;
            }
            else
            {
                btnCheckThunderbird.Text = "Stop";
                Timer1.Enabled = true;
            }
        }

        //public string getUptime()
        //{
        //    String strResult = String.Empty;
        //    strResult += Convert.ToString(Environment.TickCount / 86400000) + " дней, ";
        //    strResult += Convert.ToString(Environment.TickCount / 3600000 % 24) + " часов, ";
        //    strResult += Convert.ToString(Environment.TickCount / 120000 % 60) + " минут, ";
        //    strResult += Convert.ToString(Environment.TickCount / 1000 % 60) + " секунд.";
        //    tbxUptime.Text = getUptime();
        //    return strResult;
        //}
    }


}