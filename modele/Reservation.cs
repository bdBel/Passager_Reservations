using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passager_Reservations.modele
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public long CodeReservation { get; set; }
        public long CodePassager{ get; set; }
        public string DateReservation { get; set; } // format YYYY-MM-DD
        public string StatutReservation{ get; set; }
        

        public Reservation(long codePassager,string dateReservation,string statutReservation)
        {
            CodePassager = codePassager;
            DateReservation = dateReservation;
            StatutReservation = statutReservation;
        }
        public Reservation(long codePassager, long codeReservation, string dateReservation,string statutReservation)
        {
            CodeReservation = codeReservation;// cle primaire de reservation. unique
            CodePassager = codePassager; //cle etrangère ref codePassager primaire ds passager
            DateReservation = dateReservation;
            StatutReservation = statutReservation;
        }

        public override string ToString()
        {
            return "CP= "+CodePassager + " | CR= " +  CodeReservation +" "+ DateReservation + " "+StatutReservation;
        }
    }

}
