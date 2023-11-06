using Microsoft.AspNetCore.Mvc;
using Database;
using DataAccessLayer;
using Models;
namespace Controller;

    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ProppyAppDbContext context;

        public ContactController(ProppyAppDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<List<Contact>> GetAllAsync()
        {
            List<Contact> contacts = new ContactDataAccess(context).GetAllAsync();
            return contacts;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Contact?> GetByIdAsync([FromRoute] int id)
        {
            Contact? contact = new ContactDataAccess(context).GetById(id);
            return contact;
        }

        //create new contact
        [HttpPost]
        [Route("create")]
        [ValidateContactName]
        public async Task<Contact> CreateAsync(Contact contact)
        {
            Contact newContact =await new ContactDataAccess(context).insertContact(contact);
            return newContact;
        }

        [HttpPut]
        [Route("update")]
        [ValidateContactName]
        public async Task<Contact> UpdateAsync(Contact contact)
        {
            Contact updatedContact =await new ContactDataAccess(context).updateContact(contact);
            return updatedContact;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<bool> DeleteAsync([FromRoute] int id)
        {
            //put id in array
            int[] ids = new int[] { id };
            bool isDeleted = await new ContactDataAccess(context).DeleteAsync(ids);
            return isDeleted;
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<bool> DeleteAsync([FromBody] int[] id)
        {
            bool isDeleted = await new ContactDataAccess(context).DeleteAsync(id);
            return isDeleted;
        }

   

    }