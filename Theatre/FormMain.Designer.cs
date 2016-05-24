namespace Theatre
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseActions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseActionsView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseActionsTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseActionsReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataBase,
            this.menuDataBaseActions,
            this.menuSecurity,
            this.menuAbout});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(673, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuDataBase
            // 
            this.menuDataBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataBaseConnect,
            this.menuDataBaseDisconnect});
            this.menuDataBase.Name = "menuDataBase";
            this.menuDataBase.Size = new System.Drawing.Size(86, 20);
            this.menuDataBase.Text = "База данных";
            // 
            // menuDataBaseConnect
            // 
            this.menuDataBaseConnect.Name = "menuDataBaseConnect";
            this.menuDataBaseConnect.Size = new System.Drawing.Size(156, 22);
            this.menuDataBaseConnect.Text = "Подключиться";
            this.menuDataBaseConnect.Click += new System.EventHandler(this.menuDataBaseConnect_Click);
            // 
            // menuDataBaseDisconnect
            // 
            this.menuDataBaseDisconnect.Name = "menuDataBaseDisconnect";
            this.menuDataBaseDisconnect.Size = new System.Drawing.Size(156, 22);
            this.menuDataBaseDisconnect.Text = "Отключиться";
            this.menuDataBaseDisconnect.Click += new System.EventHandler(this.menuDataBaseDisconnect_Click);
            // 
            // menuDataBaseActions
            // 
            this.menuDataBaseActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataBaseActionsView,
            this.menuDataBaseActionsTickets,
            this.menuDataBaseActionsReports});
            this.menuDataBaseActions.Name = "menuDataBaseActions";
            this.menuDataBaseActions.Size = new System.Drawing.Size(97, 20);
            this.menuDataBaseActions.Text = "Действия с БД";
            // 
            // menuDataBaseActionsView
            // 
            this.menuDataBaseActionsView.Name = "menuDataBaseActionsView";
            this.menuDataBaseActionsView.Size = new System.Drawing.Size(255, 22);
            this.menuDataBaseActionsView.Text = "Просмотр данных";
            this.menuDataBaseActionsView.Click += new System.EventHandler(this.menuDataBaseActionsView_Click);
            // 
            // menuDataBaseActionsTickets
            // 
            this.menuDataBaseActionsTickets.Name = "menuDataBaseActionsTickets";
            this.menuDataBaseActionsTickets.Size = new System.Drawing.Size(255, 22);
            this.menuDataBaseActionsTickets.Text = "Управление продажами билетов";
            this.menuDataBaseActionsTickets.Click += new System.EventHandler(this.menuDataBaseActionsTickets_Click);
            // 
            // menuDataBaseActionsReports
            // 
            this.menuDataBaseActionsReports.Name = "menuDataBaseActionsReports";
            this.menuDataBaseActionsReports.Size = new System.Drawing.Size(255, 22);
            this.menuDataBaseActionsReports.Text = "Сформировать отчеты";
            this.menuDataBaseActionsReports.Click += new System.EventHandler(this.menuDataBaseActionsReports_Click);
            // 
            // menuSecurity
            // 
            this.menuSecurity.Name = "menuSecurity";
            this.menuSecurity.Size = new System.Drawing.Size(94, 20);
            this.menuSecurity.Text = "Безопасность";
            this.menuSecurity.Click += new System.EventHandler(this.menuSecurity_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(94, 20);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusConnection,
            this.lblUser});
            this.status.Location = new System.Drawing.Point(0, 347);
            this.status.Name = "status";
            this.status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.status.ShowItemToolTips = true;
            this.status.Size = new System.Drawing.Size(673, 22);
            this.status.TabIndex = 1;
            this.status.Text = "status";
            // 
            // lblStatusConnection
            // 
            this.lblStatusConnection.Name = "lblStatusConnection";
            this.lblStatusConnection.Size = new System.Drawing.Size(540, 17);
            this.lblStatusConnection.Spring = true;
            this.lblStatusConnection.Tag = "Не подключено";
            this.lblStatusConnection.Text = "Не подключено";
            this.lblStatusConnection.ToolTipText = "Статус подключения";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 17);
            this.lblUser.Tag = "Пользователь ";
            this.lblUser.Text = "Пользователь ";
            this.lblUser.ToolTipText = "Тип пользователя";
            this.lblUser.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 369);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС \"Продажа билетов в театр\"";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuDataBase;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseConnect;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseDisconnect;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseActions;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseActionsReports;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseActionsView;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseActionsTickets;
        private System.Windows.Forms.ToolStripMenuItem menuSecurity;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusConnection;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
    }
}