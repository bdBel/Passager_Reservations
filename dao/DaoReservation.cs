using MySql.Data.MySqlClient;
using Passager_Reservations.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Passager_Reservations.dao
{
    public class DaoReservation : ADao<Reservation>
    {
        public DaoReservation(string cs) : base(cs)
        {

        }

        //public override int ModifierData(string sql, Reservation reservation)
        //{
        //    try
        //    {
        //        long codePassagerLong = 0;   
        //        // Ensure the connection is opened
        //        GetConnection(); // Opens the connection (assumed to be done properly in GetConnection)

        //        // Initialize command
        //        GetCommand(sql); // Initializes Command with the provided SQL

        //        // Add parameters to the command

        //            // Add parameters with appropriate types
        //            Command.Parameters.AddWithValue("@dateReservation", reservation.DateReservation);
        //            Command.Parameters.AddWithValue("@statutReservation", reservation.StatutReservation);

        //            // Define and add the CodePassager parameter with type Int64
        //          //  MySqlParameter codePassagerParam = new MySqlParameter("@codePassager", MySqlDbType.Int64);
        //          //  codePassagerParam.Value = codePassagerLong;
        //          //  Command.Parameters.Add(codePassagerParam);


        //         // Execute the command and get the number of affected rows
        //        int lignes = Command.ExecuteNonQuery();

        //        // Optionally log or handle success
        //       //MessageBox.Show("Enregistrement effectué avec succès"); 
        //        return lignes;
        //    }
        //       catch (Exception ex)
        //    {
        //        // Log the exception or handle it accordingly
        //        MessageBox.Show($"Une erreur s'est produite: {ex.Message}"); // Consider logging instead of showing message boxes in production code

        //        return 0;
        //    }
        //    finally
        //    {
        //        // Ensure the connection is closed
        //        Conn.Close(); // Make sure Conn is properly initialized in GetConnection
        //    }
        //}
        public override int ModifierData(string sql, Reservation reservation)
        {
            try
            {
                // Ensure the connection is opened
                GetConnection(); // Opens the connection (assumed to be done properly in GetConnection)

                // Initialize command
                GetCommand(sql); // Initializes Command with the provided SQL

                // Clear existing parameters if any
                Command.Parameters.Clear();

                // Add parameters with appropriate types
                Command.Parameters.AddWithValue("@dateReservation", reservation.DateReservation);
                Command.Parameters.AddWithValue("@statutReservation", reservation.StatutReservation);

                // Define and add the CodePassager parameter with type Int64
                // Ensure codePassagerLong is properly assigned from the reservation object
                long codePassagerLong = reservation.CodePassager; // Assuming Reservation has a CodePassager property
                Command.Parameters.Add("@codePassager", MySqlDbType.Int64).Value = codePassagerLong;

                // Execute the command and get the number of affected rows
                int lignes = Command.ExecuteNonQuery();

                // Optionally log or handle success
                //MessageBox.Show("Enregistrement effectué avec succès"); 
                return lignes;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                MessageBox.Show($"Une erreur s'est produite: {ex.Message}"); // Consider logging instead of showing message boxes in production code

                return 0;
            }
            finally
            {
                // Ensure the connection is closed
                Conn.Close(); // Make sure Conn is properly initialized in GetConnection
            }
        }


        public override List<Reservation> SelectData(string sql)
        {
            GetConnection();
            GetCommand(sql);

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Reservation> listeReservations = new List<Reservation>();
            long codePassager; //cle étranger
            long codeReservation; //cle primaire
            string statutReservation;//statit
            //long[] listeCodeReservation;
            string dateReservation;
              while (dataReader.Read())
            {

                codeReservation = dataReader.GetInt64("CodeReservation");
                codePassager = dataReader.GetInt64("CodePassager");
                dateReservation = dataReader.GetString("DateReservation");
                statutReservation = dataReader.GetString("StatutReservation");
                listeReservations.Add(new Reservation(codePassager,codeReservation, dateReservation,statutReservation));
                
            }
            dataReader.Close();
            return listeReservations;
        }

        public override List<string> SelectDataQuestion4(string sql)
        {
            return null;
        }

        public override List<string> SelectDataQuestion5(string sql)
        {
            return null;
        }
    }
}
