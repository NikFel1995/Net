namespace Theatre
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblperfomance = new System.Windows.Forms.Label();
            this.cbPerfomance = new System.Windows.Forms.ComboBox();
            this.спектакльBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажа_билетов_в_театрDataSet = new Theatre.Продажа_билетов_в_театрDataSet();
            this.cbSpectator = new System.Windows.Forms.ComboBox();
            this.зрительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSpectator = new System.Windows.Forms.Label();
            this.кассирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCashier = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.местоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPlace = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.единицаИзмеренияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDateOfPerformance = new System.Windows.Forms.TextBox();
            this.lblDateOfPerformance = new System.Windows.Forms.Label();
            this.txtPlayTime = new System.Windows.Forms.TextBox();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.txtDateOfTicketSales = new System.Windows.Forms.TextBox();
            this.lblDateOfTicketSales = new System.Windows.Forms.Label();
            this.спектакльTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.СпектакльTableAdapter();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.зрительTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.ЗрительTableAdapter();
            this.кассирTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.КассирTableAdapter();
            this.cbCashier = new System.Windows.Forms.ComboBox();
            this.физическоеЛицоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.физическое_лицоTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.Физическое_лицоTableAdapter();
            this.местоTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.МестоTableAdapter();
            this.единица_измеренияTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.Единица_измеренияTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpTicketSelling = new System.Windows.Forms.TabPage();
            this.tpPerfomaceEdit = new System.Windows.Forms.TabPage();
            this.спектакльDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSavePerfomance = new System.Windows.Forms.Button();
            this.cbPlayType = new System.Windows.Forms.ComboBox();
            this.типСпектакляBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPlayType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblPlayTitle = new System.Windows.Forms.Label();
            this.txtPlayTitle = new System.Windows.Forms.TextBox();
            this.btnChangePerfomance = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager();
            this.тип_спектакляTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.Тип_спектакляTableAdapter();
            this.PerfomanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfomance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfomanceDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTicketPriceChange = new System.Windows.Forms.TabPage();
            this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.БилетTableAdapter();
            this.lblPerfomance_ = new System.Windows.Forms.Label();
            this.cbPerfomance_ = new System.Windows.Forms.ComboBox();
            this.btnChangeTicketPrice = new System.Windows.Forms.Button();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.dataTicket = new System.Windows.Forms.DataGridView();
            this.lblTicketCurrency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.спектакльBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажа_билетов_в_театрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зрительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассирBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.единицаИзмеренияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическоеЛицоBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpTicketSelling.SuspendLayout();
            this.tpPerfomaceEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спектакльDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типСпектакляBindingSource)).BeginInit();
            this.tpTicketPriceChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblperfomance
            // 
            this.lblperfomance.AutoSize = true;
            this.lblperfomance.Location = new System.Drawing.Point(17, 13);
            this.lblperfomance.Name = "lblperfomance";
            this.lblperfomance.Size = new System.Drawing.Size(61, 13);
            this.lblperfomance.TabIndex = 0;
            this.lblperfomance.Text = "Спектакль";
            // 
            // cbPerfomance
            // 
            this.cbPerfomance.DataSource = this.спектакльBindingSource;
            this.cbPerfomance.DisplayMember = "Наименование";
            this.cbPerfomance.FormattingEnabled = true;
            this.cbPerfomance.Location = new System.Drawing.Point(125, 13);
            this.cbPerfomance.Name = "cbPerfomance";
            this.cbPerfomance.Size = new System.Drawing.Size(157, 21);
            this.cbPerfomance.TabIndex = 1;
            this.cbPerfomance.ValueMember = "Код спектакля";
            // 
            // спектакльBindingSource
            // 
            this.спектакльBindingSource.DataMember = "Спектакль";
            this.спектакльBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // продажа_билетов_в_театрDataSet
            // 
            this.продажа_билетов_в_театрDataSet.DataSetName = "Продажа_билетов_в_театрDataSet";
            this.продажа_билетов_в_театрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbSpectator
            // 
            this.cbSpectator.DataSource = this.зрительBindingSource;
            this.cbSpectator.DisplayMember = "Фамилия";
            this.cbSpectator.FormattingEnabled = true;
            this.cbSpectator.Location = new System.Drawing.Point(125, 53);
            this.cbSpectator.Name = "cbSpectator";
            this.cbSpectator.Size = new System.Drawing.Size(157, 21);
            this.cbSpectator.TabIndex = 3;
            this.cbSpectator.ValueMember = "Код зрителя";
            // 
            // зрительBindingSource
            // 
            this.зрительBindingSource.DataMember = "Зритель";
            this.зрительBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // lblSpectator
            // 
            this.lblSpectator.AutoSize = true;
            this.lblSpectator.Location = new System.Drawing.Point(17, 53);
            this.lblSpectator.Name = "lblSpectator";
            this.lblSpectator.Size = new System.Drawing.Size(49, 13);
            this.lblSpectator.TabIndex = 2;
            this.lblSpectator.Text = "Зритель";
            // 
            // кассирBindingSource
            // 
            this.кассирBindingSource.DataMember = "Кассир";
            this.кассирBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Location = new System.Drawing.Point(17, 90);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(44, 13);
            this.lblCashier.TabIndex = 4;
            this.lblCashier.Text = "Кассир";
            // 
            // cbPlace
            // 
            this.cbPlace.DataSource = this.местоBindingSource;
            this.cbPlace.DisplayMember = "Номер места";
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(125, 127);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(157, 21);
            this.cbPlace.TabIndex = 7;
            this.cbPlace.ValueMember = "Код места";
            // 
            // местоBindingSource
            // 
            this.местоBindingSource.DataMember = "Место";
            this.местоBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(17, 130);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(39, 13);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "Место";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DataSource = this.единицаИзмеренияBindingSource;
            this.cbCurrency.DisplayMember = "Наименование";
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(125, 166);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(157, 21);
            this.cbCurrency.TabIndex = 9;
            this.cbCurrency.ValueMember = "Код единицы измерения";
            // 
            // единицаИзмеренияBindingSource
            // 
            this.единицаИзмеренияBindingSource.DataMember = "Единица измерения";
            this.единицаИзмеренияBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(17, 169);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(45, 13);
            this.lblCurrency.TabIndex = 8;
            this.lblCurrency.Text = "Валюта";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(157, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 20);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Text = "5000";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateOfPerformance
            // 
            this.txtDateOfPerformance.Location = new System.Drawing.Point(157, 223);
            this.txtDateOfPerformance.Name = "txtDateOfPerformance";
            this.txtDateOfPerformance.Size = new System.Drawing.Size(125, 20);
            this.txtDateOfPerformance.TabIndex = 13;
            this.txtDateOfPerformance.Text = "23-05-2016";
            this.txtDateOfPerformance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateOfPerformance
            // 
            this.lblDateOfPerformance.AutoSize = true;
            this.lblDateOfPerformance.Location = new System.Drawing.Point(17, 230);
            this.lblDateOfPerformance.Name = "lblDateOfPerformance";
            this.lblDateOfPerformance.Size = new System.Drawing.Size(89, 13);
            this.lblDateOfPerformance.TabIndex = 12;
            this.lblDateOfPerformance.Text = "Дата спектакля";
            // 
            // txtPlayTime
            // 
            this.txtPlayTime.Location = new System.Drawing.Point(157, 249);
            this.txtPlayTime.Name = "txtPlayTime";
            this.txtPlayTime.Size = new System.Drawing.Size(125, 20);
            this.txtPlayTime.TabIndex = 15;
            this.txtPlayTime.Text = "10:00:00";
            this.txtPlayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.Location = new System.Drawing.Point(17, 256);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(134, 13);
            this.lblPlayTime.TabIndex = 14;
            this.lblPlayTime.Text = "Время начала спектакля";
            // 
            // txtDateOfTicketSales
            // 
            this.txtDateOfTicketSales.Location = new System.Drawing.Point(157, 275);
            this.txtDateOfTicketSales.Name = "txtDateOfTicketSales";
            this.txtDateOfTicketSales.Size = new System.Drawing.Size(125, 20);
            this.txtDateOfTicketSales.TabIndex = 17;
            this.txtDateOfTicketSales.Text = "20-05-2016";
            this.txtDateOfTicketSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateOfTicketSales
            // 
            this.lblDateOfTicketSales.AutoSize = true;
            this.lblDateOfTicketSales.Location = new System.Drawing.Point(17, 282);
            this.lblDateOfTicketSales.Name = "lblDateOfTicketSales";
            this.lblDateOfTicketSales.Size = new System.Drawing.Size(118, 13);
            this.lblDateOfTicketSales.TabIndex = 16;
            this.lblDateOfTicketSales.Text = "Дата продажи билета";
            // 
            // спектакльTableAdapter
            // 
            this.спектакльTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(567, 333);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(102, 37);
            this.btnAddRecord.TabIndex = 18;
            this.btnAddRecord.Text = "Добавить";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // зрительTableAdapter
            // 
            this.зрительTableAdapter.ClearBeforeFill = true;
            // 
            // кассирTableAdapter
            // 
            this.кассирTableAdapter.ClearBeforeFill = true;
            // 
            // cbCashier
            // 
            this.cbCashier.DataSource = this.физическоеЛицоBindingSource;
            this.cbCashier.DisplayMember = "Фамилия";
            this.cbCashier.FormattingEnabled = true;
            this.cbCashier.Location = new System.Drawing.Point(125, 87);
            this.cbCashier.Name = "cbCashier";
            this.cbCashier.Size = new System.Drawing.Size(157, 21);
            this.cbCashier.TabIndex = 19;
            this.cbCashier.ValueMember = "Код физического лица";
            // 
            // физическоеЛицоBindingSource
            // 
            this.физическоеЛицоBindingSource.DataMember = "Физическое лицо";
            this.физическоеЛицоBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // физическое_лицоTableAdapter
            // 
            this.физическое_лицоTableAdapter.ClearBeforeFill = true;
            // 
            // местоTableAdapter
            // 
            this.местоTableAdapter.ClearBeforeFill = true;
            // 
            // единица_измеренияTableAdapter
            // 
            this.единица_измеренияTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpTicketSelling);
            this.tabControl.Controls.Add(this.tpPerfomaceEdit);
            this.tabControl.Controls.Add(this.tpTicketPriceChange);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(705, 404);
            this.tabControl.TabIndex = 20;
            // 
            // tpTicketSelling
            // 
            this.tpTicketSelling.Controls.Add(this.cbCurrency);
            this.tpTicketSelling.Controls.Add(this.btnAddRecord);
            this.tpTicketSelling.Controls.Add(this.cbCashier);
            this.tpTicketSelling.Controls.Add(this.txtDateOfTicketSales);
            this.tpTicketSelling.Controls.Add(this.lblperfomance);
            this.tpTicketSelling.Controls.Add(this.lblDateOfTicketSales);
            this.tpTicketSelling.Controls.Add(this.cbPerfomance);
            this.tpTicketSelling.Controls.Add(this.txtPlayTime);
            this.tpTicketSelling.Controls.Add(this.lblSpectator);
            this.tpTicketSelling.Controls.Add(this.lblPlayTime);
            this.tpTicketSelling.Controls.Add(this.cbSpectator);
            this.tpTicketSelling.Controls.Add(this.txtDateOfPerformance);
            this.tpTicketSelling.Controls.Add(this.lblCashier);
            this.tpTicketSelling.Controls.Add(this.lblDateOfPerformance);
            this.tpTicketSelling.Controls.Add(this.lblPlace);
            this.tpTicketSelling.Controls.Add(this.txtPrice);
            this.tpTicketSelling.Controls.Add(this.cbPlace);
            this.tpTicketSelling.Controls.Add(this.lblPrice);
            this.tpTicketSelling.Controls.Add(this.lblCurrency);
            this.tpTicketSelling.Location = new System.Drawing.Point(4, 22);
            this.tpTicketSelling.Name = "tpTicketSelling";
            this.tpTicketSelling.Padding = new System.Windows.Forms.Padding(3);
            this.tpTicketSelling.Size = new System.Drawing.Size(697, 378);
            this.tpTicketSelling.TabIndex = 0;
            this.tpTicketSelling.Text = "Продажа билетов";
            this.tpTicketSelling.UseVisualStyleBackColor = true;
            // 
            // tpPerfomaceEdit
            // 
            this.tpPerfomaceEdit.AutoScroll = true;
            this.tpPerfomaceEdit.Controls.Add(this.спектакльDataGridView);
            this.tpPerfomaceEdit.Controls.Add(this.btnSavePerfomance);
            this.tpPerfomaceEdit.Controls.Add(this.cbPlayType);
            this.tpPerfomaceEdit.Controls.Add(this.lblPlayType);
            this.tpPerfomaceEdit.Controls.Add(this.lblDuration);
            this.tpPerfomaceEdit.Controls.Add(this.txtDuration);
            this.tpPerfomaceEdit.Controls.Add(this.lblPlayTitle);
            this.tpPerfomaceEdit.Controls.Add(this.txtPlayTitle);
            this.tpPerfomaceEdit.Controls.Add(this.btnChangePerfomance);
            this.tpPerfomaceEdit.Location = new System.Drawing.Point(4, 22);
            this.tpPerfomaceEdit.Name = "tpPerfomaceEdit";
            this.tpPerfomaceEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerfomaceEdit.Size = new System.Drawing.Size(697, 378);
            this.tpPerfomaceEdit.TabIndex = 1;
            this.tpPerfomaceEdit.Text = "Изменение данных о спектакле";
            this.tpPerfomaceEdit.UseVisualStyleBackColor = true;
            // 
            // спектакльDataGridView
            // 
            this.спектакльDataGridView.AllowUserToAddRows = false;
            this.спектакльDataGridView.AllowUserToDeleteRows = false;
            this.спектакльDataGridView.AutoGenerateColumns = false;
            this.спектакльDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.спектакльDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.спектакльDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.спектакльDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.спектакльDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PerfomanceId,
            this.dataGridViewTextBoxColumn2,
            this.Perfomance,
            this.PerfomanceDuration});
            this.спектакльDataGridView.DataSource = this.спектакльBindingSource;
            this.спектакльDataGridView.Location = new System.Drawing.Point(8, 6);
            this.спектакльDataGridView.Name = "спектакльDataGridView";
            this.спектакльDataGridView.ReadOnly = true;
            this.спектакльDataGridView.RowHeadersVisible = false;
            this.спектакльDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.спектакльDataGridView.Size = new System.Drawing.Size(681, 108);
            this.спектакльDataGridView.TabIndex = 9;
            this.спектакльDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.спектакльDataGridView_CellClick);
            // 
            // btnSavePerfomance
            // 
            this.btnSavePerfomance.Location = new System.Drawing.Point(34, 277);
            this.btnSavePerfomance.Name = "btnSavePerfomance";
            this.btnSavePerfomance.Size = new System.Drawing.Size(132, 31);
            this.btnSavePerfomance.TabIndex = 9;
            this.btnSavePerfomance.Text = "Сохранить";
            this.btnSavePerfomance.UseVisualStyleBackColor = true;
            this.btnSavePerfomance.Visible = false;
            this.btnSavePerfomance.Click += new System.EventHandler(this.btnSavePerfomance_Click);
            // 
            // cbPlayType
            // 
            this.cbPlayType.DataSource = this.типСпектакляBindingSource;
            this.cbPlayType.DisplayMember = "Наименование";
            this.cbPlayType.FormattingEnabled = true;
            this.cbPlayType.Location = new System.Drawing.Point(142, 191);
            this.cbPlayType.Name = "cbPlayType";
            this.cbPlayType.Size = new System.Drawing.Size(163, 21);
            this.cbPlayType.TabIndex = 8;
            this.cbPlayType.ValueMember = "Код типа спектакля";
            this.cbPlayType.Visible = false;
            // 
            // типСпектакляBindingSource
            // 
            this.типСпектакляBindingSource.DataMember = "Тип спектакля";
            this.типСпектакляBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // lblPlayType
            // 
            this.lblPlayType.AutoSize = true;
            this.lblPlayType.Location = new System.Drawing.Point(16, 191);
            this.lblPlayType.Name = "lblPlayType";
            this.lblPlayType.Size = new System.Drawing.Size(82, 13);
            this.lblPlayType.TabIndex = 7;
            this.lblPlayType.Text = "Тип спектакля";
            this.lblPlayType.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(16, 228);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(111, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Продолжительность";
            this.lblDuration.Visible = false;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(142, 225);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(163, 20);
            this.txtDuration.TabIndex = 4;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDuration.Visible = false;
            // 
            // lblPlayTitle
            // 
            this.lblPlayTitle.AutoSize = true;
            this.lblPlayTitle.Location = new System.Drawing.Point(16, 158);
            this.lblPlayTitle.Name = "lblPlayTitle";
            this.lblPlayTitle.Size = new System.Drawing.Size(83, 13);
            this.lblPlayTitle.TabIndex = 3;
            this.lblPlayTitle.Text = "Наименование";
            this.lblPlayTitle.Visible = false;
            // 
            // txtPlayTitle
            // 
            this.txtPlayTitle.Location = new System.Drawing.Point(142, 158);
            this.txtPlayTitle.Name = "txtPlayTitle";
            this.txtPlayTitle.Size = new System.Drawing.Size(163, 20);
            this.txtPlayTitle.TabIndex = 2;
            this.txtPlayTitle.Visible = false;
            // 
            // btnChangePerfomance
            // 
            this.btnChangePerfomance.Location = new System.Drawing.Point(557, 140);
            this.btnChangePerfomance.Name = "btnChangePerfomance";
            this.btnChangePerfomance.Size = new System.Drawing.Size(132, 31);
            this.btnChangePerfomance.TabIndex = 0;
            this.btnChangePerfomance.Text = "Изменить";
            this.btnChangePerfomance.UseVisualStyleBackColor = true;
            this.btnChangePerfomance.Click += new System.EventHandler(this.btnChangePerfomance_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Theatre.Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.Единица_измеренияTableAdapter = this.единица_измеренияTableAdapter;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.ЗрительTableAdapter = this.зрительTableAdapter;
            this.tableAdapterManager.КассирTableAdapter = this.кассирTableAdapter;
            this.tableAdapterManager.МестоTableAdapter = this.местоTableAdapter;
            this.tableAdapterManager.Населенный_пунктTableAdapter = null;
            this.tableAdapterManager.РядTableAdapter = null;
            this.tableAdapterManager.СпектакльTableAdapter = this.спектакльTableAdapter;
            this.tableAdapterManager.ТеатрTableAdapter = null;
            this.tableAdapterManager.Тип_спектакляTableAdapter = this.тип_спектакляTableAdapter;
            this.tableAdapterManager.Физическое_лицоTableAdapter = this.физическое_лицоTableAdapter;
            // 
            // тип_спектакляTableAdapter
            // 
            this.тип_спектакляTableAdapter.ClearBeforeFill = true;
            // 
            // PerfomanceId
            // 
            this.PerfomanceId.DataPropertyName = "Код спектакля";
            this.PerfomanceId.HeaderText = "Код спектакля";
            this.PerfomanceId.Name = "PerfomanceId";
            this.PerfomanceId.ReadOnly = true;
            this.PerfomanceId.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код типа спектакля";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код типа спектакля";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Perfomance
            // 
            this.Perfomance.DataPropertyName = "Наименование";
            this.Perfomance.HeaderText = "Спекталь";
            this.Perfomance.Name = "Perfomance";
            this.Perfomance.ReadOnly = true;
            // 
            // PerfomanceDuration
            // 
            this.PerfomanceDuration.DataPropertyName = "Продолжительность";
            this.PerfomanceDuration.HeaderText = "Продолжительность";
            this.PerfomanceDuration.Name = "PerfomanceDuration";
            this.PerfomanceDuration.ReadOnly = true;
            // 
            // tpTicketPriceChange
            // 
            this.tpTicketPriceChange.AutoScroll = true;
            this.tpTicketPriceChange.Controls.Add(this.lblTicketCurrency);
            this.tpTicketPriceChange.Controls.Add(this.dataTicket);
            this.tpTicketPriceChange.Controls.Add(this.lblTicketPrice);
            this.tpTicketPriceChange.Controls.Add(this.txtTicketPrice);
            this.tpTicketPriceChange.Controls.Add(this.btnChangeTicketPrice);
            this.tpTicketPriceChange.Controls.Add(this.cbPerfomance_);
            this.tpTicketPriceChange.Controls.Add(this.lblPerfomance_);
            this.tpTicketPriceChange.Location = new System.Drawing.Point(4, 22);
            this.tpTicketPriceChange.Name = "tpTicketPriceChange";
            this.tpTicketPriceChange.Padding = new System.Windows.Forms.Padding(3);
            this.tpTicketPriceChange.Size = new System.Drawing.Size(697, 378);
            this.tpTicketPriceChange.TabIndex = 2;
            this.tpTicketPriceChange.Text = "Изменение цены билета";
            this.tpTicketPriceChange.UseVisualStyleBackColor = true;
            // 
            // билетBindingSource
            // 
            this.билетBindingSource.DataMember = "Билет";
            this.билетBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // билетTableAdapter
            // 
            this.билетTableAdapter.ClearBeforeFill = true;
            // 
            // lblPerfomance_
            // 
            this.lblPerfomance_.AutoSize = true;
            this.lblPerfomance_.Location = new System.Drawing.Point(8, 23);
            this.lblPerfomance_.Name = "lblPerfomance_";
            this.lblPerfomance_.Size = new System.Drawing.Size(61, 13);
            this.lblPerfomance_.TabIndex = 19;
            this.lblPerfomance_.Text = "Спектакль";
            // 
            // cbPerfomance_
            // 
            this.cbPerfomance_.DataSource = this.спектакльBindingSource;
            this.cbPerfomance_.DisplayMember = "Наименование";
            this.cbPerfomance_.FormattingEnabled = true;
            this.cbPerfomance_.Location = new System.Drawing.Point(101, 20);
            this.cbPerfomance_.Name = "cbPerfomance_";
            this.cbPerfomance_.Size = new System.Drawing.Size(217, 21);
            this.cbPerfomance_.TabIndex = 20;
            this.cbPerfomance_.ValueMember = "Код спектакля";
            this.cbPerfomance_.SelectedIndexChanged += new System.EventHandler(this.cbPerfomance__SelectedIndexChanged);
            // 
            // btnChangeTicketPrice
            // 
            this.btnChangeTicketPrice.Location = new System.Drawing.Point(510, 237);
            this.btnChangeTicketPrice.Name = "btnChangeTicketPrice";
            this.btnChangeTicketPrice.Size = new System.Drawing.Size(165, 41);
            this.btnChangeTicketPrice.TabIndex = 21;
            this.btnChangeTicketPrice.Text = "Изменить цену билета";
            this.btnChangeTicketPrice.UseVisualStyleBackColor = true;
            this.btnChangeTicketPrice.Click += new System.EventHandler(this.btnChangeTicketPrice_Click);
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(118, 301);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTicketPrice.TabIndex = 22;
            this.txtTicketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Location = new System.Drawing.Point(17, 304);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(71, 13);
            this.lblTicketPrice.TabIndex = 23;
            this.lblTicketPrice.Text = "Цена билета";
            // 
            // dataTicket
            // 
            this.dataTicket.AllowUserToAddRows = false;
            this.dataTicket.AllowUserToDeleteRows = false;
            this.dataTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataTicket.BackgroundColor = System.Drawing.Color.White;
            this.dataTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTicket.Location = new System.Drawing.Point(11, 56);
            this.dataTicket.Name = "dataTicket";
            this.dataTicket.ReadOnly = true;
            this.dataTicket.RowHeadersVisible = false;
            this.dataTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTicket.Size = new System.Drawing.Size(664, 166);
            this.dataTicket.TabIndex = 25;
            this.dataTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTicket_CellClick);
            // 
            // lblTicketCurrency
            // 
            this.lblTicketCurrency.AutoSize = true;
            this.lblTicketCurrency.Location = new System.Drawing.Point(240, 304);
            this.lblTicketCurrency.Name = "lblTicketCurrency";
            this.lblTicketCurrency.Size = new System.Drawing.Size(45, 13);
            this.lblTicketCurrency.TabIndex = 26;
            this.lblTicketCurrency.Text = "Валюта";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 404);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа билетов в кинотеатр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.спектакльBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажа_билетов_в_театрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зрительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассирBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.единицаИзмеренияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическоеЛицоBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpTicketSelling.ResumeLayout(false);
            this.tpTicketSelling.PerformLayout();
            this.tpPerfomaceEdit.ResumeLayout(false);
            this.tpPerfomaceEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спектакльDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типСпектакляBindingSource)).EndInit();
            this.tpTicketPriceChange.ResumeLayout(false);
            this.tpTicketPriceChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblperfomance;
        private System.Windows.Forms.ComboBox cbPerfomance;
        private System.Windows.Forms.ComboBox cbSpectator;
        private System.Windows.Forms.Label lblSpectator;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDateOfPerformance;
        private System.Windows.Forms.Label lblDateOfPerformance;
        private System.Windows.Forms.TextBox txtPlayTime;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.TextBox txtDateOfTicketSales;
        private System.Windows.Forms.Label lblDateOfTicketSales;
        private Продажа_билетов_в_театрDataSet продажа_билетов_в_театрDataSet;
        private System.Windows.Forms.BindingSource спектакльBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.СпектакльTableAdapter спектакльTableAdapter;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.BindingSource зрительBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.ЗрительTableAdapter зрительTableAdapter;
        private System.Windows.Forms.BindingSource кассирBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.КассирTableAdapter кассирTableAdapter;
        private System.Windows.Forms.ComboBox cbCashier;
        private System.Windows.Forms.BindingSource физическоеЛицоBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.Физическое_лицоTableAdapter физическое_лицоTableAdapter;
        private System.Windows.Forms.BindingSource местоBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.МестоTableAdapter местоTableAdapter;
        private System.Windows.Forms.BindingSource единицаИзмеренияBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.Единица_измеренияTableAdapter единица_измеренияTableAdapter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpTicketSelling;
        private System.Windows.Forms.TabPage tpPerfomaceEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnChangePerfomance;
        private Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSavePerfomance;
        private System.Windows.Forms.ComboBox cbPlayType;
        private System.Windows.Forms.Label lblPlayType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblPlayTitle;
        private System.Windows.Forms.TextBox txtPlayTitle;
        private Продажа_билетов_в_театрDataSetTableAdapters.Тип_спектакляTableAdapter тип_спектакляTableAdapter;
        private System.Windows.Forms.BindingSource типСпектакляBindingSource;
        private System.Windows.Forms.DataGridView спектакльDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfomanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfomance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfomanceDuration;
        private System.Windows.Forms.TabPage tpTicketPriceChange;
        private System.Windows.Forms.BindingSource билетBindingSource;
        private Продажа_билетов_в_театрDataSetTableAdapters.БилетTableAdapter билетTableAdapter;
        private System.Windows.Forms.Button btnChangeTicketPrice;
        private System.Windows.Forms.ComboBox cbPerfomance_;
        private System.Windows.Forms.Label lblPerfomance_;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.DataGridView dataTicket;
        private System.Windows.Forms.Label lblTicketCurrency;

    }
}

