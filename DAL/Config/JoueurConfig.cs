using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    //Fluent API - L'unique façon de bien travailler !!!
    public class JoueurConfig : IEntityTypeConfiguration<Joueur>
    {
        public void Configure(EntityTypeBuilder<Joueur> builder)
        {
            // [Table("T_Joueur")]
            builder.ToTable("T_Joueur");
            //[Key]
            builder.HasKey("IdJoueur");
            //     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            builder.Property(j => j.IdJoueur).ValueGeneratedOnAdd();

            //Ajoutons une contrainte sur l'email
            builder.HasCheckConstraint("CK_EmailVerification", "Email like '__%@__%.__%'");

            //Contrainte d'unicité
            builder.HasIndex(x => x.Email).HasDatabaseName("UK_Email").IsUnique(true);

            //Taille maximale de 300 caractère pour l'email
            builder.Property("Email").HasMaxLength(300);

            //Ignore la propriété Age
            builder.Ignore(x => x.Age);
        }
    }
}
