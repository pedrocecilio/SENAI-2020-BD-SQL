using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private string connection = "Data Source = DEV21\\SQLEXPRESS;initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";

        public List<FuncionarioDomain> List()
        {

            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                string queryVisuAll = "SELECT * FROM Funcionarios";

                conn.Open();

                SqlDataReader reader;

                using (SqlCommand cmmd = new SqlCommand(queryVisuAll, conn))
                {
                    reader = cmmd.ExecuteReader();

                    while(reader.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            IdFuncionario = Convert.ToInt32(reader[0]),

                            Nome = reader["Nome"].ToString(),

                            Sobrenome = reader["Sobrenome"].ToString(),

                        };

                        funcionarios.Add(funcionario);
                    }
                    return funcionarios;

                }

            }
            
        }



    }
}
