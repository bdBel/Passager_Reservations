using MySql.Data.MySqlClient;
using Passager_Reservations.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Passager_Reservations.dao
{

    public abstract class ADao<T>

    {
        private string cs;

        public ADao(string cs)
        {
            this.cs = cs;
        }
        //creer la connexion

        protected MySqlConnection Conn { get; set; }
        protected MySqlCommand Command { get; set; }

        //obetnir la connexion
        protected void GetConnection()
        {
            Conn = new MySqlConnection(cs);
            Conn.Open();
        }
        //creer la commande
        protected void GetCommand(string sql)
        {
            Command = new MySqlCommand(sql, Conn);//contient ch connexion
        }


        public abstract int ModifierData(string sql, T data);

        public abstract List<T> SelectData(string sql);
        public abstract List<string> SelectDataQuestion4(string sql);
        public abstract List<string> SelectDataQuestion5(string sql);


    }
}
