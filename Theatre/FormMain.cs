using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Theatre
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private SqlServer _sqlServer;

        #region Формы

        private FormConnection _formConnection;
        private FormTickets _formTickets;
        private FormView _formView;
        private FormReports _formReports;
        private FormSecurity _formSecurity;
        private FormAbout _formAbout;


        #endregion



        private static IEnumerable<Form> GetVisibleForms()
        {
            return Application.OpenForms.Cast<Form>().Where(form => form.Visible).ToList();
        }


        private void menuDataBaseConnect_Click(object sender, EventArgs e)
        {
            if (_formConnection == null || _formConnection.IsDisposed)
            {
                _formConnection = new FormConnection { MdiParent = this };
                _formConnection.Show();
            }
            else
                _formConnection.Activate();
        }

        private void menuDataBaseDisconnect_Click(object sender, EventArgs e)
        {
            var listVisibleForms = GetVisibleForms();
            foreach (var visibleForm in listVisibleForms.Where(visibleForm => visibleForm.Name != Name))
                visibleForm.Close();
            _formConnection.SqlServer = null;
            SetInitialSettings();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_formConnection != null)
                _sqlServer = _formConnection.SqlServer;
            if (_sqlServer != null)
            {
                lblStatusConnection.Text = "База данных: " + DataConnection.DataBaseName + "; IP = " +
                    DataConnection.Ip + ", Port = " + DataConnection.Port;
                lblUser.Visible = true;
                lblUser.Text = DataConnection.User;
                lblUser.ToolTipText = DataConnection.UserType;
                menuDataBaseConnect.Enabled = false;
                menuDataBaseDisconnect.Enabled = true;

                Roles();

            }
        }


        private void SetInitialSettings()
        {
            lblStatusConnection.Text = lblStatusConnection.Tag.ToString();
            lblUser.Visible = false;
            menuDataBaseConnect.Enabled = true;
            menuDataBaseDisconnect.Enabled = false;

            menuDataBaseActions.Visible =
                  menuDataBaseActionsView.Visible =
                  menuDataBaseActionsTickets.Visible =
                  menuDataBaseActionsReports.Visible =
                  menuSecurity.Visible = false;
        }


        private void Roles()
        {
            switch (DataConnection.UserType)
            {
                case "Гость":
                    menuDataBaseActions.Visible =
                        menuDataBaseActionsView.Visible = true;
                   menuSecurity.Visible= menuDataBaseActionsTickets.Visible = menuDataBaseActionsReports.Visible = false;
                    break;

                case "Кассир":
                    menuDataBaseActions.Visible =
                        menuDataBaseActionsView.Visible =
                            menuDataBaseActionsTickets.Visible =
                                menuDataBaseActionsReports.Visible = true;
                    break;

                case "Администратор":
                    menuDataBaseActions.Visible =
                        menuDataBaseActionsView.Visible =
                            menuDataBaseActionsTickets.Visible =
                                menuDataBaseActionsReports.Visible =
                                    menuSecurity.Visible = true; break;
               
            }
        }

        #region Открытие дополнительных (дочерних) MDI-окон

        private void menuDataBaseActionsView_Click(object sender, EventArgs e)
        {
            if (_formView == null || _formView.IsDisposed)
            {
                _formView = new FormView(_sqlServer) { MdiParent = this };
                _formView.Show();
            }
            else
                _formView.Activate();
        }

        private void menuDataBaseActionsTickets_Click(object sender, EventArgs e)
        {
            if (_formTickets == null || _formTickets.IsDisposed)
            {
                _formTickets = new FormTickets { MdiParent = this };
                _formTickets.Show();
            }
            else
                _formTickets.Activate();
        }

        private void menuDataBaseActionsReports_Click(object sender, EventArgs e)
        {
            if (_formReports == null || _formReports.IsDisposed)
            {
                _formReports = new FormReports { MdiParent = this };
                _formReports.Show();
            }
            else
                _formReports.Activate();
        }

        private void menuSecurity_Click(object sender, EventArgs e)
        {
            if (_formSecurity == null || _formSecurity.IsDisposed)
            {
                _formSecurity = new FormSecurity { MdiParent = this };
                _formSecurity.Show();
            }
            else
                _formSecurity.Activate();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            if (_formAbout == null || _formAbout.IsDisposed)
            {
                _formAbout = new FormAbout { MdiParent = this };
                _formAbout.Show();
            }
            else
                _formAbout.Activate();

        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (_formConnection == null || _formConnection.IsDisposed)
            {
                _formConnection = new FormConnection { MdiParent = this };
                _formConnection.Show();
            }
            else
                _formConnection.Activate();
        }
    }
}
