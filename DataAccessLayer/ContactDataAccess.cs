using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Database;
using Models;
namespace DataAccessLayer;

public class ContactDataAccess
{
    public ProppyAppDbContext context { get; }

    public ContactDataAccess(ProppyAppDbContext context)
    {
        this.context = context;
    }

    //get all contactss
    public List<Contact> GetAllAsync()
    {
        var contacts = context.Contacts.ToList();
        return contacts;
    }

    //get contact by id
    public Contact? GetById(int id)
    {
        var contact = context.Contacts.Find(id);
        if(contact == null)
        {
            return null;
        }

        return contact;
    }

    //delete contact by id/s
    public async Task<bool> DeleteAsync(int[] id)
    {
        var contacts = context.Contacts.Where(c => id.Contains(c.Id));
        Console.WriteLine(contacts);
        if(contacts == null)
        {
            return false;
        }
        context.Contacts.RemoveRange(contacts);
        await context.SaveChangesAsync();
        return true;
    }


    public async Task<Contact> insertContact(Contact contact)
    {
        context.Contacts.Add(contact);
        await context.SaveChangesAsync();
        return contact;
    }

    public async Task<Contact> updateContact(Contact contact)
    {
        context.Contacts.Update(contact);
        await context.SaveChangesAsync();
        return contact;
    }



   

}
