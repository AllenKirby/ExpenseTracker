﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Cannot Enter Numerical Values and Special Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Cannot Enter Numerical Values and Special Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot Enter Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Username cannot contain whitespaces and special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Password cannot contain whitespaces and special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }
        private void UpdatePasswordMatchLabel()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && string.IsNullOrWhiteSpace(txtrepeatpass.Text))
            {
                checkPass.Text = "";
            }

            else if (txtPassword.Text == txtrepeatpass.Text)
            {
                checkPass.Text = "Password Matched";
                checkPass.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                checkPass.Text = "Password Doesn't Match";
                checkPass.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordMatchLabel();
        }

        private void txtrepeatpass_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordMatchLabel();
        }
    }
}
