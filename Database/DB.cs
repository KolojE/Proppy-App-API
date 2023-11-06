namespace Database;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

public class ProppyAppDbContext : DbContext 
{

    public ProppyAppDbContext(DbContextOptions<ProppyAppDbContext> options): base(options)
    {

    }

    public DbSet<Models.Contact> Contacts { get; set; }
}
