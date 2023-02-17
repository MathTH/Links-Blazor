using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnimedSiteLinksAPI.Moldes;

namespace UnimedSiteLinksAPI.ConfigurationDB
{
    public class UnimedLinksConfiguration : IEntityTypeConfiguration<UnimedLinksModel>
    {
        public void Configure(EntityTypeBuilder<UnimedLinksModel> builder)
        {
            builder.ToTable("Sites");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.NomeDoSite).HasColumnType("VARCHAR(100)").HasColumnName("Site").IsRequired();
            builder.Property(s => s.ImagemDoSite).HasColumnName("Imagem").IsRequired();
            builder.Property(s => s.DescricaoDoSite).HasColumnType("VARCHAR(200)").HasColumnName("Descricao").IsRequired();
            builder.Property(s => s.UrlDoSite).HasColumnType("VARCHAR(500)").HasColumnName("URL").IsRequired();
        }
    }
}
