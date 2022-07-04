using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinFromProject
{
    public partial class snoozeAlarm : UserControl
    {
        int Seconds = 0;
        bool isMin = false;
        bool isSec = false;

        public snoozeAlarm()
        
        {
            InitializeComponent();
        }

        private void snoozeAlarm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                SetTimer();
                timer1.Interval = 1000;
                timer1.Start();
                MessageBox.Show("Time has Started");
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                timer1.Stop();
                MessageBox.Show("Timer is Stopped!");
            }
 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Seconds = (int)(numericUpDown1.Value);
        }

        private void SetTimer()
        {
            if(isMin)
            {
                Seconds *= 60;
            }
            else if(isSec)
            {
                Seconds *= 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Seconds--;
            if(Seconds == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's Up Fool!");
            }
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxTime.SelectedItem.ToString();
            if(selected == "MIN")
            {
                isMin = true;
            }
            else if (selected == "SEC")
            {
                isSec = true;
            }
        }
    }
}
