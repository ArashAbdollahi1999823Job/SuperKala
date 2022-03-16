using Microsoft.EntityFrameworkCore;

namespace SuperKala.Infrastructure.Contexts.Sql
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options):base(options)
        {
            
        }
    }
}
