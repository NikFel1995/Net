using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Theatre
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }


        public SqlServer SqlServer { get; protected internal set; }


        private void FormConnection_Load(object sender, EventArgs e)
        {
            comboUserType.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Login()) return;

            MessageBox.Show("Успешное подключение!");
            this.Close();
        }

        private bool Login()
        {
            string ip = txtIp.Text;
            string port = txtPort.Text;

            string dataSource = ip + "," + port;


            string user = txtUser.Text;
            string password = txtPassword.Text;
            string userType = comboUserType.Text;

            if (!CorrectData(ip, port, user, password, userType)) return false;


            SqlServer = new SqlServer(dataSource, DataConnection.DataBaseName);

            string query = "SELECT * FROM Security s WHERE s.[Login] = '" +
                           user + "' AND s.Password = '" + password + "'";

            int rowsCount;
            do
            {
                var identity = SqlServer.SelectDataTable(query);
                rowsCount = identity.Rows.Count;
            } while (SqlServer.SqlError());

            try
            {
                if (rowsCount == 1)
                {
                    DataConnection.UserType = userType;
                    DataConnection.User = user;
                    DataConnection.Password = password;
                    DataConnection.Ip = ip;
                    DataConnection.Port = port;
                }
                else if (rowsCount <= 0)
                    MessageBox.Show(@"Имя пользователя или пароль некорректны!");
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка");
            }

            finally
            {
                txtUser.Clear();
                txtPassword.Clear();
            }
            return true;
        }

        private static bool CorrectData(string ip, string port, string user, string password, string userType)
        {
            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show(@"Пожалуйста, заполните IP-адрес и/или порт!", @"Внимание!");
                return false;
            }

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(@"Пожалуйста, заполните имя пользователя и/или пароль!", @"Внимание!");
                return false;
            }


            if (userType == "Администратор" && user != "Admin")
            {
                MessageBox.Show("Проверьте тип пользователя!");
                return false;
            }

            if (userType != "Администратор" && user == "Admin")
            {
                MessageBox.Show("Проверьте тип пользователя!");
                return false;
            }
            return true;
        }

        private void lblGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SqlServer = new SqlServer(DataConnection.DataDefaultSourse, DataConnection.DataBaseName);
            if (SqlServer.Open())
            {
                MessageBox.Show(@"Успешное подключение!");
                DataConnection.Ip = ".";
                DataConnection.Port = "1433";
                DataConnection.User = "user";
                DataConnection.UserType = "Гость";

                this.Close();

            }
            else
                MessageBox.Show("Ошибка при подключении!\nПроверьте корректность введенных данных", @"Внимание!");
            SqlServer.Close();

        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.Match(e.KeyChar.ToString(), @"[0-9]").Success &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';
        }
    }
}
