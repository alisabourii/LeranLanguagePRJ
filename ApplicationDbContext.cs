using LLP.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;


namespace LLP.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions) 
        { 
        }
        public DbSet<Employee> Employees { get; set; }
        /*
            use LLPDatabase;
            INSERT INTO dbo.DeutschWort(wort,Erlauterung,Datum)
            VALUES('Tag','Guten Tag','2024-01-30');

            use LLPDatabase;
            INSERT INTO dbo.EnglishWords(Word,Explanation,NowDate)
            VALUES('Resume','This is my Resume of last 2 years','2024-01-30');
        */

    }

}
