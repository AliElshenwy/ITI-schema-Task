using ITI_schema.Context;
using Microsoft.EntityFrameworkCore;

namespace ITI_schema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new object 
            iTIDbContext itiDbContext = new iTIDbContext();
                

            itiDbContext.Database.Migrate();

            itiDbContext.Students.Where(S => S.ID == 0);
        }
    }
}
