//using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace NewProject
{
    public partial class FormRegistr : Form
    {
        public string JsonConvert { get; private set; }


        public FormRegistr()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == Con)
            {

            }

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBoxConfPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegistr_Load_1(object sender, EventArgs e)
        {
            User f2 = new User();
            f2.Close();
        }

        private void ConfirmBtn(object sender, EventArgs e)
        {





        }

        private void ButtonClik(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == Con)
            {
                FormCommand.textBoxLogin = textBoxLogin.Text;
                FormCommand.textBoxPass = textBoxPass.Text;
                FormCommand.textBoxConfPass = textBoxConfPass.Text;
                FormCommand.textBoxAge = textBoxAge.Text;
                FormCommand.textBoxUser = textBoxUser.Text;
                FormCommand.Validation();

                //this.Hide();

                this.Hide();
                User u = new User();
                u.Closed += (s, args) => this.Close();
                u.Show();
            }
            if (btn == prev)
            {

                //User u = new User();
                //this.Hide();
                //u.Show();
                this.Hide();
                User u = new User();
                u.Closed += (s, args) => this.Close();
                u.Show();

            }

        }
    }
}


