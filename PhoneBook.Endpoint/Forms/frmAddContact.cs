using ApplicationPhoneBook.Services.AddNewContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.Endpoint.Forms
{
    public partial class frmAddContact : Form
    {
        private readonly IAddNewContactService addNewContactService;

        public frmAddContact(IAddNewContactService addNewContactService)
        {
            InitializeComponent();
            this.addNewContactService = addNewContactService;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = addNewContactService.Execute(new AddNewContactDto
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Company = txtCompany.Text,
                Description = rtxtDescription.Text,
            });

            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
