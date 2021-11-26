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
   public class JeuxJoueurConfig : IEntityTypeConfiguration<JeuxJoueur>
    {
        public void Configure(EntityTypeBuilder<JeuxJoueur> builder)
        {
            //PK
            builder.HasKey(s => new { s.IdJeux, s.IdJoueur }); //Clé composite

            //relation vers Joueur
            builder.HasOne<Joueur>(jj => jj.Joueur) //local foreign key
                    .WithMany(j => j.JoueursJ) //La navigation property du coté PK (Joueur)
                    .HasForeignKey(fk => fk.IdJoueur)
                    .OnDelete(DeleteBehavior.NoAction);

            //relation vers Jeux
            builder.HasOne<Jeux>(jj => jj.Jeux) //local foreign key
                    .WithMany(j => j.JeuxJ) //La navigation property du coté PK (Joueur)
                    .HasForeignKey(fk => fk.IdJeux)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
