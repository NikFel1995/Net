namespace Theatre
{
    partial class FormConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnection));
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.comboUserType = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblGuest = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.BackColor = System.Drawing.Color.White;
            this.lblIp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIp.ForeColor = System.Drawing.Color.Black;
            this.lblIp.Location = new System.Drawing.Point(32, 151);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(57, 15);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP-адрес";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(150, 148);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(117, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp_KeyPress);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(150, 174);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(117, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "1433";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.White;
            this.lblPort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.ForeColor = System.Drawing.Color.Black;
            this.lblPort.Location = new System.Drawing.Point(32, 177);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 15);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Порт";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(117, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(32, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 15);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(150, 227);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(117, 20);
            this.txtUser.TabIndex = 4;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(32, 230);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(104, 15);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Имя пользователя";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.White;
            this.lblUserType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserType.ForeColor = System.Drawing.Color.Black;
            this.lblUserType.Location = new System.Drawing.Point(32, 203);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(101, 15);
            this.lblUserType.TabIndex = 8;
            this.lblUserType.Text = "Тип пользователя";
            // 
            // comboUserType
            // 
            this.comboUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Кассир",
            "Администратор"});
            this.comboUserType.Location = new System.Drawing.Point(150, 200);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(117, 21);
            this.comboUserType.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(35, 295);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 38);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblGuest
            // 
            this.lblGuest.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lblGuest.AutoSize = true;
            this.lblGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGuest.LinkColor = System.Drawing.Color.Gray;
            this.lblGuest.Location = new System.Drawing.Point(164, 308);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(107, 15);
            this.lblGuest.TabIndex = 7;
            this.lblGuest.TabStop = true;
            this.lblGuest.Text = "Любимый зритель";
            this.lblGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGuest_LinkClicked);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(305, 364);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.comboUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lblIp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к БД";
            this.Load += new System.EventHandler(this.FormConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox comboUserType;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.LinkLabel lblGuest;
    }
}