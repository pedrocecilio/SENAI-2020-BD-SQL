using senai.Peoples.WebApi.Domains;
using senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private string connection = "Data Source = DEV21\\SQLEXPRESS; initial catalog=Peoples; user Id = sa; pwd = sa@132";

        public List<TipoUsuarioDomain> Listar()
        {
            List<TipoUsuarioDomain> tipos = new List<TipoUsuarioDomain>();

            using (SqlConnection con = new SqlConnection(connection))
            {
                // Declara a instrução a ser executada
                string querySelectAll = "SELECT IdTipoUsuario, TituloTipoUsuario FROM TipoUsuario";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader para percorrer a tabela do banco
                SqlDataReader rdr;

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Enquanto houver registros para serem lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        // Instancia um objeto genero do tipo GeneroDomain
                        TipoUsuarioDomain tipo = new TipoUsuarioDomain
                        {
                            // Atribui à propriedade IdGenero o valor da primeira coluna da tabela do banco
                            IdTipoUsuario = Convert.ToInt32(rdr[0]),

                            // Atribui à propriedade Nome o valor da coluna "Nome" da tabela do banco
                            TituloTipoUsuario = rdr["TituloTipoUsuario"].ToString()
                        };

                        // Adiciona o genero criado à lista generos
                        tipos.Add(tipo);
                    }
                }
            }

            // Retorna a lista de generos
            return tipos;
        }

        public TipoUsuarioDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                // Declara a query que será executada
                string querySelectById = "SELECT IdTipoUsuario, TituloTipoUsuario FROM TipoUsuario WHERE IdTipoUsuario = @ID";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader para receber os dados do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    // Passa o valor do parâmetro
                    cmd.Parameters.AddWithValue("@ID", id);

                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Caso o resultado da query possua registro
                    if (rdr.Read())
                    {
                        // Instancia um objeto genero
                        TipoUsuarioDomain tipo = new TipoUsuarioDomain
                        {
                            // Atribui à propriedade IdGenero o valor da coluna "IdGenero" da tabela do banco
                            IdTipoUsuario = Convert.ToInt32(rdr["IdGenero"])

                            // Atribui à propriedade Nome o valor da coluna "Nome" da tabela do banco
                            ,
                            TituloTipoUsuario = rdr["TituloTipoUsuario"].ToString()
                        };

                        // Retorna o genero com os dados obtidos
                        return tipo;
                    }

                    // Caso o resultado da query não possua registros, retorna null
                    return null;
                }
            }
        }


        public void AtualizarIdUrl(int id, TipoUsuarioDomain tipoUsuario)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                // Declara a query que será executada
                string queryUpdate = "UPDATE TipoUsuario SET TituloTipoUsuario = @TituloTipoUsuario WHERE IdTipoUsuario = @ID";

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    // Passa os valores dos parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@TituloTipoUsuario", tipoUsuario.TituloTipoUsuario);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void Deletar(int id)
        {
            // Declara a conexão passando a string de conexão
            using (SqlConnection con = new SqlConnection(connection))
            {
                // Declara a query que será executada passando o valor como parâmetro
                string queryDelete = "DELETE FROM TipoUsuario WHERE IdTipoUsuario = @ID";

                // Declara o comando passando a query e a conexão
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    // Passa o valor do parâmetro
                    cmd.Parameters.AddWithValue("@ID", id);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}   
