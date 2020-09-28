using System;
using System.Collections.Generic;
using System.Linq;
using PublicaSys.Domain.Entities;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PublicaSys.Data.Context
{
    public class PublicaSysContext : DbContext
    {
        public DbSet<Tabela> tabelas { get; set; }
        
       
        public PublicaSysContext():base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\William\Desktop\PublicaSys\PublicaSys\PublicaSys\PublicaSys.Data\Database\PublicaSysDatabase.mdf;Integrated Security=True")
        {

        }
    }
}
