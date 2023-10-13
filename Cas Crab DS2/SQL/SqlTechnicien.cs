using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cas_Crab_DS2.Modeles;
//Biblio SQL/Json
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Cas_Crab_DS2.SQL
{
    internal class SqlTechnicien
    {
        public static Technicien FindId(int param)
        {
            Technicien resultat = null;

            string connectionString = "Server=localhost;UserId=root;Password=;Database=CrabDS2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT JSON_OBJECT('Matricule', Matricule, 'Nom', Nom, 'Prenom', Prenom) 
                                   FROM Technicien
                                   WHERE Id = @param";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@param", param);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userJson = reader.GetString(0);  // considering the JSON is in the first column
                            //usersJsonList.Add(userJson);
                        }
                    }
                }
            }
            return resultat;
        }
    }
}