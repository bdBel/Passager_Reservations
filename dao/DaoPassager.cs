using MySql.Data.MySqlClient;
using Passager_Reservations.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passager_Reservations.dao
{
    public class DaoPassager : ADao<Passager>
    {

        public DaoPassager(string cs) : base(cs)
        {

        }


        public override int ModifierData(string sql, Passager passager)
        {
            int codePassager = 0;
            try
            {
                GetConnection(); //donne une connexion ouverte

                GetCommand(sql);

                Command.Parameters.AddWithValue("@nom", passager.Nom);
                Command.Parameters.AddWithValue("@prenom", passager.Prenom);
                Command.Parameters.AddWithValue("@adresse", passager.Adresse);
                Command.Parameters.AddWithValue("@telephone", passager.Telephone);
                Command.Parameters.AddWithValue("@Ville", passager.Ville);
                Command.Parameters.AddWithValue("@pays", passager.Pays);
                Command.Parameters.AddWithValue("@statut", passager.Statut);
                //Command.Parameters.AddWithValue("@CodePassager", pass.CodePassager);

                Command.ExecuteNonQuery();

                //string selectQuery = "SELECT LAST_INSERT_ID()";
                string selectQuery = "SELECT CodePassager FROM passager ORDER BY CodePassager DESC LIMIT 1";

                using (var command = new MySqlCommand(selectQuery, Conn))
                {
                    codePassager = Convert.ToInt32(Convert.ToInt32(command.ExecuteScalar()));

                    //  codePassager = Convert.ToInt32(Command.LastInsertedId);

                    //string selectQuery = "SELECT LAST_INSERT_ID()";

                    //using (var command = new MySqlCommand(selectQuery,Conn))
                    //{
                    //     codePassager = Convert.ToInt32(command.ExecuteScalar());
                    //}
                    //string selectQuery = "SELECT CodePassager FROM passager ORDER BY CodePassager DESC LIMIT 1";

                    // using (var command = new MySqlCommand(selectQuery, Conn))
                    //{
                    //}

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite, recommencez" + ex.Message);
                return 0;
            }
            finally
            {
                if (Conn != null && Conn.State == System.Data.ConnectionState.Open)
                {
                    Conn.Close();
                }
            }

            return codePassager;

        }
        //dataReader, ExecuteQuery 
        public override List<Passager> SelectData(string sql) //select ->reader cmd.execute
        {
            GetConnection();
            GetCommand(sql);
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string nom, prenom, adresse, telephone, ville, pays, statut;
            long codePassager;
            List<Passager> listePassagers = new List<Passager>();
            while (dataReader.Read())
            {
                codePassager = dataReader.GetInt64("CodePassager");
                nom = dataReader.GetString("nom");
                prenom = dataReader.GetString("Prenom");
                adresse = dataReader.GetString("adresse");
                telephone = dataReader.GetString("telephone");
                ville = dataReader.GetString("ville");
                pays = dataReader.GetString("pays");
                statut = dataReader.GetString("statut");
                listePassagers.Add(new Passager(codePassager, nom, prenom, adresse, telephone, ville, pays, statut));

            }
            dataReader.Close();
            return listePassagers;

        }
        public override List<string> SelectDataQuestion4(string sql) //select ->reader cmd.execute
        {
            GetConnection();
            GetCommand(sql);
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string nom, prenom, statut;

            List<string> listePassagersString = new List<string>();
            while (dataReader.Read())
            {
                //codePassager = dataReader.GetInt64("CodePassager");
                nom = dataReader.GetString("nom");
                prenom = dataReader.GetString("Prenom");
                //adresse = dataReader.GetString("adresse");
                //telephone = dataReader.GetString("telephone");
                //ville = dataReader.GetString("ville");
                //pays = dataReader.GetString("pays");
                statut = dataReader.GetString("statut");

                listePassagersString.Add($"{nom},  {prenom}, {statut}");

            }
            dataReader.Close();
            return listePassagersString;

        }
        public override List<string> SelectDataQuestion5(string sql) //select ->reader cmd.execute
        {
            GetConnection();
            GetCommand(sql);
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string nom, prenom, statut;

            List<string> listePassagersString = new List<string>();
            while (dataReader.Read())
            {
                //codePassager = dataReader.GetInt64("CodePassager");
                nom = dataReader.GetString("nom");
                prenom = dataReader.GetString("Prenom");
                //adresse = dataReader.GetString("adresse");
                //telephone = dataReader.GetString("telephone");
                //ville = dataReader.GetString("ville");
                //pays = dataReader.GetString("pays");
                statut = dataReader.GetString("statut");

                listePassagersString.Add($"{nom},  {prenom}, {statut}");

            }
            dataReader.Close();
            return listePassagersString;

        }
        public Passager GetPassagerByCode(int codePassager)
        {
            Passager passager = null;
            string query = "SELECT Nom, Prenom, Adresse, Telephone, Ville, Pays, Statut FROM passager WHERE CodePassager = @codePassager";

            GetConnection();
            GetCommand(query);

            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@codePassager", codePassager);
            Conn.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    passager = new Passager
                    {
                        Nom = reader["Nom"].ToString(),
                        Prenom = reader["Prenom"].ToString(),
                        Adresse = reader["Adresse"].ToString(),
                        Telephone = reader["Telephone"].ToString(),
                        Ville = reader["Ville"].ToString(),
                        Pays = reader["Pays"].ToString(),
                        Statut = reader["Statut"].ToString()
                    };
                }
            }
            return passager;
        }


    }
}


    


