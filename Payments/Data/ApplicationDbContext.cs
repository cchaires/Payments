namespace Payments.Data
{
    using Payments.Models;

    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Payment> Payments { get; set; }
    }

}
