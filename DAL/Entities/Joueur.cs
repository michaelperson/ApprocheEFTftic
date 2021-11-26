using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    
    public class Joueur
    {         
        public int IdJoueur { get; set; } 
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Age 
        { 
            get {
                return (int)Math.Ceiling(((float)(DateTime.Now - DateNaissance).Days)/365);
            
            } 
       }

        public List<JeuxJoueur> JoueursJ { get; set; }

        
    }
}
