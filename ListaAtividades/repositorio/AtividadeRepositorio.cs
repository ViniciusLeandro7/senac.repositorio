using ListaAtividades.banco_de_dados;
using ListaAtividades.dominio;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.repositorio
{
    internal class AtividadeRepositorio
    {
        public void Criar (string titulo)
        {
            using (var conection = Database.GetConnection()) 
            { 
                conection.Open ();

                string query = "insert into atividade (titulo) values (@titulo);";

                using (var cmd = new MySqlCommand(query, conection))
                {
                    cmd.Parameters.AddWithValue("@titulo",titulo);
                    cmd.ExecuteNonQuery (); // exercutar query
                }

            }
        }

        public void AtulizarSituacao(int id, int novaSituacao)
        {
            using (var conection = Database.GetConnection())
            {
                conection.Open();
                string query = "update atividade set situacao = @situacao where id = id;";

                using (var cmd = new MySqlCommand(query, conection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            using (var conection = Database.GetConnection()) 
            {
                conection.Open();

                string query = $"select * from atividade where situacao = {(int)Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, conection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            };
                        }
                    }
                }
            }
            return new Atividade();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = [];

            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string query = $"SELECT * from atividade where situacao = {(int)Situacao.Pendente};";
                using (var cmd = new MySqlCommand(query,conection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("Situacao")
                            });
                        }
                    }
                }
            }

            return atividades;
        }
    }
}
