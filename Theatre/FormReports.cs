using Microsoft.Office.Interop.Excel;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Theatre
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet1.report1". При необходимости она может быть перемещена или удалена.
            this.report1TableAdapter.Fill(this.продажа_билетов_в_театрDataSet1.report1);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                report2TableAdapter.Fill(продажа_билетов_в_театрDataSet.report2, viewerToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                report3TableAdapter.Fill(продажа_билетов_в_театрDataSet.report3, dateBeginToolStripTextBox.Text, dateEndToolStripTextBox.Text, perfomanceToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                report4TableAdapter.Fill(продажа_билетов_в_театрDataSet.report4, cashierToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                report5TableAdapter.Fill(продажа_билетов_в_театрDataSet.report5, viewerToolStripTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lblSaveReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedTab = tabReports.SelectedTab;
            int index = selectedTab.TabIndex;
            switch (index)
            {
                case 0:
                    if (report1DataGridView.RowCount != 0)
                        SaveDataFromTable(report1DataGridView);
                    break;
                case 1:
                    if (report2DataGridView.RowCount != 0)
                    SaveDataFromTable(report2DataGridView);
                    break;
                case 2:
                    if (report3DataGridView.RowCount != 0)
                    SaveDataFromTable(report3DataGridView);
                    break;
                case 3:
                    if (report4DataGridView.RowCount != 0)
                    SaveDataFromTable(report4DataGridView);
                    break;
                case 4:
                    if (report5DataGridView.RowCount != 0)
                    SaveDataFromTable(report5DataGridView);
                    break;
                default:
                    MessageBox.Show("Ошибка при сохранении отчета!"); break;
            }
        }

        /// <summary>
        /// Сохранение данных из таблицы в файл
        /// <param name="dataTable">Таблица dataGridView</param>
        /// </summary>
        private void SaveDataFromTable(DataGridView dataTable)
        {
            Application exApp = new Application { Visible = false };
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;

            for (int i = 0; i < dataTable.ColumnCount; i++)
            {
                workSheet.Cells[1, (i + 1)] = dataTable.Columns[i].HeaderText;
            }


            int rowExcel = 2; //начать со второй строки.


            for (int i = 0; i < dataTable.ColumnCount; i++)
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    //заполняем строку
                    workSheet.Cells[j + 2, i + 1] = dataTable[i, j].Value.ToString();
                }

            string pathToXmlFile = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Выберите место для сохранения файла",
                DefaultExt = "*.xlsx;*.xls",
                Filter = " Excel 2007(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls"
            };


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToXmlFile = saveFileDialog.FileName;
                workSheet.SaveAs(pathToXmlFile);
            }
            exApp.Quit();


            DialogResult dialog = MessageBox.Show("Открыть Excel-файл?", "Открываем?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Process.Start(pathToXmlFile);

        }


    }
}
