using Passager_Reservations.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passager_Reservations.modele
{
    public class RegistreReservations

    {
        private string cs;
        public List<Reservation> listeReservations { get; set; }
        public RegistreReservations(string cs)
        {
            //declarer  dao et lui donner cs
            DaoReservation daoRes = new DaoReservation(cs);
            this.cs = cs;
            //creer la requete
            //string sql = "select CodeReservation, CodePassager, DateReservation from reservation";
             string sql = "SELECT CodePassager, CodeReservation, DateReservation, StatutReservation FROM reservation;";                
             listeReservations = daoRes.SelectData(sql); //automatiquement reçue pas besoin de creer

            

            //string sql = 
        }
    }
}

    

