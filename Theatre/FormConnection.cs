using System;
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

            string ip = txtIp.Text;
            string port = txtPort.Text;

            string dataSource = ip + "," + port;

            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show(@"Пожалуйста, заполните IP-адрес и/или порт!", @"Внимание!");
                return;
            }

            SqlServer = new SqlServer(dataSource, DataConnection.DataBaseName);

            if (SqlServer.Open())
            {
                MessageBox.Show(@"Успешное подключение!");
                DataConnection.Ip = ip;
                DataConnection.Port = port;
                this.Close();

            }
            else
                MessageBox.Show("Ошибка при подключении!\nПроверьте корректность введенных данных", @"Внимание!");
            SqlServer.Close();

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
    }
}
