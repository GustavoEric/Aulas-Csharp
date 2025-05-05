using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;   // do pacote MySqlConnector

namespace projetoCRUD.DAL
{
    internal static class ConnectionDatabase
    {
        private const string ConnectionString =
           "Server=localhost;Port=3306;Database=db_crud_csharp;User Id=root;Password=39x59gs+;";

        public static MySqlConnection OpenConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco: {ex.Message}");
                throw;
            }
        }
    }
}

