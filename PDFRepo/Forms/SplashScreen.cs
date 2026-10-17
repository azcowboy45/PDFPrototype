using PDFRepo.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.Forms
{
    public partial class SplashScreen : Form
    {
        private ConfigMgr configMgr;
        private ConfigElements config;

        public SplashScreen(ConfigMgr configMgr, ConfigElements config)
        {
            this.configMgr = configMgr;
            this.config = config;

            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
          
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            SetupForm sf = new SetupForm( configMgr  , config);
            sf.ShowDialog();
        }
    }
}
