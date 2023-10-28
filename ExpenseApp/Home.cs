﻿using Google.Cloud.Firestore;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ExpenseApp
{
    public partial class Home : Form
    {

        string username;
        public Home()
        {
            InitializeComponent();

            btnDashboard.FillColor = SystemColors.Control;
            btnDashboard.ForeColor = Color.Black;
            changeButtonColor(btnWallet, btnAccount, btnGroup);
            changeFontColor(btnWallet, btnAccount, btnGroup);

            dashboard dashboard = new dashboard();
            addUserControl(dashboard);
            username = FirebaseData.Instance.Username;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            getFirstName(username);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = SystemColors.Control;
            btnDashboard.ForeColor = Color.Black;
            changeButtonColor(btnWallet, btnAccount, btnGroup);
            changeFontColor(btnWallet, btnAccount, btnGroup);

            dashboard dashboard = new dashboard();
            addUserControl(dashboard);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            btnWallet.FillColor = SystemColors.Control;
            btnWallet.ForeColor = Color.Black;
            changeButtonColor(btnDashboard, btnAccount, btnGroup);
            changeFontColor(btnDashboard, btnAccount, btnGroup);

            wallet wallet = new wallet();
            addUserControl(wallet);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            btnGroup.FillColor = SystemColors.Control;
            btnGroup.ForeColor = Color.Black;
            changeButtonColor(btnDashboard, btnAccount, btnWallet);
            changeFontColor(btnDashboard, btnAccount, btnWallet);

            group group = new group();
            addUserControl(group);
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            btnAccount.FillColor = SystemColors.Control;
            btnAccount.ForeColor = Color.Black;
            changeButtonColor(btnDashboard, btnWallet, btnGroup);
            changeFontColor(btnDashboard, btnWallet, btnGroup);
            profile tips = new profile();
            addUserControl(tips);
        }

        private void btnLogut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void guna2Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void changeButtonColor(Guna2Button button1, Guna2Button button2, Guna2Button button3)
        {
            button1.FillColor = Color.FromArgb(83, 123, 47);
            button2.FillColor = Color.FromArgb(83, 123, 47);
            button3.FillColor = Color.FromArgb(83, 123, 47);
        }
        private void changeFontColor(Guna2Button button1, Guna2Button button2, Guna2Button button3)
        {
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
        }
        async void getFirstName(string username)
        {
            otherFunc o = new otherFunc();
            DocumentSnapshot snap = await o.logInFunc(username);
            if (snap.Exists)
            {
                FirebaseData fd = snap.ConvertTo<FirebaseData>();
                lblFirstname.Text = "Hello, " + fd.FirstName + "!";
            }
        }
    }
}