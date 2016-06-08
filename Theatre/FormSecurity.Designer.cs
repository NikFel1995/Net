namespace Theatre
{
    partial class FormSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecurity));
            this.продажа_билетов_в_театрDataSet = new Theatre.Продажа_билетов_в_театрDataSet();
            this.securityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.SecurityTableAdapter();
            this.tableAdapterManager = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager();
            this.securityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.securityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.securityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.продажа_билетов_в_театрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBindingNavigator)).BeginInit();
            this.securityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // продажа_билетов_в_театрDataSet
            // 
            this.продажа_билетов_в_театрDataSet.DataSetName = "Продажа_билетов_в_театрDataSet";
            this.продажа_билетов_в_театрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securityBindingSource
            // 
            this.securityBindingSource.DataMember = "Security";
            this.securityBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // securityTableAdapter
            // 
            this.securityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SecurityTableAdapter = this.securityTableAdapter;
            this.tableAdapterManager.UpdateOrder = Theatre.Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.Единица_измеренияTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.ЗрительTableAdapter = null;
            this.tableAdapterManager.КассирTableAdapter = null;
            this.tableAdapterManager.МестоTableAdapter = null;
            this.tableAdapterManager.Населенный_пунктTableAdapter = null;
            this.tableAdapterManager.РядTableAdapter = null;
            this.tableAdapterManager.СпектакльTableAdapter = null;
            this.tableAdapterManager.ТеатрTableAdapter = null;
            this.tableAdapterManager.Тип_спектакляTableAdapter = null;
            this.tableAdapterManager.Физическое_лицоTableAdapter = null;
            // 
            // securityBindingNavigator
            // 
            this.securityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.securityBindingNavigator.BindingSource = this.securityBindingSource;
            this.securityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.securityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.securityBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.securityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.securityBindingNavigatorSaveItem});
            this.securityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.securityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.securityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.securityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.securityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.securityBindingNavigator.Name = "securityBindingNavigator";
            this.securityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.securityBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.securityBindingNavigator.Size = new System.Drawing.Size(744, 25);
            this.securityBindingNavigator.TabIndex = 0;
            this.securityBindingNavigator.Text = "bindingNavigator1";
            this.securityBindingNavigator.UseWaitCursor = true;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // securityBindingNavigatorSaveItem
            // 
            this.securityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.securityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("securityBindingNavigatorSaveItem.Image")));
            this.securityBindingNavigatorSaveItem.Name = "securityBindingNavigatorSaveItem";
            this.securityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.securityBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.securityBindingNavigatorSaveItem.Click += new System.EventHandler(this.securityBindingNavigatorSaveItem_Click);
            // 
            // securityDataGridView
            // 
            this.securityDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.securityDataGridView.AutoGenerateColumns = false;
            this.securityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.securityDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.securityDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.securityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.securityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.securityDataGridView.DataSource = this.securityBindingSource;
            this.securityDataGridView.Location = new System.Drawing.Point(8, 85);
            this.securityDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.securityDataGridView.Name = "securityDataGridView";
            this.securityDataGridView.RowHeadersVisible = false;
            this.securityDataGridView.Size = new System.Drawing.Size(730, 271);
            this.securityDataGridView.TabIndex = 1;
            this.securityDataGridView.UseWaitCursor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 361);
            this.Controls.Add(this.securityDataGridView);
            this.Controls.Add(this.securityBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSecurity";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Безопасность";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormSecurity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажа_билетов_в_театрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBindingNavigator)).EndInit();
            this.securityBindingNavigator.ResumeLayout(false);
            this.securityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Продажа_билетов_в_театрDataSet продажа_билетов_в_театрDataSet;
        private System.Windows.Forms.BindingSource securityBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.SecurityTableAdapter securityTableAdapter;
        private Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator securityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton securityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView securityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}