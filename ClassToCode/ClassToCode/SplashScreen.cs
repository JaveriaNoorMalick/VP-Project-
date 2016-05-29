using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassToCode
{
    public partial class SplashScreen : Form
    {
        ErrorList el;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                this.timerProgressBar.Start();
                progressBar.Visible = true;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            } 
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            try
            {
                this.progressBar.Increment(1);
                if (progressBar.Value == 50)
                {
                    timerProgressBar.Enabled = false;
                    this.Hide();
                    MainScreen ob = new MainScreen();
                    ob.Show();
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
    }
}
