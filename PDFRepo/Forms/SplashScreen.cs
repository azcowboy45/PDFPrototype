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
        private string userName;

        public SplashScreen(ConfigMgr configMgr, ConfigElements config, String userName)
        {
            this.configMgr = configMgr;
            this.config = config;
            this.userName = userName;

            InitializeComponent();

            userNameLabel.Text = $"Welcome, {userName}";

            this.Load += new EventHandler(SplashScreen_Load);
            this.Resize += new EventHandler(SplashScreen_Resize);
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            CenterLabelHorizontally();
        }

        private void SplashScreen_Resize(object sender, EventArgs e)
        {
            // Keeps it perfectly centered even if the user maximizes or drags the window size
            CenterLabelHorizontally();
        }

        private void CenterLabelHorizontally()
        {
            // 1. Ensure the control measures its text width properly
            userNameLabel.AutoSize = true;
            takeCommandLable.AutoSize = true;
            copyrightLable.AutoSize = true;

            // 3. Math: Subtract label width from internal window width, divide by 2
            userNameLabel.Left = (this.ClientSize.Width - userNameLabel.Width) / 2;
            takeCommandLable.Left = (this.ClientSize.Width - takeCommandLable.Width) / 2;
            copyrightLable.Left = (this.ClientSize.Width - copyrightLable.Width) / 2;

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            SetupForm sf = new SetupForm( configMgr  , config, this );
            sf.ShowDialog();
        }
    }
}
