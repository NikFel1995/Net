namespace Theatre
{
    partial class FormTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTickets));
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
            this.tabTickets = new System.Windows.Forms.TabControl();
            this.tpTicketSelling = new System.Windows.Forms.TabPage();
            this.txtDateOfPerformance = new System.Windows.Forms.TextBox();
            this.tpPerfomaceEdit = new System.Windows.Forms.TabPage();
            this.спектакльDataGridView = new System.Windows.Forms.DataGridView();
            this.PerfomanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfomance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfomanceDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePerfomance = new System.Windows.Forms.Button();
            this.cbPlayType = new System.Windows.Forms.ComboBox();
            this.типСпектакляBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPlayType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblPlayTitle = new System.Windows.Forms.Label();
            this.txtPlayTitle = new System.Windows.Forms.TextBox();
            this.btnChangePerfomance = new System.Windows.Forms.Button();
            this.tpTicketPriceChange = new System.Windows.Forms.TabPage();
            this.lblTicketCurrency = new System.Windows.Forms.Label();
            this.dataTicket = new System.Windows.Forms.DataGridView();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.btnChangeTicketPrice = new System.Windows.Forms.Button();
            this.cbPerfomance_ = new System.Windows.Forms.ComboBox();
            this.lblPerfomance_ = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.TableAdapterManager();
            this.тип_спектакляTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.Тип_спектакляTableAdapter();
            this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетTableAdapter = new Theatre.Продажа_билетов_в_театрDataSetTableAdapters.БилетTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.спектакльBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажа_билетов_в_театрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зрительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассирBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.единицаИзмеренияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическоеЛицоBindingSource)).BeginInit();
            this.tabTickets.SuspendLayout();
            this.tpTicketSelling.SuspendLayout();
            this.tpPerfomaceEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спектакльDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типСпектакляBindingSource)).BeginInit();
            this.tpTicketPriceChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblperfomance
            // 
            this.lblperfomance.AutoSize = true;
            this.lblperfomance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblperfomance.Location = new System.Drawing.Point(20, 16);
            this.lblperfomance.Name = "lblperfomance";
            this.lblperfomance.Size = new System.Drawing.Size(65, 15);
            this.lblperfomance.TabIndex = 0;
            this.lblperfomance.Text = "Спектакль";
            // 
            // cbPerfomance
            // 
            this.cbPerfomance.DataSource = this.спектакльBindingSource;
            this.cbPerfomance.DisplayMember = "Наименование";
            this.cbPerfomance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPerfomance.FormattingEnabled = true;
            this.cbPerfomance.Location = new System.Drawing.Point(146, 16);
            this.cbPerfomance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPerfomance.Name = "cbPerfomance";
            this.cbPerfomance.Size = new System.Drawing.Size(182, 23);
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
            this.cbSpectator.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSpectator.FormattingEnabled = true;
            this.cbSpectator.Location = new System.Drawing.Point(146, 65);
            this.cbSpectator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSpectator.Name = "cbSpectator";
            this.cbSpectator.Size = new System.Drawing.Size(182, 23);
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
            this.lblSpectator.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpectator.Location = new System.Drawing.Point(20, 65);
            this.lblSpectator.Name = "lblSpectator";
            this.lblSpectator.Size = new System.Drawing.Size(50, 15);
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
            this.lblCashier.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCashier.Location = new System.Drawing.Point(20, 111);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(50, 15);
            this.lblCashier.TabIndex = 4;
            this.lblCashier.Text = "Кассир";
            // 
            // cbPlace
            // 
            this.cbPlace.DataSource = this.местоBindingSource;
            this.cbPlace.DisplayMember = "Номер места";
            this.cbPlace.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(146, 156);
            this.cbPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(182, 23);
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
            this.lblPlace.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlace.Location = new System.Drawing.Point(20, 160);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(42, 15);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "Место";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DataSource = this.единицаИзмеренияBindingSource;
            this.cbCurrency.DisplayMember = "Наименование";
            this.cbCurrency.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(146, 204);
            this.cbCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(182, 23);
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
            this.lblCurrency.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrency.Location = new System.Drawing.Point(20, 208);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(48, 15);
            this.lblCurrency.TabIndex = 8;
            this.lblCurrency.Text = "Валюта";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(20, 246);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 15);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(183, 242);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 21);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Text = "5000";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateOfPerformance
            // 
            this.lblDateOfPerformance.AutoSize = true;
            this.lblDateOfPerformance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfPerformance.Location = new System.Drawing.Point(20, 283);
            this.lblDateOfPerformance.Name = "lblDateOfPerformance";
            this.lblDateOfPerformance.Size = new System.Drawing.Size(94, 15);
            this.lblDateOfPerformance.TabIndex = 12;
            this.lblDateOfPerformance.Text = "Дата спектакля";
            // 
            // txtPlayTime
            // 
            this.txtPlayTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayTime.Location = new System.Drawing.Point(183, 306);
            this.txtPlayTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayTime.Name = "txtPlayTime";
            this.txtPlayTime.Size = new System.Drawing.Size(145, 21);
            this.txtPlayTime.TabIndex = 15;
            this.txtPlayTime.Text = "10:00:00";
            this.txtPlayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayTime.Location = new System.Drawing.Point(20, 315);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(146, 15);
            this.lblPlayTime.TabIndex = 14;
            this.lblPlayTime.Text = "Время начала спектакля";
            // 
            // txtDateOfTicketSales
            // 
            this.txtDateOfTicketSales.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateOfTicketSales.Location = new System.Drawing.Point(183, 338);
            this.txtDateOfTicketSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateOfTicketSales.Name = "txtDateOfTicketSales";
            this.txtDateOfTicketSales.Size = new System.Drawing.Size(145, 21);
            this.txtDateOfTicketSales.TabIndex = 17;
            this.txtDateOfTicketSales.Text = "2016-05-01";
            this.txtDateOfTicketSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateOfTicketSales
            // 
            this.lblDateOfTicketSales.AutoSize = true;
            this.lblDateOfTicketSales.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfTicketSales.Location = new System.Drawing.Point(20, 347);
            this.lblDateOfTicketSales.Name = "lblDateOfTicketSales";
            this.lblDateOfTicketSales.Size = new System.Drawing.Size(132, 15);
            this.lblDateOfTicketSales.TabIndex = 16;
            this.lblDateOfTicketSales.Text = "Дата продажи билета";
            // 
            // спектакльTableAdapter
            // 
            this.спектакльTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(661, 410);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(119, 46);
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
            this.cbCashier.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCashier.FormattingEnabled = true;
            this.cbCashier.Location = new System.Drawing.Point(146, 107);
            this.cbCashier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCashier.Name = "cbCashier";
            this.cbCashier.Size = new System.Drawing.Size(182, 23);
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
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.tpTicketSelling);
            this.tabTickets.Controls.Add(this.tpPerfomaceEdit);
            this.tabTickets.Controls.Add(this.tpTicketPriceChange);
            this.tabTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTickets.Location = new System.Drawing.Point(0, 0);
            this.tabTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.SelectedIndex = 0;
            this.tabTickets.Size = new System.Drawing.Size(822, 497);
            this.tabTickets.TabIndex = 20;
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
            this.tpTicketSelling.Location = new System.Drawing.Point(4, 25);
            this.tpTicketSelling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTicketSelling.Name = "tpTicketSelling";
            this.tpTicketSelling.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTicketSelling.Size = new System.Drawing.Size(814, 468);
            this.tpTicketSelling.TabIndex = 0;
            this.tpTicketSelling.Text = "Продажа билетов";
            this.tpTicketSelling.UseVisualStyleBackColor = true;
            // 
            // txtDateOfPerformance
            // 
            this.txtDateOfPerformance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateOfPerformance.Location = new System.Drawing.Point(183, 274);
            this.txtDateOfPerformance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateOfPerformance.Name = "txtDateOfPerformance";
            this.txtDateOfPerformance.Size = new System.Drawing.Size(145, 21);
            this.txtDateOfPerformance.TabIndex = 13;
            this.txtDateOfPerformance.Text = "2016-05-02";
            this.txtDateOfPerformance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tpPerfomaceEdit.Location = new System.Drawing.Point(4, 25);
            this.tpPerfomaceEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpPerfomaceEdit.Name = "tpPerfomaceEdit";
            this.tpPerfomaceEdit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpPerfomaceEdit.Size = new System.Drawing.Size(814, 468);
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
            this.спектакльDataGridView.Location = new System.Drawing.Point(9, 7);
            this.спектакльDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.спектакльDataGridView.Name = "спектакльDataGridView";
            this.спектакльDataGridView.ReadOnly = true;
            this.спектакльDataGridView.RowHeadersVisible = false;
            this.спектакльDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.спектакльDataGridView.Size = new System.Drawing.Size(794, 133);
            this.спектакльDataGridView.TabIndex = 9;
            this.спектакльDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.спектакльDataGridView_CellClick);
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
            // btnSavePerfomance
            // 
            this.btnSavePerfomance.Location = new System.Drawing.Point(40, 341);
            this.btnSavePerfomance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSavePerfomance.Name = "btnSavePerfomance";
            this.btnSavePerfomance.Size = new System.Drawing.Size(154, 38);
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
            this.cbPlayType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlayType.FormattingEnabled = true;
            this.cbPlayType.Location = new System.Drawing.Point(166, 235);
            this.cbPlayType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPlayType.Name = "cbPlayType";
            this.cbPlayType.Size = new System.Drawing.Size(189, 23);
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
            this.lblPlayType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayType.Location = new System.Drawing.Point(19, 235);
            this.lblPlayType.Name = "lblPlayType";
            this.lblPlayType.Size = new System.Drawing.Size(85, 15);
            this.lblPlayType.TabIndex = 7;
            this.lblPlayType.Text = "Тип спектакля";
            this.lblPlayType.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDuration.Location = new System.Drawing.Point(19, 281);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(117, 15);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Продолжительность";
            this.lblDuration.Visible = false;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDuration.Location = new System.Drawing.Point(166, 277);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(189, 21);
            this.txtDuration.TabIndex = 4;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDuration.Visible = false;
            // 
            // lblPlayTitle
            // 
            this.lblPlayTitle.AutoSize = true;
            this.lblPlayTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayTitle.Location = new System.Drawing.Point(19, 194);
            this.lblPlayTitle.Name = "lblPlayTitle";
            this.lblPlayTitle.Size = new System.Drawing.Size(94, 15);
            this.lblPlayTitle.TabIndex = 3;
            this.lblPlayTitle.Text = "Наименование";
            this.lblPlayTitle.Visible = false;
            // 
            // txtPlayTitle
            // 
            this.txtPlayTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayTitle.Location = new System.Drawing.Point(166, 194);
            this.txtPlayTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayTitle.Name = "txtPlayTitle";
            this.txtPlayTitle.Size = new System.Drawing.Size(189, 21);
            this.txtPlayTitle.TabIndex = 2;
            this.txtPlayTitle.Visible = false;
            // 
            // btnChangePerfomance
            // 
            this.btnChangePerfomance.Location = new System.Drawing.Point(650, 172);
            this.btnChangePerfomance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePerfomance.Name = "btnChangePerfomance";
            this.btnChangePerfomance.Size = new System.Drawing.Size(154, 38);
            this.btnChangePerfomance.TabIndex = 0;
            this.btnChangePerfomance.Text = "Изменить";
            this.btnChangePerfomance.UseVisualStyleBackColor = true;
            this.btnChangePerfomance.Click += new System.EventHandler(this.btnChangePerfomance_Click);
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
            this.tpTicketPriceChange.Location = new System.Drawing.Point(4, 25);
            this.tpTicketPriceChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTicketPriceChange.Name = "tpTicketPriceChange";
            this.tpTicketPriceChange.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTicketPriceChange.Size = new System.Drawing.Size(814, 468);
            this.tpTicketPriceChange.TabIndex = 2;
            this.tpTicketPriceChange.Text = "Изменение цены билета";
            this.tpTicketPriceChange.UseVisualStyleBackColor = true;
            // 
            // lblTicketCurrency
            // 
            this.lblTicketCurrency.AutoSize = true;
            this.lblTicketCurrency.Location = new System.Drawing.Point(280, 374);
            this.lblTicketCurrency.Name = "lblTicketCurrency";
            this.lblTicketCurrency.Size = new System.Drawing.Size(49, 16);
            this.lblTicketCurrency.TabIndex = 26;
            this.lblTicketCurrency.Text = "Валюта";
            // 
            // dataTicket
            // 
            this.dataTicket.AllowUserToAddRows = false;
            this.dataTicket.AllowUserToDeleteRows = false;
            this.dataTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataTicket.BackgroundColor = System.Drawing.Color.White;
            this.dataTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTicket.Location = new System.Drawing.Point(13, 69);
            this.dataTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataTicket.Name = "dataTicket";
            this.dataTicket.ReadOnly = true;
            this.dataTicket.RowHeadersVisible = false;
            this.dataTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTicket.Size = new System.Drawing.Size(775, 204);
            this.dataTicket.TabIndex = 25;
            this.dataTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTicket_CellClick);
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Location = new System.Drawing.Point(20, 374);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(80, 16);
            this.lblTicketPrice.TabIndex = 23;
            this.lblTicketPrice.Text = "Цена билета";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(138, 370);
            this.txtTicketPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(116, 21);
            this.txtTicketPrice.TabIndex = 22;
            this.txtTicketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChangeTicketPrice
            // 
            this.btnChangeTicketPrice.Location = new System.Drawing.Point(595, 292);
            this.btnChangeTicketPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeTicketPrice.Name = "btnChangeTicketPrice";
            this.btnChangeTicketPrice.Size = new System.Drawing.Size(192, 50);
            this.btnChangeTicketPrice.TabIndex = 21;
            this.btnChangeTicketPrice.Text = "Изменить цену билета";
            this.btnChangeTicketPrice.UseVisualStyleBackColor = true;
            this.btnChangeTicketPrice.Click += new System.EventHandler(this.btnChangeTicketPrice_Click);
            // 
            // cbPerfomance_
            // 
            this.cbPerfomance_.DataSource = this.спектакльBindingSource;
            this.cbPerfomance_.DisplayMember = "Наименование";
            this.cbPerfomance_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPerfomance_.FormattingEnabled = true;
            this.cbPerfomance_.Location = new System.Drawing.Point(118, 25);
            this.cbPerfomance_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPerfomance_.Name = "cbPerfomance_";
            this.cbPerfomance_.Size = new System.Drawing.Size(252, 23);
            this.cbPerfomance_.TabIndex = 20;
            this.cbPerfomance_.ValueMember = "Код спектакля";
            this.cbPerfomance_.SelectedIndexChanged += new System.EventHandler(this.cbPerfomance__SelectedIndexChanged);
            // 
            // lblPerfomance_
            // 
            this.lblPerfomance_.AutoSize = true;
            this.lblPerfomance_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerfomance_.Location = new System.Drawing.Point(9, 28);
            this.lblPerfomance_.Name = "lblPerfomance_";
            this.lblPerfomance_.Size = new System.Drawing.Size(65, 15);
            this.lblPerfomance_.TabIndex = 19;
            this.lblPerfomance_.Text = "Спектакль";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SecurityTableAdapter = null;
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
            // билетBindingSource
            // 
            this.билетBindingSource.DataMember = "Билет";
            this.билетBindingSource.DataSource = this.продажа_билетов_в_театрDataSet;
            // 
            // билетTableAdapter
            // 
            this.билетTableAdapter.ClearBeforeFill = true;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 497);
            this.Controls.Add(this.tabTickets);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTickets";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа билетов в театр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.спектакльBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажа_билетов_в_театрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зрительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассирBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.единицаИзмеренияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.физическоеЛицоBindingSource)).EndInit();
            this.tabTickets.ResumeLayout(false);
            this.tpTicketSelling.ResumeLayout(false);
            this.tpTicketSelling.PerformLayout();
            this.tpPerfomaceEdit.ResumeLayout(false);
            this.tpPerfomaceEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спектакльDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типСпектакляBindingSource)).EndInit();
            this.tpTicketPriceChange.ResumeLayout(false);
            this.tpTicketPriceChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
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
        private System.Windows.Forms.TabControl tabTickets;
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
        private System.Windows.Forms.TextBox txtDateOfPerformance;

    }
}

