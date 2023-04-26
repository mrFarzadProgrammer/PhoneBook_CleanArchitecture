using System;
using System.Windows.Forms;

namespace UI_winForm.Forms
{
    public partial class frmEditContact : Form
    {
        private readonly int ContactId;
        public frmEditContact(int contactId)
        {
            InitializeComponent();
            ContactId = contactId;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
