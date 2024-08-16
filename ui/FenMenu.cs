using Passager_Reservations.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passager_Reservations.ui
{
    public partial class FenMenu : Form
    {
        private string cs;
        private RegistrePassagers registrePassagers;
        private RegistreReservations registreReservations;
        private string codePassager;
       // private string codePassager;

        public FenMenu(string cs, RegistrePassagers registrePassagers, RegistreReservations registreReservations)
        {
            InitializeComponent();
            this.cs = cs;
            this.registrePassagers = registrePassagers;
            this.registreReservations = registreReservations;
            //this.codePassager = codePassager;
         //   AfficherContenu(); //dans son exo . 
            
        }

        //public FenMenu(string cs, RegistrePassagers registrePassagers, RegistreReservations registreReservations)
        //{
        //    this.cs = cs;
        //    this.registrePassagers = registrePassagers;
        //    this.registreReservations = registreReservations;
        //}

        //ca fonctionne sans methode afficher. 
        //private void AfficherContenu()
        //{ 
        //   foreach(Passager pass in registrePassagers.listePassagers)
        //    {
        //        listePassagers.Items.Add(pass);
        //    }
        //}

        private void btnEdition_Click(object sender, EventArgs e)
        {
            FormPassager passagerInfo = new FormPassager(cs, registrePassagers, registreReservations);
            passagerInfo.Visible = true;

        }
        //nom de ce bouton a change
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            //form ou on va charnger les select reponses aux questions

            Form1 formResults = new Form1(cs, registrePassagers, registreReservations);
            formResults.Visible = true;
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(cs, registrePassagers, registreReservations );
            form1.Visible = true; 
            
        }
    }
}
