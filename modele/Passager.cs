using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passager_Reservations.modele
{
    public class Passager
    {

        public Passager()
        {
        }

        // Properties
        public   long CodePassager { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Statut { get; set; }
        public long CodeReservation { get; set; }

        // constructeur 
        public Passager(string nom, string prenom, string adresse, string telephone, string ville, string pays, string statut)
        {
            
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Telephone = telephone;
            Ville = ville;
            Pays = pays;
            Statut = statut;
           
        }
        public Passager(long codePassager, string nom, string prenom, string adresse, string telephone, string ville, string pays, string statut)
        {
            CodePassager = codePassager;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Telephone = telephone;
            Ville = ville;
            Pays = pays;
            Statut = statut;
        }


        // Override ToString method
        public override string ToString()
        {
            return $"{CodePassager} - {Nom} {Prenom}, {Adresse}, {Telephone}, {Ville}, {Pays}, {Statut}";
        }

       
    }
}
    
