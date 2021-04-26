using GamesDB.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDB.DataAccessLayer.EntityConfigurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(_ => _.Company)
                 .HasMaxLength(255);
            builder.Property(_ => _.DateRelease);

        }
    }
}
