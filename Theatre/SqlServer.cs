using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Theatre
{
    public class SqlServer
    {
        private string host;
        private string user;
        private string password;
        private string database;
        private string connectionString; // формат строки подключения:
        private SqlConnection sqlConnection;
        private string error = ""; // ошибка при выполнении SQL-запроса
        private string query; // последний выполненный запрос
        private SqlCommand sqlCommand; // SQL-команда

        public SqlServer(string dataSource, string database, string userId, string password)
        {
            this.database = database;
            connectionString = "Data Source =" + dataSource +
                                    ";Initial Catalog = " + this.database +
                                    ";Integrated Security = False; " +
                                     "User ID = " + userId + ";Password = " + password;
        }

        public SqlServer(string dataSource, string database)
        {
            this.database = database;
            connectionString = "Data Source =" + dataSource +
                                    ";Initial Catalog = " + this.database + ";Integrated Security=True;";

            //connectionString = "Data Source =" + dataSource +
            //                        ";Initial Catalog = " + this.database + ";Integrated Security=True";

        }

        public bool Open()
        {
            error = "";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                query = "Connection to MySQL " + user + "@" + host;
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                sqlConnection.Close();
                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                query = "Disconnection from MySQL " + user + "@" + host;
                return false;
            }
        }

        public string Scalar(string query)
        {
            this.query = query;
            string result;
            if (!Open()) return null;
            try
            {
                sqlCommand = new SqlCommand(this.query, sqlConnection);
                result = sqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return null;
            }
            Close();
            return result;
        }

        public DataTable SelectDataTable(string query)
        {
            DataTable dataTable;
            this.query = query;
            if (!Open()) return null;
            try
            {
                sqlCommand = new SqlCommand(this.query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dataTable = new DataTable("tempDataTable");
                dataTable.Load(sqlDataReader);
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return null;
            }
            Close();
            return dataTable;
        }


        public bool InsertData(string query)
        {
            this.query = query;
            if (!Open()) return false;
            try
            {
                sqlCommand = new SqlCommand(this.query, sqlConnection);
                sqlCommand.ExecuteReader();
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
            Close();
            return true;
        }



        /*
    public long InsertData(string query)
    {
        long rows = UpdateDate(query);
        if (rows > 0) //как минимум 1 строка была добавлена
            return Convert.ToInt64(Scalar("SELECT @@IDENTITY AS 'Identity';"));
        return 0;
    }
        */
        /*
        public long InsertData(string query) //возвращает id последней добавленной записи
        {
            long rows = UpdateDate(query);
            if (rows > 0) //как минимум 1 строка была добавлена
                return mySqlCommand.LastInsertedId;
            return 0;
        }
        */

        public int UpdateDate(string query) // метод пригоден для обновления или удаления данных, возвращает количество измененных строк
        {
            int rows; // количество измененных строк
            this.query = query;
            if (!Open()) return -1; // -1 возвращаем, так как ошибка
            try
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                rows = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                error = exception.Message;
                return -1;
            }
            Close();
            return rows;
        }

        public string AddSlashes(string text) // для экранирования текста
        {
            return text.Replace("'", @"\");
        }

        public bool SqlError()
        {
            if (error == string.Empty) return false;
            DialogResult dialogResult = MessageBox.Show(error + "\n" + "Query:\n" + query +
                            "\nПрервать - Close Program (Закрыть программу)" +
                            "\nПовтор - Repeat query (Повторить запрос)" +
                            "\nПропустить - Skip error (Пропустить ошибку)",
                            "DataBase Error " + user + "@" + database,
                            MessageBoxButtons.AbortRetryIgnore);
            if (dialogResult == DialogResult.Abort)
            {
                Application.Exit();
                return false;
            }
            if (dialogResult == DialogResult.Retry)
                return true;

            return false;
        }

        public string DateToString(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }








    }
}
