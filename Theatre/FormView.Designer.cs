namespace Theatre
{
    partial class FormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.tabView = new System.Windows.Forms.TabControl();
            this.tpTicketsInfo = new System.Windows.Forms.TabPage();
            this.btnSearchViewer = new System.Windows.Forms.Button();
            this.txtViewer = new System.Windows.Forms.TextBox();
            this.dataView1 = new System.Windows.Forms.DataGridView();
            this.tpPlayInfo = new System.Windows.Forms.TabPage();
            this.btnSearchTheatre = new System.Windows.Forms.Button();
            this.txtTheatre = new System.Windows.Forms.TextBox();
            this.dataView2 = new System.Windows.Forms.DataGridView();
            this.tpCashier = new System.Windows.Forms.TabPage();
            this.btnSearchCashier = new System.Windows.Forms.Button();
            this.txtCashier = new System.Windows.Forms.TextBox();
            this.dataView3 = new System.Windows.Forms.DataGridView();
            this.tabView.SuspendLayout();
            this.tpTicketsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.tpPlayInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            this.tpCashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tpTicketsInfo);
            this.tabView.Controls.Add(this.tpPlayInfo);
            this.tabView.Controls.Add(this.tpCashier);
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(0, 0);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(643, 367);
            this.tabView.TabIndex = 0;
            // 
            // tpTicketsInfo
            // 
            this.tpTicketsInfo.Controls.Add(this.btnSearchViewer);
            this.tpTicketsInfo.Controls.Add(this.txtViewer);
            this.tpTicketsInfo.Controls.Add(this.dataView1);
            this.tpTicketsInfo.Location = new System.Drawing.Point(4, 22);
            this.tpTicketsInfo.Name = "tpTicketsInfo";
            this.tpTicketsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpTicketsInfo.Size = new System.Drawing.Size(635, 341);
            this.tpTicketsInfo.TabIndex = 0;
            this.tpTicketsInfo.Text = "Информация о билетах";
            this.tpTicketsInfo.UseVisualStyleBackColor = true;
            // 
            // btnSearchViewer
            // 
            this.btnSearchViewer.Location = new System.Drawing.Point(145, 42);
            this.btnSearchViewer.Name = "btnSearchViewer";
            this.btnSearchViewer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchViewer.TabIndex = 2;
            this.btnSearchViewer.Text = "Поиск";
            this.btnSearchViewer.UseVisualStyleBackColor = true;
            this.btnSearchViewer.Click += new System.EventHandler(this.btnSearchViewer_Click);
            // 
            // txtViewer
            // 
            this.txtViewer.Location = new System.Drawing.Point(20, 44);
            this.txtViewer.Name = "txtViewer";
            this.txtViewer.Size = new System.Drawing.Size(100, 20);
            this.txtViewer.TabIndex = 1;
            this.txtViewer.Tag = "Зритель";
            this.txtViewer.Text = "Зритель";
            this.txtViewer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtViewer.Enter += new System.EventHandler(this.txtViewer_Enter);
            this.txtViewer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtViewer_KeyDown);
            this.txtViewer.Leave += new System.EventHandler(this.txtViewer_Leave);
            // 
            // dataView1
            // 
            this.dataView1.AllowUserToAddRows = false;
            this.dataView1.AllowUserToDeleteRows = false;
            this.dataView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataView1.BackgroundColor = System.Drawing.Color.White;
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Location = new System.Drawing.Point(3, 98);
            this.dataView1.Name = "dataView1";
            this.dataView1.ReadOnly = true;
            this.dataView1.RowHeadersVisible = false;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView1.Size = new System.Drawing.Size(629, 240);
            this.dataView1.TabIndex = 0;
            // 
            // tpPlayInfo
            // 
            this.tpPlayInfo.Controls.Add(this.btnSearchTheatre);
            this.tpPlayInfo.Controls.Add(this.txtTheatre);
            this.tpPlayInfo.Controls.Add(this.dataView2);
            this.tpPlayInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPlayInfo.Name = "tpPlayInfo";
            this.tpPlayInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayInfo.Size = new System.Drawing.Size(635, 341);
            this.tpPlayInfo.TabIndex = 1;
            this.tpPlayInfo.Text = "Информация о спектаклях";
            this.tpPlayInfo.UseVisualStyleBackColor = true;
            // 
            // btnSearchTheatre
            // 
            this.btnSearchTheatre.Location = new System.Drawing.Point(146, 31);
            this.btnSearchTheatre.Name = "btnSearchTheatre";
            this.btnSearchTheatre.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTheatre.TabIndex = 5;
            this.btnSearchTheatre.Text = "Поиск";
            this.btnSearchTheatre.UseVisualStyleBackColor = true;
            this.btnSearchTheatre.Click += new System.EventHandler(this.btnSearchTheatre_Click);
            // 
            // txtTheatre
            // 
            this.txtTheatre.Location = new System.Drawing.Point(21, 33);
            this.txtTheatre.Name = "txtTheatre";
            this.txtTheatre.Size = new System.Drawing.Size(100, 20);
            this.txtTheatre.TabIndex = 4;
            this.txtTheatre.Tag = "Театр";
            this.txtTheatre.Text = "Театр";
            this.txtTheatre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTheatre.Enter += new System.EventHandler(this.txtTheatre_Enter);
            this.txtTheatre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTheatre_KeyDown);
            this.txtTheatre.Leave += new System.EventHandler(this.txtTheatre_Leave);
            // 
            // dataView2
            // 
            this.dataView2.AllowUserToAddRows = false;
            this.dataView2.AllowUserToDeleteRows = false;
            this.dataView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataView2.BackgroundColor = System.Drawing.Color.White;
            this.dataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView2.Location = new System.Drawing.Point(3, 98);
            this.dataView2.Name = "dataView2";
            this.dataView2.ReadOnly = true;
            this.dataView2.RowHeadersVisible = false;
            this.dataView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView2.Size = new System.Drawing.Size(629, 240);
            this.dataView2.TabIndex = 3;
            // 
            // tpCashier
            // 
            this.tpCashier.Controls.Add(this.btnSearchCashier);
            this.tpCashier.Controls.Add(this.txtCashier);
            this.tpCashier.Controls.Add(this.dataView3);
            this.tpCashier.Location = new System.Drawing.Point(4, 22);
            this.tpCashier.Name = "tpCashier";
            this.tpCashier.Padding = new System.Windows.Forms.Padding(3);
            this.tpCashier.Size = new System.Drawing.Size(635, 341);
            this.tpCashier.TabIndex = 2;
            this.tpCashier.Text = "Информация о кассирах";
            this.tpCashier.UseVisualStyleBackColor = true;
            // 
            // btnSearchCashier
            // 
            this.btnSearchCashier.Location = new System.Drawing.Point(146, 17);
            this.btnSearchCashier.Name = "btnSearchCashier";
            this.btnSearchCashier.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCashier.TabIndex = 8;
            this.btnSearchCashier.Text = "Поиск";
            this.btnSearchCashier.UseVisualStyleBackColor = true;
            this.btnSearchCashier.Click += new System.EventHandler(this.btnSearchCashier_Click);
            // 
            // txtCashier
            // 
            this.txtCashier.Location = new System.Drawing.Point(21, 19);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.Size = new System.Drawing.Size(100, 20);
            this.txtCashier.TabIndex = 7;
            this.txtCashier.Tag = "Фамилия";
            this.txtCashier.Text = "Фамилия";
            this.txtCashier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCashier.Enter += new System.EventHandler(this.txtCashier_Enter);
            this.txtCashier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCashier_KeyDown);
            this.txtCashier.Leave += new System.EventHandler(this.txtCashier_Leave);
            // 
            // dataView3
            // 
            this.dataView3.AllowUserToAddRows = false;
            this.dataView3.AllowUserToDeleteRows = false;
            this.dataView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataView3.BackgroundColor = System.Drawing.Color.White;
            this.dataView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView3.Location = new System.Drawing.Point(3, 98);
            this.dataView3.Name = "dataView3";
            this.dataView3.ReadOnly = true;
            this.dataView3.RowHeadersVisible = false;
            this.dataView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView3.Size = new System.Drawing.Size(629, 240);
            this.dataView3.TabIndex = 6;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 367);
            this.Controls.Add(this.tabView);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр данных о театре";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.tabView.ResumeLayout(false);
            this.tpTicketsInfo.ResumeLayout(false);
            this.tpTicketsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.tpPlayInfo.ResumeLayout(false);
            this.tpPlayInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            this.tpCashier.ResumeLayout(false);
            this.tpCashier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tpTicketsInfo;
        private System.Windows.Forms.TabPage tpPlayInfo;
        private System.Windows.Forms.DataGridView dataView1;
        private System.Windows.Forms.Button btnSearchViewer;
        private System.Windows.Forms.TextBox txtViewer;
        private System.Windows.Forms.Button btnSearchTheatre;
        private System.Windows.Forms.TextBox txtTheatre;
        private System.Windows.Forms.DataGridView dataView2;
        private System.Windows.Forms.TabPage tpCashier;
        private System.Windows.Forms.Button btnSearchCashier;
        private System.Windows.Forms.TextBox txtCashier;
        private System.Windows.Forms.DataGridView dataView3;
    }
}