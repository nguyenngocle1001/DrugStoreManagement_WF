using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(panelLoad.Width >= panelLoadParent.Width)
            {
                timer.Stop();
                Close();
            }

            panelLoad.Width+=2;
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
