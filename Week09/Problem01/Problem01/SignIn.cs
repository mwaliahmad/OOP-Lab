﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Problem01.BL;
using Problem01.DL;
namespace Problem01
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            User U = new User(name, pass);
            User  user = UserCRUD.UserSignIn(U);
            if(user != null)
            {
            MessageBox.Show("User Valid");
            }
            else
            {
                MessageBox.Show("User not Valid");
            }
            ClearForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
