using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Repositories
{
    public class FilmesRepository : IFilmesRepository
    {

        private string connection = " DATA SOURCE = DEV21\\SQLEXPRESS;initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";
        

        public void Register(FilmeDomain filme)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {

                string queryInsert = "INSERT INTO Filmes (Titulo, IdGenero) VALUES (@Titulo , @IdGenero)";

                
                SqlCommand cmmd = new SqlCommand(queryInsert, conn);

                
                cmmd.Parameters.AddWithValue("@Titulo", filme.Titulo);
                cmmd.Parameters.AddWithValue("@IdGenero", filme.IdGenero);

                
                conn.Open();

                
                cmmd.ExecuteNonQuery();

            }

        }

        public List<FilmeDomain> Listar()
        {

            List<FilmeDomain> filmes = new List<FilmeDomain>();

            using (SqlConnection conn = new SqlConnection(connection))
            {

                string queryVisuAll = "SELECT * FROM Filmes";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmmd = new SqlCommand(queryVisuAll, conn))
                {

                    reader = cmmd.ExecuteReader();

                    while (reader.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(reader[0]),

                            IdGenero = Convert.ToInt32(reader["IdGenero"]),

                            Titulo = reader["Titulo"].ToString(),



                        };

                        filmes.Add(filme);
                    }

                    return filmes;

                }

            }

        }

        public FilmeDomain SearchbyId(int id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string querySearchById = "SELECT IdFilme, Titulo FROM Filmes WHERE IdFilme = @ID";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmmd = new SqlCommand(querySearchById, conn))
                {
                    cmmd.Parameters.AddWithValue("@ID", id);


                    reader = cmmd.ExecuteReader();


                    if (reader.Read())
                    {

                        FilmeDomain filme = new FilmeDomain
                        {

                            IdFilme = Convert.ToInt32(reader["IdFilme"]),

                            Titulo = reader["TiTulo"].ToString()
                        };

                        return filme;
                    }


                    return null;


                }

            }
        }

        public void UpdateUrl(int id, FilmeDomain filme)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string queryUpdate = "UPDATE Filmes SET Titulo = @Titulo, IdGenero = @IdGenero WHERE IdFilme = @ID";

                using (SqlCommand cmmd = new SqlCommand(queryUpdate, conn))
                {

                    cmmd.Parameters.AddWithValue("@Titulo", filme.Titulo);
                    cmmd.Parameters.AddWithValue("@IdGenero", filme.IdGenero);
                    cmmd.Parameters.AddWithValue("@ID", filme.IdFilme);

                    conn.Open();

                    cmmd.ExecuteNonQuery();

                }

            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string queryDelete = "DELETE FROM Filmes WHERE IdFilme = @ID";

                using (SqlCommand cmmd = new SqlCommand(queryDelete, conn))
                {

                    cmmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();

                    cmmd.ExecuteNonQuery();
                }
            }
        }



    }
}
