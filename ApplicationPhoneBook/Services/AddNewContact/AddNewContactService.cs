using ApplicationPhoneBook.DataBase;
using ApplicationPhoneBook.Dto;
using DomainPhoneBook.Entities;

namespace ApplicationPhoneBook.Services.AddNewContact
{
    public class AddNewContactService : IAddNewContactService
    {
        private readonly IDataBaseContext dataBaseContext;

        public AddNewContactService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public ResultDto Execute(AddNewContactDto NewContact)
        {
            if (string.IsNullOrEmpty(NewContact.PhoneNumber))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره موبایل اجباری می باشد. لطفا شماره موبایل هم وارد کنید."
                };
            }
            Contact contact = new Contact(NewContact.Name, NewContact.LastName, NewContact.PhoneNumber, NewContact.Company);
            dataBaseContext.Contacts.Add(contact);
            dataBaseContext.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = $"مخاطب {contact.Name} {contact.LastName} با موفقیت در دیتابیس ذخیره شد.",
            };
        }
    }
}
