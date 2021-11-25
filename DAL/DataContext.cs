using DAL.Config;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext : DbContext
    {
        #region DBSet
           public DbSet<Joueur> Joueurs { get; set; } //accès à un "repository" (Add,...) + la collection de données
        public DbSet<Jeux> Jeux { get; set; }
        #endregion

        /// <summary>
        /// Je configure la façon dont EF va se connecter à mon server
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Gaming;User Id=EFUser;Password=Test1234=;");
            optionsBuilder.EnableDetailedErrors(true);

             
        }

        /// <summary>
        /// Configuration de mes models
        /// </summary>
        /// <param name="model"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Ajout de la config pour Joueur
            new JoueurConfig().Configure(builder.Entity<Joueur>());
            //Ajout de la config pour Jeux
            new JeuxConfig().Configure(builder.Entity<Jeux>());

            
            
        }


    }
}
