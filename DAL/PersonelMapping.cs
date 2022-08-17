using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonelMapping : EntityTypeConfiguration<Personel>
    {

        public PersonelMapping()
        {

            ToTable("Personeller");

            HasKey(x => x.PersonelID);
            Property(x => x.Isim).IsRequired().HasMaxLength(30);
            Property(x => x.Soyisim).IsRequired().HasMaxLength(50);
            Property(x => x.TCKimlikNo).IsRequired().HasMaxLength(50).HasColumnType("char");
            Property(x => x.DogumTarihi).IsOptional().HasColumnType("datetime2");
            Property(x => x.Birim).IsRequired().HasMaxLength(20);

            Ignore(x => x.isimSoysisim); //Bu property DB de olmaycak. O sebeple gozardi edilmesi gerekiyor

            //Iliskiyi tanimlamak icin (1e1 iliski)
            HasRequired(X => X.IletisimBilgisi).WithRequiredPrincipal(x => x.Personel);

        }
    }
}
