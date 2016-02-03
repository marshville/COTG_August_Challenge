using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COTGPetshop.PosApp
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 5;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
        }

        public async Task ShowProgressAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(1000);
                progressBar1.PerformStep();
            }
        }
    }
}
