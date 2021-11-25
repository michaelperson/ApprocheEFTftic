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
    public class JeuxConfig : IEntityTypeConfiguration<Jeux>
    {
        public void Configure(EntityTypeBuilder<Jeux> builder)
        {
            
            builder.ToTable("T_Jeux");
            //[Key]
            builder.HasKey("IdJeux"); 
            builder.Property(j => j.IdJeux).ValueGeneratedOnAdd();

            //Ajout des données par défaut
            builder.HasData(
                new Jeux() { IdJeux=3, Nom = "Deep Rock Galactic", Score = 9 }

            , new Jeux() { IdJeux = 5, Nom = "Pacman", Score = 5 });
         
        }
    }
}
