using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 5;
            downloads.Value = start;
            if(downloads.Value == 100)
            {
                downloads.Value = 0;
                timer1.Stop();
                Main_Forms main = new Main_Forms();
                this.Hide();
                main.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }
    }
}
