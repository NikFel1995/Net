using System;
using System.Windows.Forms;

namespace Theatre
{
    public partial class FormView : Form
    {
        private readonly Views _views;

        public FormView(SqlServer sqlServer)
        {
            InitializeComponent();
            _views = new Views(sqlServer);
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            InitViews();
        }


        #region View1

        private void btnSearchViewer_Click(object sender, EventArgs e)
        {
            _views.Search(txtViewer.Text, "Зритель", dataView1);
        }

        private void txtViewer_Enter(object sender, EventArgs e)
        {
            txtViewer.Clear();
        }

        private void txtViewer_Leave(object sender, EventArgs e)
        {
            CursorLeave(txtViewer);
        }

        private void txtViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _views.Search(txtViewer.Text, "Зритель", dataView1);
        }

        #endregion

        #region View2


        private void btnSearchTheatre_Click(object sender, EventArgs e)
        {
            _views.Search(txtTheatre.Text, "Театр", dataView2);
        }

        private void txtTheatre_Enter(object sender, EventArgs e)
        {
            txtTheatre.Clear();
        }

        private void txtTheatre_Leave(object sender, EventArgs e)
        {
            CursorLeave(txtTheatre);
        }

        private void txtTheatre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _views.Search(txtTheatre.Text, "Театр", dataView2);
        }
        #endregion

        #region View3

        private void btnSearchCashier_Click(object sender, EventArgs e)
        {
            _views.Search(txtCashier.Text, "Фамилия", dataView3);
        }

        private void txtCashier_Enter(object sender, EventArgs e)
        {
            txtCashier.Clear();
        }

        private void txtCashier_Leave(object sender, EventArgs e)
        {
            CursorLeave(txtCashier);
        }

        private void txtCashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _views.Search(txtCashier.Text, "Фамилия", dataView3);
        }

        #endregion


        private void InitViews()
        {
            _views.ShowView("SELECT * FROM view1", dataView1);
            _views.ShowView("SELECT * FROM view2", dataView2);
            _views.ShowView("SELECT * FROM view3", dataView3);
        }

        private static void CursorLeave(Control txt)
        {
            if (txt.Text == "")
                txt.Text = txt.Tag.ToString();
        }



    }
}
