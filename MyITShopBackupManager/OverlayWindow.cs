using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyITShopBackupManager
{
    public partial class OverlayWindow : Form
    {
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        public OverlayWindow()
        {
            InitializeComponent();
        }

        public void setActiveJob(string job)
        {
            lblActiveJob.Text = job;
        }

        private void OverlayWindow_Load(object sender, EventArgs e)
        {
            lblActiveJob.Text = Properties.Settings.Default.activeJob;
        }
    }
}
