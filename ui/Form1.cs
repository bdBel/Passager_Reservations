using Microsoft.Win32;
using Passager_Reservations.dao;
using Passager_Reservations.modele;
using Passager_Reservations.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passager_Reservations
{
    public partial class Form1 : Form
    {
        private string cs;
        private RegistrePassagers registrePassagers;
        private RegistreReservations registreReservations;
        //    private DaoPassager daoPassager;

        public Form1(string cs, RegistrePassagers registrePassagers, RegistreReservations registreReservations)
        {
            InitializeComponent();
            this.cs = cs;
            this.registrePassagers = registrePassagers;
            this.registreReservations = registreReservations;
            // this.daoPassager = daoPassager;
            AfficherContenu();
            //AfficherDetailReservation();
        }

        private void AfficherContenu()
        {
            //ecrire un case ici pour afficher les question case = q1, case=q2, etc....
            //puis envoyer au bon endroit 

            foreach (Passager pass in registrePassagers.listePassagers)
            {
                listePassagers.Items.Add(pass);
            }
        }
        private void AfficherDetailReservations()
        {
            //ecrire un case ici pour afficher les question case = q1, case=q2, etc....
            //puis envoyer au bon endroit 
            foreach (Reservation res in registreReservations.listeReservations)
            {
                DetailReservation.Items.Add(res);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void DetailReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if(chkDetail.isChecked)

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            AfficherDetailReservations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Passager tempPassager = new Passager();
            listePassagers.Items.Clear();
            DetailReservation.Items.Clear();
            foreach (Passager p in registrePassagers.listePassagers)
            {
                string item = $"Nom = {p.Nom}, Prénom = {p.Prenom}, CP = {p.CodePassager}";
                listePassagers.Items.Add(item);

                foreach (Reservation r in registreReservations.listeReservations)
                {
                    string itemR = $"CodeReservation = {r.CodeReservation}, StatutReservation= {r.StatutReservation}";
                    DetailReservation.Items.Add(itemR);
                }

                //AfficherContenu();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listePassagers.Items.Clear();
            DetailReservation.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> listPassagers = new List<string>();
            listePassagers.Items.Clear();

            DetailReservation.Items.Clear();
            //    string cs = "server = localhost; user = root; " +
            //  "database=northwindmysql;port=3306;";
            DaoPassager daoPassager = new DaoPassager(cs);
            string requete4 = "SELECT CodePassager, Nom, Prenom, Statut FROM passager WHERE Statut = 'Occasionnel';";

            listPassagers = daoPassager.SelectDataQuestion4(requete4);

            foreach (string passager in listPassagers)
            {
                //listePassagers est le listbox!!
                listePassagers.Items.Add(passager);
            }
        }
        //5.	Lister les passagers qui ont le statut Frequent Flyer ainsi que leurs réservations  

        private void button3_Click(object sender, EventArgs e)
        {

            List<string> listPassagers = new List<string>();

            listePassagers.Items.Clear();

            DetailReservation.Items.Clear();
            //  string cs = "server = localhost; user = root; " +
            //  "database=northwindmysql;port=3306;";
            DaoPassager daoPassager = new DaoPassager(cs);

            string requete5 = "SELECT CodePassager, Nom, Prenom, Statut FROM passager WHERE Statut = 'Frequent Flyer';";

            listPassagers = daoPassager.SelectDataQuestion4(requete5);

            foreach (string passager in listPassagers)
            {
                //listePassagers est le listbox!!
                listePassagers.Items.Add(passager);
            }
            foreach (Reservation r in registreReservations.listeReservations)
            {
                string CodePassager_Reservation = r.CodePassager.ToString();
                if (listPassagers.Contains(CodePassager_Reservation))
                {

                    string itemR = $"CodeReservation = {r.CodeReservation}, StatutReservation= {r.StatutReservation}, Date de départ = {r.DateReservation},CodePassager = {r.CodePassager}";

                    DetailReservation.Items.Add(itemR);
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            // Get selected item from the listbox
            if (listePassagers.SelectedItem != null)

            {
                var selectedItem = listePassagers.SelectedItem as Passager;
                // Check if an item is selected and successfully cast
                if (selectedItem == null)
                {
                    MessageBox.Show("Please select a passenger.");
                    return;
                }
                // Extract the CodePassager from the selected Passenger
                string codePassager = selectedItem.CodePassager.ToString();
                FormPassager formPass = new FormPassager(cs, registrePassagers, registreReservations,codePassager);
                formPass.Visible = true;
                
                }         
               }
             }            
        }
    



    

    

  
    

