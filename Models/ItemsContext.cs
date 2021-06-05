using Microsoft.EntityFrameworkCore;

namespace game_memo_api.Models
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<Items> Items { get; set; }
    }
}