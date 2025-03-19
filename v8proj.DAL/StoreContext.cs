using System.Data.Entity;
using v8proj.Core.Entities.User;

namespace v8proj.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("Store")
        {
        }
        DbSet<UDTable>  UDTable { get; set; }
    }
}