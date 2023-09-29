using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewProject
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }


        private void User_Load(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == createBtn)
            {
                //this.Hide();
                //FormRegistr f = new FormRegistr();
                //f.Show();


               // this.Hide();
                //var form2 = new Form2();
                FormRegistr f = new FormRegistr();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }

            if (btn == submitBtn)
            {
                FormCommand.textBox_Login = textBox_Login.Text;
                FormCommand.textBox_pass = textBox_pass.Text;
                if (FormCommand.Deserialization())
                {
                    this.Close();
                }

            }



        }
        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
