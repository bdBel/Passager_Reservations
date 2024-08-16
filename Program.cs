using Passager_Reservations.dao;
using Passager_Reservations.modele;
using Passager_Reservations.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Passager_Reservations
{
    internal static class Program
    {

        static void Main()
        {


            //obtenir la connection string
            string cs = "server = localhost; user = root; " +
            "database=northwindmysql;port=3306;";
            RegistrePassagers registrePassagers = new RegistrePassagers(cs);
            RegistreReservations registreReservations = new RegistreReservations(cs);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenMenu(cs,registrePassagers, registreReservations));
            Application.Run(new Form1(cs,registrePassagers, registreReservations));
            //problem? si registre est vide et pas connecte a bd
            //Passager pass = new Passager();

        }
    }
}
    

