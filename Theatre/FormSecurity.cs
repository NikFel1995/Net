using System;
using System.Windows.Forms;

namespace Theatre
{
    public partial class FormSecurity : Form
    {
        public FormSecurity()
        {
            InitializeComponent();
        }

        private void securityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.securityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажа_билетов_в_театрDataSet);

        }

        private void FormSecurity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажа_билетов_в_театрDataSet.Security". При необходимости она может быть перемещена или удалена.
            this.securityTableAdapter.Fill(this.продажа_билетов_в_театрDataSet.Security);
            securityDataGridView.Columns[0].Visible = false;
        }
    }
}
