
using System.Windows.Forms;

namespace Theatre
{
    internal class Views
    {
        private readonly SqlServer _sqlServer;

        public Views(SqlServer sqlServer)
        {
            _sqlServer = sqlServer;
        }

        public void ShowView(string query, DataGridView data)
        {
            do
            {
                data.DataSource = _sqlServer.SelectDataTable(query);
            } while (_sqlServer.SqlError());
        }

        public void Search(string search, string columnName, DataGridView data)
        {
            string filter = search;

            int numberRow = data.Columns[columnName].Index;

            if (string.IsNullOrEmpty(filter) || numberRow < 0) return;


            for (int i = 0; i < data.RowCount; i++)
            {
                data.Rows[i].Selected = false;
                for (int j = numberRow; j <= numberRow; j++)
                    if (data.Rows[i].Cells[j].Value != null)
                        if (data.Rows[i].Cells[j].Value.ToString().Contains(filter))
                        {
                            data.Rows[i].Selected = true;
                            break;
                        }
            }

        }
    }
}
