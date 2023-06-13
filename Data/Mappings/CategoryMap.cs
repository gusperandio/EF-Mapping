using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            //! Tabela
            builder.ToTable("Category");

            //! Primary Key
            builder.HasKey(x => x.Id);

            //! Identity
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn(); //! Identity(1, 1)

            //! Propriedades
            builder.Property(x => x.Name)
                .IsRequired() //! NOT NULL
                .HasColumnName("Name") //! Nome da coluna, sem essa asume o padrão
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("Slug")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            //! Índices
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")
            .IsUnique();
        }
    }
}