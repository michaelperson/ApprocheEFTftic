using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class JeuxJoueur
    {
        public int IdJoueur { get; set; }
        public int IdJeux { get; set; }

        public Joueur Joueur { get; set; }
        public Jeux Jeux { get; set; }


    }
}
