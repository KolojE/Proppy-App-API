using Database;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Models;


[Table("Contact")]
public class Contact
{
    private readonly ProppyAppDbContext db;
    [Key]
    public int Id { get;set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public int? Zip { get; set; }
    public string? Country { get; set; }
    public string? Notes { get; set; }

    internal Contact(ProppyAppDbContext _db)
    {
        db = _db ?? throw new ArgumentNullException(nameof(_db));
    }

    public Contact()
    {
    }




}
