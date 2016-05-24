namespace Theatre
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pic = new System.Windows.Forms.PictureBox();
            this.txtInfoProduct = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Image = global::Theatre.Properties.Resources.pic01;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(562, 330);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // txtInfoProduct
            // 
            this.txtInfoProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfoProduct.BackColor = System.Drawing.Color.Maroon;
            this.txtInfoProduct.ForeColor = System.Drawing.Color.Yellow;
            this.txtInfoProduct.Location = new System.Drawing.Point(12, 12);
            this.txtInfoProduct.Multiline = true;
            this.txtInfoProduct.Name = "txtInfoProduct";
            this.txtInfoProduct.ReadOnly = true;
            this.txtInfoProduct.Size = new System.Drawing.Size(538, 66);
            this.txtInfoProduct.TabIndex = 1;
            this.txtInfoProduct.TabStop = false;
            this.txtInfoProduct.Text = resources.GetString("txtInfoProduct.Text");
            this.txtInfoProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.BackColor = System.Drawing.Color.Maroon;
            this.txtAuthor.ForeColor = System.Drawing.Color.Yellow;
            this.txtAuthor.Location = new System.Drawing.Point(267, 274);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(295, 56);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.TabStop = false;
            this.txtAuthor.Text = "Автор: Ларичева А.К.\r\nСтудентка 3-его курса группы 13-ИВТ ПОВТ\r\nфакультета матема" +
    "тики и информационных технологий";
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCopyright
            // 
            this.txtCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCopyright.BackColor = System.Drawing.Color.Maroon;
            this.txtCopyright.ForeColor = System.Drawing.Color.Yellow;
            this.txtCopyright.Location = new System.Drawing.Point(0, 273);
            this.txtCopyright.Multiline = true;
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.ReadOnly = true;
            this.txtCopyright.Size = new System.Drawing.Size(261, 56);
            this.txtCopyright.TabIndex = 3;
            this.txtCopyright.TabStop = false;
            this.txtCopyright.Text = "Версия: 1.0.0\r\nCopyright © Анастастасия 2016 Все права защищены.";
            this.txtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 330);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtInfoProduct);
            this.Controls.Add(this.pic);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox txtInfoProduct;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCopyright;
    }
}