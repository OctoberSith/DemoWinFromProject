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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        //BorderLess for Splash
        private void Splash_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            TimerSplash.Start();
            this.Close();
        }
    }
}
