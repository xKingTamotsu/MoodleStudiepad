﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoodleStudiepad.BU;
using MoodleStudiepad.CC;
using MoodleStudiepad.Forms.MdiChildren;

namespace MoodleStudiepad.GUI {
    public partial class MainForm : Form {

        public MainForm(string username) {
            InitializeComponent();
            lblName.Text = username;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
        }

        #region Toolstrip Buttons
        /// <summary>
        /// Mdi child form testing. Follow this template to create more mdi children. Stored child forms are in Forms/MdiChildren/.
        /// You should rename mdiDebuggingForm to the child's name. Hide the 'Debugging' toolstrip later when done!
        /// </summary>
        private void debug1ToolStripMenuItem_Click(object sender, EventArgs e)                              // Start method by clicking on the toolstrip button
        {                                                                                                   //
            MdiDebuggingForm mdiDebuggingForm = new MdiDebuggingForm();                                     // Make new instance of the form MdiDebuggingForm.cs
            mdiDebuggingForm.MdiParent = this;                                                              // Set parent form to this form (MainForm.cs)
            mdiDebuggingForm.Show();                                                                        // Show the child form
        }                                                                                                   //

        private void overzichtOnderwijseenhedenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubscribedModuleOverview mdiSubscribedModuleOverview = new SubscribedModuleOverview();
            mdiSubscribedModuleOverview.MdiParent = this;
            mdiSubscribedModuleOverview.Show();
        }

        private void logOut2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void pIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestationIndicatorOverview mdiPrestationIndicatorOverview = new PrestationIndicatorOverview();
            mdiPrestationIndicatorOverview.MdiParent = this;
            mdiPrestationIndicatorOverview.Show();
        }

        private void eCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditOverview mdiCreditOverview = new CreditOverview();
            mdiCreditOverview.MdiParent = this;
            mdiCreditOverview.Show();
        }
    }
}
