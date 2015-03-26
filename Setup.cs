using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleChat
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();

            SetColors();

            cl_t_IP.Click += new EventHandler(TextClick);
            cl_t_Port.Click += new EventHandler(TextClick);
            cl_t_Name.Click += new EventHandler(TextClick);

            svr_t_Port.Click += new EventHandler(TextClick);
            svr_t_greeting.Click += new EventHandler(TextClick);
        }

        private void SetColors()
        {
            Color col = Color.FromArgb(70, 70, 70);
            this.BackColor = col;
            cl_t_IP.ForeColor = col;
            cl_t_Name.ForeColor = col;
            cl_t_Port.ForeColor = col;

            svr_t_greeting.ForeColor = col;
            svr_t_Port.ForeColor = col;

            btn_help.ForeColor = col;
            cl_btn_Go.ForeColor = col;
            svr_btn_Go.ForeColor = col;
        }

        private void cl_btn_Go_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            if (cl_t_IP.Text != "" && cl_t_Port.Text != "" && cl_t_Name.Text != "")
            {

                client.Show();

                client.OverloadValues(cl_t_Name.Text, cl_t_IP.Text, Convert.ToInt32(cl_t_Port.Text));
            }
            else
                MessageBox.Show("Bitte fülle alle notwendigen Felder aus!");
        }

        private void svr_btn_Go_Click(object sender, EventArgs e)
        {
            Server server = new Server();

            if (svr_t_Port.Text != "" && svr_t_greeting.Text != "")
            {
                this.svr_btn_Go.Enabled = false;
                server.Show();
                server.OverloadValues(Convert.ToInt32(svr_t_Port.Text), svr_t_greeting.Text);
            }
            else
                MessageBox.Show("Bitte fülle alle notwendigen Felder aus!");
        }

        private void TextClick(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log in as '[ADMIN]' on the PC that is hosting the chat to gain admin rights.\nThese include being able to klick the KICK button\nor use the command '.kick <name>' to kick a user.", "Info");
        }

    }
}
