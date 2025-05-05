using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoCRUD.Models;
using MySqlConnector;
namespace projetoCRUD.DAL
{
    internal class FilmeDAL
    {
        public Filme AdicionarFilme(Filme filme)
        {
            using (var connection = ConnectionDatabase.OpenConnection())
            {
                string query = "INSERT INTO `filme` (`nomeFilme`, `dataAssistido`) VALUES (@nomeFilme, @dataAssistido)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@nomeFilme", MySqlDbType.VarChar).Value = filme.nomeFilme;
                    command.Parameters.Add("@dataAssistido", MySqlDbType.VarChar).Value = filme.dataAssistido;

                    // Execute o comando no banco de dados
                    int rowsAffected = command.ExecuteNonQuery();

                    // Verifique se a inserção foi bem-sucedida
                    if (rowsAffected > 0)
                    {
                        return filme;
                    }
                    else
                    {
                        // Se não foi inserido, retorne null ou lance uma exceção
                        return null;
                    }
                }
            }
        }
        public List<Filme> MostrarFilmes()
        {
            List<Filme> filmes = new List<Filme>();

            using (var connection = ConnectionDatabase.OpenConnection())
            {
                string query = "SELECT * FROM filme ORDER BY dataAssistido DESC";
                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Filme filme = new Filme
                        {
                            id = reader.GetInt32("id"),
                            nomeFilme = reader["nomeFilme"].ToString(),
                            dataAssistido = Convert.ToDateTime(reader["dataAssistido"]).ToString("yyyy-MM-dd")
                        };

                        filmes.Add(filme);
                    }
                }
            }

            return filmes;
        }
        public void EditarFilme(Filme filme)
        {
            using (var connection = ConnectionDatabase.OpenConnection())
            {
                string query = "UPDATE filme SET nomeFilme = @nomeFilme, dataAssistido = @dataAssistido WHERE id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = filme.id;
                    command.Parameters.Add("@nomeFilme", MySqlDbType.VarChar).Value = filme.nomeFilme;
                    command.Parameters.Add("@dataAssistido", MySqlDbType.VarChar).Value = filme.dataAssistido;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ExcluirFilme(int id)
        {
            using (var connection = ConnectionDatabase.OpenConnection())
            {
                string query = "DELETE FROM filme WHERE id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
