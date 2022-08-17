using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DATA;

namespace DAL
{
    public class IletisimBilgisiMapping : EntityTypeConfiguration<IletisimBilgisi>
    {

        public IletisimBilgisiMapping()
        {
            ToTable("IletisimBilgiler");

            HasKey(x => x.PersonelID);
            Property(x => x.Eposta).HasColumnType("nvarchar").HasMaxLength(75);
            Property(x => x.Telefon).HasColumnType("varchar").HasMaxLength(15);
            Property(x => x.Eposta).HasMaxLength(255);

            //Not:Tablolar arasi 1e1 iliski oldugu icin burada tekrar iliskiyi yazmaya gerek yok. Tek mapping class inda belirmek yeterlidir.


        }
    }
}
