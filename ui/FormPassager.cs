using MySql.Data.MySqlClient;
using Passager_Reservations.dao;
using Passager_Reservations.modele;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Passager_Reservations.ui
{
    public partial class FormPassager : Form
    {
        private string cs;
        private RegistrePassagers registrePassagers;
        private RegistreReservations registreReservations;
        private string codePassager;

        // Constructor that takes a connection string
        public FormPassager(string cs, RegistrePassagers passagers, RegistreReservations registreReservations)
        {
            InitializeComponent();
            this.cs = cs;
            this.registreReservations = registreReservations;
            this.registrePassagers = passagers;
        }

            public FormPassager(string cs, RegistrePassagers passagers,RegistreReservations registreReservations, string codePassager)
        {
            InitializeComponent();
            this.cs = cs;
            this.registreReservations = registreReservations;
            this.registrePassagers = passagers;
            txtCP.Text = codePassager;

           // Initialize the DAO with the connection string

        }
              
            public void LoadPassagerData(int codePassager)
            {
                // Use the provided CodePassager to load passenger details
                DaoPassager daoPassager = new DaoPassager(cs);
                Passager passager = daoPassager.GetPassagerByCode(codePassager); // Implement this method in DaoPassager

                if (passager != null)
                {
                    txtNom.Text = passager.Nom;
                    txtPrenom.Text = passager.Prenom;
                    txtAdresse.Text = passager.Adresse;
                    txtTelephone.Text = passager.Telephone;
                    txtVille.Text = passager.Ville;
                    txtPays.Text = passager.Pays;
                    txtStatut.Text = passager.Statut;
                }
                else
                {
                    MessageBox.Show("Passenger not found.");
                }
            }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
          //  passé de la main
            //  string cs = "server = localhost; user = root; database=northwindmysql;port=3306;";

            string cde = "INSERT INTO passager (Nom, Prenom,  Adresse, Telephone, Ville, Pays, Statut) VALUES (@nom, @prenom, @adresse, @telephone, @ville, @pays, @statut)";

            string insertResInfo = "INSERT INTO reservation (CodePassager, DateReservation, StatutReservation) VALUES (@codePassager, @dateReservation, @statutReservation)";


            try
            {
                //inserer logique

                DaoPassager daoPassager = new DaoPassager(cs);


                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string adresse = txtAdresse.Text;
                string telephone = txtTelephone.Text;
                string ville = txtVille.Text; // Or handle image data as needed
                string pays = txtPays.Text;
                string statut = txtStatut.Text; // Or handle image data as needed


                var passager = new Passager(nom, prenom, adresse, telephone, ville, pays, statut);

                int codePassager = daoPassager.ModifierData(cde, passager);

                MessageBox.Show("code passager xxxxxxxxxxxxxx =  " + codePassager.ToString());

                if (codePassager >= 0) //retourne int
                {

                    DaoReservation daoReservation = new DaoReservation(cs);
                    string dateReservation = txtDateDepart.Text;
                    string statutReservation = "Standby";
                    //long codePassagerLong = codePassager;

                    if (codePassager != 0)
                    {
                        MessageBox.Show("Enregistrement effectué avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement effectué pour le passager");
                    }
                    //-------------------------succes----------------------------
                    //Creer la réservation en utilisant le code passager recuperé

                      if (codePassager != null) 
                      {
                        
                        using (MySqlCommand comm = new MySqlCommand(insertResInfo))
                        {
                            
                            comm.Parameters.Add("@codePassager", MySqlDbType.Int64).Value = (long)codePassager;
                            var reservation = new Reservation((long)codePassager, dateReservation, statutReservation);
                                                      
                            int ligne = daoReservation.ModifierData(insertResInfo, reservation);
                        
                            if (ligne != 0)
                            {
                                MessageBox.Show("Enregistrement réservation effectué avec succès.", ligne.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement ajouté pour la réservation.", ligne.ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement ajouté pour le passager.");
                    }
                }
            }

            catch (MySqlException exr)
            {
                
                MessageBox.Show($"MySQL Error: {exr.Message}\n{exr.StackTrace}");
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
         {
        
        if (control is TextBox)
        {
            // Cast control to TextBox and clear its text
            (control as TextBox).Clear();
         }
       }
            
     }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}