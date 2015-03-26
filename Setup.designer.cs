namespace SimpleChat
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.cl_btn_Go = new System.Windows.Forms.Button();
            this.svr_btn_Go = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.cl_t_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cl_t_Port = new System.Windows.Forms.TextBox();
            this.cl_t_IP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.svr_t_greeting = new System.Windows.Forms.TextBox();
            this.svr_t_Port = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cl_btn_Go
            // 
            this.cl_btn_Go.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cl_btn_Go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cl_btn_Go.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cl_btn_Go.FlatAppearance.BorderSize = 0;
            this.cl_btn_Go.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.cl_btn_Go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cl_btn_Go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cl_btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cl_btn_Go.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_btn_Go.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cl_btn_Go.Location = new System.Drawing.Point(25, 203);
            this.cl_btn_Go.Name = "cl_btn_Go";
            this.cl_btn_Go.Size = new System.Drawing.Size(107, 37);
            this.cl_btn_Go.TabIndex = 3;
            this.cl_btn_Go.Text = "Join Chat";
            this.cl_btn_Go.UseVisualStyleBackColor = false;
            this.cl_btn_Go.Click += new System.EventHandler(this.cl_btn_Go_Click);
            // 
            // svr_btn_Go
            // 
            this.svr_btn_Go.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.svr_btn_Go.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.svr_btn_Go.FlatAppearance.BorderSize = 0;
            this.svr_btn_Go.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.svr_btn_Go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.svr_btn_Go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.svr_btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.svr_btn_Go.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svr_btn_Go.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.svr_btn_Go.Location = new System.Drawing.Point(29, 203);
            this.svr_btn_Go.Name = "svr_btn_Go";
            this.svr_btn_Go.Size = new System.Drawing.Size(110, 37);
            this.svr_btn_Go.TabIndex = 2;
            this.svr_btn_Go.Text = "Start Server";
            this.svr_btn_Go.UseVisualStyleBackColor = false;
            this.svr_btn_Go.Click += new System.EventHandler(this.svr_btn_Go_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_help);
            this.groupBox1.Controls.Add(this.cl_t_Name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cl_t_Port);
            this.groupBox1.Controls.Add(this.cl_t_IP);
            this.groupBox1.Controls.Add(this.cl_btn_Go);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_help.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_help.FlatAppearance.BorderSize = 2;
            this.btn_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_help.Location = new System.Drawing.Point(127, 0);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(28, 27);
            this.btn_help.TabIndex = 102;
            this.btn_help.Text = "?";
            this.btn_help.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.button1_Click);
            // 
            // cl_t_Name
            // 
            this.cl_t_Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cl_t_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cl_t_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_t_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cl_t_Name.Location = new System.Drawing.Point(22, 142);
            this.cl_t_Name.Name = "cl_t_Name";
            this.cl_t_Name.Size = new System.Drawing.Size(117, 23);
            this.cl_t_Name.TabIndex = 2;
            this.cl_t_Name.Text = "Anonymous";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Nickname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // cl_t_Port
            // 
            this.cl_t_Port.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cl_t_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cl_t_Port.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_t_Port.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cl_t_Port.Location = new System.Drawing.Point(59, 79);
            this.cl_t_Port.Name = "cl_t_Port";
            this.cl_t_Port.Size = new System.Drawing.Size(80, 23);
            this.cl_t_Port.TabIndex = 1;
            this.cl_t_Port.Text = "50000";
            this.cl_t_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cl_t_IP
            // 
            this.cl_t_IP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cl_t_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cl_t_IP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_t_IP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cl_t_IP.Location = new System.Drawing.Point(44, 41);
            this.cl_t_IP.Name = "cl_t_IP";
            this.cl_t_IP.Size = new System.Drawing.Size(95, 23);
            this.cl_t_IP.TabIndex = 0;
            this.cl_t_IP.Text = "127.0.0.1";
            this.cl_t_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.svr_btn_Go);
            this.groupBox2.Controls.Add(this.svr_t_greeting);
            this.groupBox2.Controls.Add(this.svr_t_Port);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(193, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 104;
            this.label1.Text = "Port";
            // 
            // svr_t_greeting
            // 
            this.svr_t_greeting.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.svr_t_greeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svr_t_greeting.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svr_t_greeting.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.svr_t_greeting.Location = new System.Drawing.Point(18, 100);
            this.svr_t_greeting.Multiline = true;
            this.svr_t_greeting.Name = "svr_t_greeting";
            this.svr_t_greeting.Size = new System.Drawing.Size(128, 79);
            this.svr_t_greeting.TabIndex = 1;
            this.svr_t_greeting.Text = "# will be replaced by the player\'s nickname!";
            // 
            // svr_t_Port
            // 
            this.svr_t_Port.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.svr_t_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svr_t_Port.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svr_t_Port.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.svr_t_Port.Location = new System.Drawing.Point(55, 41);
            this.svr_t_Port.Name = "svr_t_Port";
            this.svr_t_Port.Size = new System.Drawing.Size(91, 23);
            this.svr_t_Port.TabIndex = 0;
            this.svr_t_Port.Text = "50000";
            this.svr_t_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(367, 277);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.Text = "Setup...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cl_btn_Go;
        private System.Windows.Forms.Button svr_btn_Go;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cl_t_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox svr_t_greeting;
        private System.Windows.Forms.TextBox svr_t_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cl_t_Port;
        private System.Windows.Forms.TextBox cl_t_IP;
        private System.Windows.Forms.Button btn_help;
    }
}

