using System;
using System.Windows.Forms;

namespace Theatre
{
    public partial class FormTickets : Form
    {

        private SqlServer _sqlServer;
        private int playId; // номер (id) спектакля
        private int ticketId; // номер (id) билета


        public FormTickets()
        {
            InitializeComponent();

            _sqlServer = new SqlServer(".", "Продажа билетов в театр");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Тип_спектакля". При необходимости она может быть перемещена или удалена.
            this.тип_спектакляTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Тип_спектакля);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Единица_измерения". При необходимости она может быть перемещена или удалена.
            this.единица_измеренияTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Единица_измерения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Место". При необходимости она может быть перемещена или удалена.
            this.местоTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Место);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Физическое_лицо". При необходимости она может быть перемещена или удалена.
            this.физическое_лицоTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Физическое_лицо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Кассир". При необходимости она может быть перемещена или удалена.
            this.кассирTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Кассир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Зритель". При необходимости она может быть перемещена или удалена.
            this.зрительTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Зритель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Спектакль". При необходимости она может быть перемещена или удалена.
            this.спектакльTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Спектакль);
            спектакльDataGridView.Columns[0].Visible = false;
        }


        #region Продажа билетов

        private int IdCashier(int idIndividual)
        {
            int result;
            string query = "SELECT Кассир.[Код кассира],Кассир.[Код физического лица] " +
                           "FROM dbo.Кассир " +
                           "WHERE Кассир.[Код физического лица] = " + idIndividual;
            do
            {
                result = Convert.ToInt32(_sqlServer.Scalar(query));
            } while (_sqlServer.SqlError());

            return result;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            int perfomanceId = Convert.ToInt32(cbPerfomance.SelectedValue);
            int spectatorId = Convert.ToInt32(cbSpectator.SelectedValue);
            int cashierId = Convert.ToInt32(cbCashier.SelectedValue);
            int placeId = Convert.ToInt32(cbPlace.SelectedValue);
            int currencyid = Convert.ToInt32(cbCurrency.SelectedValue);

            var cassirId = IdCashier(cashierId);

            int price = Convert.ToInt32(txtPrice.Text);
            string dateOfPerformance = txtDateOfPerformance.Text;
            string playTime = txtPlayTime.Text;
            string dateOfTicketSales = txtDateOfTicketSales.Text;


            string query = "INSERT INTO dbo.Билет (" +
                           "[Код спектакля]," +
                           "[Код зрителя], " +
                           "[Код кассира], " +
                           "[Код места], " +
                           "[Код единицы измерения цены], " +
                           "Цена, " +
                           "[Дата спектакля], " +
                           "[Время начала спектакля], " +
                           "[Дата продажи]) VALUES " +
                           "(" + perfomanceId + ", " +
                           spectatorId + ", " +
                           cassirId + ", " +
                           placeId + ", " +
                           currencyid + ", " +
                           price + ", '" +
                           dateOfPerformance + "', '" +
                           playTime + "', '" +
                           dateOfTicketSales + "');";
  

           

            do
            {
                var res = _sqlServer.InsertData(query);
                MessageBox.Show(res ? "Данные успешно добавлены!" : "Ошибка при добавлении данных!");
            } while (_sqlServer.SqlError());
        }

        #endregion

        #region Изменение данных о спектакле

        private void btnChangePerfomance_Click(object sender, EventArgs e)
        {
            ShowInfo(true);
        }


        private void ShowInfo(bool visible)
        {
            lblPlayTitle.Visible = lblPlayType.Visible = lblDuration.Visible =
                txtPlayTitle.Visible = cbPlayType.Visible = txtDuration.Visible =
                    btnSavePerfomance.Visible = visible;
        }

        private void btnSavePerfomance_Click(object sender, EventArgs e)
        {
            int playType = Convert.ToInt32(cbPlayType.SelectedValue);
            string playTitle = txtPlayTitle.Text;
            string duration = txtDuration.Text;

            do
            {
                string query = "UPDATE Спектакль SET " +
                               "[Код типа спектакля] = " + playType + "," +
                               "Наименование = '" + playTitle + "'," +
                               "Продолжительность = '" + duration + "' " +
                               "WHERE [Код спектакля] = " + playId;
                var res = _sqlServer.UpdateDate(query);
                MessageBox.Show(res == 1 ? "Данные успешно обновлены!" : "Ошибка при обновлении данных!");      //!!!!
                this.спектакльTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Спектакль);
                ShowInfo(false);

            } while (_sqlServer.SqlError());
        }

        private void спектакльDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                playId = Convert.ToInt32(спектакльDataGridView[0, e.RowIndex].Value);

                txtPlayTitle.Text = спектакльDataGridView["Perfomance", e.RowIndex].Value.ToString();
                txtDuration.Text = спектакльDataGridView["PerfomanceDuration", e.RowIndex].Value.ToString();

                do
                {
                    string query =
                        "SELECT [Тип спектакля].Наименование ,Спектакль.[Код типа спектакля] FROM dbo.Спектакль INNER JOIN dbo.[Тип спектакля] ON Спектакль.[Код типа спектакля] = [Тип спектакля].[Код типа спектакля] WHERE Спектакль.[Код типа спектакля] =" +
                        спектакльDataGridView[1, e.RowIndex].Value;
                    ;

                    var result = _sqlServer.Scalar(query);
                    cbPlayType.Text = result;
                } while (_sqlServer.SqlError());
            }
        }

        #endregion

        #region Изменение цены билета

        private void btnChangeTicketPrice_Click(object sender, EventArgs e)
        {
            int ticketPrice = Convert.ToInt32(txtTicketPrice.Text);

            do
            {
                string query = "UPDATE Билет SET Цена = " + ticketPrice +
                               "WHERE [Код билета] = " + ticketId;

                var result = _sqlServer.UpdateDate(query);
                MessageBox.Show(result == 1 ? "Данные успешно обновлены!" : "Ошибка при обновлении данных!");
                ShowTicketData();

            } while (_sqlServer.SqlError());
        }

        private void cbPerfomance__SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTicketData();
        }

        private void ShowTicketData()
        {
            string perfomanceName = cbPerfomance_.Text;
            do
            {
                string query =
                    "SELECT  Билет.[Код билета], Билет.[Дата спектакля],Билет.[Время начала спектакля],Билет.Цена, [Единица измерения].[Краткое наименование] FROM dbo.Билет INNER JOIN dbo.Спектакль ON Билет.[Код спектакля] = Спектакль.[Код спектакля] INNER JOIN dbo.[Единица измерения] ON Билет.[Код единицы измерения цены] = [Единица измерения].[Код единицы измерения] WHERE Спектакль.Наименование = '" +
                    perfomanceName + "'";
                var result = _sqlServer.SelectDataTable(query);
                dataTicket.DataSource = result;
                dataTicket.Columns[0].Visible = false;
                dataTicket.Columns[4].Visible = false;
            } while (_sqlServer.SqlError());
        }

        private void dataTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ticketId = Convert.ToInt32(dataTicket[0, e.RowIndex].Value);
                txtTicketPrice.Text = dataTicket[3, e.RowIndex].Value.ToString();
                lblTicketCurrency.Text = dataTicket[4, e.RowIndex].Value.ToString();
            }
        }

        #endregion

    }
}
