using System;
using System.Windows.Forms;

namespace UI_winForm.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //SettingGridView(listContact);

            this.Cursor = Cursors.Default;
        }

        //private void SettingGridView(List<ContactListDto> listContact)
        //{
        //    dataGridView1.DataSource = listContact;
        //    dataGridView1.Columns[0].HeaderText = "شناسه";
        //    dataGridView1.Columns[1].HeaderText = "نام";
        //    dataGridView1.Columns[2].HeaderText = "شماره تلفن";

        //    dataGridView1.Columns[1].Width = 200;
        //    dataGridView1.Columns[2].Width = 200;
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //this.SettingGridView(listContacts);
            this.Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmDetailContact frmDetailContact = new frmDetailContact(Id);
            frmDetailContact.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddContact frmAddContact = new frmAddContact();
            frmAddContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmEditContact frmEdit = new frmEditContact(Id);
            frmEdit.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
