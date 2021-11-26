using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApprocheEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataContext db = new DataContext();
            //Console.WriteLine("Choisir un jeux!");

            ////REchercher tous les jeux
            //foreach (Jeux item in db.Jeux)
            //{
            //    Console.WriteLine($"({item.IdJeux})Nom du jeux : {item.Nom} - Score : { item.Score }");
            //}

            //Console.WriteLine("Entrez le numéro du jeux choisi:");
            //int idJ = int.Parse(Console.ReadLine());

            //Jeux leJeux = db.Jeux.Find(idJ);

            //Console.WriteLine($"LE jeux : {leJeux.Nom}");

            //Jeux second = db.Jeux.FirstOrDefault(j => j.Nom == "Pacman");

            //foreach (Joueur item in db.Joueurs)
            //{
            //    Console.WriteLine(item.Nom);
            //}

            //  Joueur j1 = new Joueur();
            //  j1.Nom = "Person";
            //  j1.Prenom = "Bernard";
            //      j1.DateNaissance = new DateTime(1978, 01, 01);
            //  j1.Email = "dfgh@dfghj.be";
            //  j1.Pseudo = "Polochon";

            //  db.Joueurs.Add(j1);


            //  Joueur j2 = new Joueur();
            //  j2.Nom = "Person";
            //  j2.DateNaissance = new DateTime(2022, 01, 01);
            //  j2.Email = "dfzzh@dfghj.be";
            //  j2.Prenom = "Zorba";
            //  j2.Pseudo = "Coco";

            //  db.Joueurs.Add(j2);

            //  db.Joueurs.SingleOrDefault(m => m.IdJoueur == 1).Nom = "Relou";

            //  //Récupère l'état de mon entité
            //var t =  db.Entry<Joueur>(db.Joueurs.SingleOrDefault(m => m.IdJoueur == 1));
            //  db.Joueurs.Remove(db.Joueurs.SingleOrDefault(m => m.IdJoueur == 1));
            //  var tDel = db.Entry<Joueur>(db.Joueurs.SingleOrDefault(m => m.IdJoueur == 1));

            //  try
            //  {
            //      db.SaveChanges();
            //  }
            //  catch (DbUpdateException ex)
            //  {

            //      throw;
            //  }
            //  var A = db.Entry<Joueur>(db.Joueurs.SingleOrDefault(m => m.IdJoueur == 1));
            //  var B = db.Entry<Joueur>(db.Joueurs.SingleOrDefault(m => m.Pseudo == "Coco"));
            //  var C = db.Entry<Joueur>(db.Joueurs.SingleOrDefault(m => m.Pseudo == "Polochon"));

            using (DataContext dc = new DataContext())
            {
                //inner join Jeux et JeuxJ puis inner join entre jeuxj et joueur
                List<Jeux> JJ = dc.Jeux.Include(j=>j.JeuxJ).ThenInclude(m=>m.Joueur).ToList();
                foreach (Jeux item in JJ)
                {
                    Console.WriteLine($"Nom du jeux : {item.Nom}");
                    Console.WriteLine("Joueurs :");
                    foreach (Joueur J in item.JeuxJ.Select(m=>m.Joueur)) //inner join
                    {
                        Console.WriteLine($"Nom: {J.Nom}");
                    }
                }               
            }

        }
    }
}
