using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using projetoCRUD.Models;

namespace projetoCRUD.DAL
{
    internal class UserDAL
    {
        public User Login(string login, string senha)
        {
            try
            {
                using (var connection = ConnectionDatabase.OpenConnection())
                {
                    string query = "SELECT * FROM `user` WHERE `login` = @login AND `senha` = @senha";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senha;

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    id = reader.GetInt32("id"),
                                    nome = reader.GetString("nome"),
                                    login = reader.GetString("login"),
                                    senha = reader.GetString("senha")
                                };
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);  // Exibe a mensagem de erro do MySQL
            }

            return null; // Se não encontrar nenhum usuário, retorna null
        }
        }
    }
