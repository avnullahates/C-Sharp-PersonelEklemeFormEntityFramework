using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-FA6RBVRG; Database=KD11PersonelEkleDB2; Uid=sa; Pwd=1234; ";
        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgisileri { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonelMapping());
            modelBuilder.Configurations.Add(new IletisimBilgisiMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
