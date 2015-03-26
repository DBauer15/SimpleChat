namespace SimpleChat
{
    partial class Client
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.btn_send = new System.Windows.Forms.Button();
            this.t_message = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t_main = new System.Windows.Forms.RichTextBox();
            this.userList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_kick = new System.Windows.Forms.Button();
            this.btn_whisper = new System.Windows.Forms.Button();
            this.chatNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(511, 463);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(91, 45);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // t_message
            // 
            this.t_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_message.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_message.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_message.Location = new System.Drawing.Point(12, 463);
            this.t_message.Multiline = true;
            this.t_message.Name = "t_message";
            this.t_message.Size = new System.Drawing.Size(493, 45);
            this.t_message.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t_main
            // 
            this.t_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_main.Cursor = System.Windows.Forms.Cursors.Cross;
            this.t_main.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_main.ForeColor = System.Drawing.Color.White;
            this.t_main.Location = new System.Drawing.Point(0, 31);
            this.t_main.Name = "t_main";
            this.t_main.ReadOnly = true;
            this.t_main.Size = new System.Drawing.Size(423, 416);
            this.t_main.TabIndex = 4;
            this.t_main.Text = "";
            this.t_main.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.t_main_LinkClicked);
            // 
            // userList
            // 
            this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userList.BackColor = System.Drawing.Color.SlateGray;
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 17;
            this.userList.Location = new System.Drawing.Point(20, 12);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(142, 306);
            this.userList.TabIndex = 5;
            this.userList.DoubleClick += new System.EventHandler(this.userList_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.btn_kick);
            this.panel1.Controls.Add(this.btn_whisper);
            this.panel1.Controls.Add(this.userList);
            this.panel1.Location = new System.Drawing.Point(436, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 416);
            this.panel1.TabIndex = 6;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_help.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_help.Location = new System.Drawing.Point(120, 366);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(32, 33);
            this.btn_help.TabIndex = 103;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_kick
            // 
            this.btn_kick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kick.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_kick.Enabled = false;
            this.btn_kick.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_kick.FlatAppearance.BorderSize = 0;
            this.btn_kick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_kick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_kick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kick.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kick.Location = new System.Drawing.Point(33, 366);
            this.btn_kick.Name = "btn_kick";
            this.btn_kick.Size = new System.Drawing.Size(81, 33);
            this.btn_kick.TabIndex = 6;
            this.btn_kick.Text = "KICK";
            this.btn_kick.UseVisualStyleBackColor = false;
            this.btn_kick.Click += new System.EventHandler(this.btn_kick_Clicked);
            // 
            // btn_whisper
            // 
            this.btn_whisper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_whisper.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_whisper.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_whisper.FlatAppearance.BorderSize = 0;
            this.btn_whisper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_whisper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_whisper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_whisper.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_whisper.Location = new System.Drawing.Point(33, 327);
            this.btn_whisper.Name = "btn_whisper";
            this.btn_whisper.Size = new System.Drawing.Size(119, 33);
            this.btn_whisper.TabIndex = 6;
            this.btn_whisper.Text = "WHISPER";
            this.btn_whisper.UseVisualStyleBackColor = false;
            this.btn_whisper.Click += new System.EventHandler(this.btn_whisper_Click);
            // 
            // chatNotify
            // 
            this.chatNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("chatNotify.Icon")));
            this.chatNotify.Text = "SimpleChat";
            this.chatNotify.Visible = true;
            this.chatNotify.BalloonTipClicked += new System.EventHandler(this.chatNotify_BalloonTipClicked);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(614, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.t_main);
            this.Controls.Add(this.t_message);
            this.Controls.Add(this.btn_send);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(503, 546);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox t_message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox t_main;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_whisper;
        private System.Windows.Forms.Button btn_kick;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.NotifyIcon chatNotify;
    }
}