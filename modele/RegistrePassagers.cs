using Passager_Reservations.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passager_Reservations.modele
{
    public class RegistrePassagers
    {
        private string cs;
        public List<Passager> listePassagers { get; set; }
        public RegistrePassagers(string cs)
        {
            
                //declarer  dao et lui donner cs
                DaoPassager daoPassager = new DaoPassager(cs);
                //le listing va etre rempli par contenu de table
                //creer la requete
                string sql = "select CodePassager, Nom, Prenom, Adresse,Telephone, Ville, Pays, Statut from passager;";
                listePassagers = daoPassager.SelectData(sql);//automatiquement reçue pas besoin de creer

                //string requete1 = "select CodePassager, Nom, Prenom, from passager;";
                //creer autre liste
                //select question 3
                //   string requete3 = "select CodePassager, Nom, Prenom from passager;";
                //   string requete4 = "SELECT CodePassager, Nom, Prenom FROM passager WHERE Statut = 'Occasionnel';";

                //  string requete5 = "SELECT CodePassager, Nom, Prenom FROM passager WHERE Statut = 'Frequent Flyer';";
            }


        
    }
}
//(2) remplire le registre avec la liste des passagers
      //listePassagers = new List<Passager>();
      //Ajouter les passager d'abord dans le registre :
      //listePassagers = daoPassager.SelectData(sql);
//
//     les ajouter 
//    internal void Ajouter(Passager passager)
//}
  //  {
      //  listePassagers.Add(passager);
    //}
//}
