using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP03_ASP_Leonardo_Ewbank.Controllers;
using TP03_ASP_Leonardo_Ewbank.Models;

namespace TP03_ASP_Leonardo_Ewbank.Repository
{
    public class AniversarianteRepository
    {
        public string ConnectionStirng { get; set; }


        //Configuracao para a aplicacao receber a conexao da base de dados
        public AniversarianteRepository(IConfiguration configuration)
        {
            this.ConnectionStirng = configuration.GetConnectionString("AniversariantesConnection");
        }
        //Conectar ao banco de dados

        public void Salvar(Aniversariantes aniversariante)
        {
            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if(connection.State != System.Data.ConnectionState.Open)
                     connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = "INSERT INTO Aniversariantes (Id, Nome, DataAniversario) VALUES(@P1,@P2,@P3)";
                sqlcommand.Parameters.AddWithValue("P1", aniversariante.Id);
                sqlcommand.Parameters.AddWithValue("P2", aniversariante.nome + " " + aniversariante.sobrenome );
                sqlcommand.Parameters.AddWithValue("P3", aniversariante.DataNascimento);

                sqlcommand.ExecuteNonQuery();
                connection.Close();

            }
        }
        public void Editar(Aniversariantes aniversariante)
        {
            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = @"UPDATE Aniversariantes SET 
                                            Nome = @P2, 
                                            DataAniversario = @P3
                                            WHERE Id = @P1";
                sqlcommand.Parameters.AddWithValue("P1", aniversariante.Id);
                sqlcommand.Parameters.AddWithValue("P2", aniversariante.nome + " " + aniversariante.sobrenome);
                sqlcommand.Parameters.AddWithValue("P3", aniversariante.DataNascimento);

                sqlcommand.ExecuteNonQuery();
                connection.Close();

            }
        }
        public void Deletar(Guid Id)
        {
            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = @"Delete FROM Aniversariantes 
                                           WHERE Id = @P1"; 
                sqlcommand.Parameters.AddWithValue("P1", Id);

                sqlcommand.ExecuteNonQuery();
                connection.Close();

            }
        }
        public List<Aniversariantes> ListarTodos()
        {
            List<Aniversariantes> todos = new List<Aniversariantes>();


            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = @"SELECT Id, Nome, DataAniversario FROM Aniversariantes ORDER BY abs(DATEDIFF(DAYOFYEAR,DATEPART(DAYOFYEAR,convert(date,DataAniversario,103)),GETDATE())) DESC";

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    Aniversariantes aniversariante = new Aniversariantes()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        nome = reader["Nome"].ToString().Split(" ").First(),
                        sobrenome = reader["Nome"].ToString().Split(" ").Last(),
                        DataNascimento = DateTime.Parse(reader["DataAniversario"].ToString())
                    };
                    todos.Add(aniversariante);
                }


                connection.Close();

            }
            return todos;
        }

        public Aniversariantes BuscarPorId(Guid id)
        {
            List<Aniversariantes> todos = new List<Aniversariantes>();


            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = @"SELECT Id, Nome, DataAniversario FROM Aniversariantes WHERE Id = @P1";
                sqlcommand.Parameters.AddWithValue("P1", id);

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    Aniversariantes aniversariante = new Aniversariantes()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        nome = reader["Nome"].ToString().Split(" ").First(),
                        sobrenome = reader["Nome"].ToString().Split(" ").Last(),
                        DataNascimento = DateTime.Parse(reader["DataAniversario"].ToString())
                    };
                    todos.Add(aniversariante);
                }


                connection.Close();

            }
            return todos.FirstOrDefault();
        }

        public List<Aniversariantes> BuscarPorNome(string nome)
        {
            List<Aniversariantes> todos = new List<Aniversariantes>();


            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = "SELECT Id, Nome, DataAniversario FROM Aniversariantes WHERE Nome LIKE '%'+@P1+'%'";
                sqlcommand.Parameters.AddWithValue("P1", nome);

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    Aniversariantes aniversariante = new Aniversariantes()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        nome = reader["Nome"].ToString().Split(" ").First(),
                        sobrenome = reader["Nome"].ToString().Split(" ").Last(),
                        DataNascimento = DateTime.Parse(reader["DataAniversario"].ToString())
                    };
                    todos.Add(aniversariante);
                }


                connection.Close();

            }
            return todos;
        }

        public List<Aniversariantes> BuscarPorData(DateTime data)
        {
            List<Aniversariantes> todos = new List<Aniversariantes>();


            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = @"SELECT Id, Nome, DataAniversario FROM Aniversariantes WHERE LEFT(DataAniversario,6) = LEFT (convert(nvarchar(10),getdate()),6)";
                sqlcommand.Parameters.AddWithValue("P1", data.Date.ToString("dd/MM"));

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    Aniversariantes aniversariante = new Aniversariantes()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        nome = reader["Nome"].ToString().Split(" ").First(),
                        sobrenome = reader["Nome"].ToString().Split(" ").Last(),
                        DataNascimento = DateTime.Parse(reader["DataAniversario"].ToString())
                    };
                    todos.Add(aniversariante);
                }
                connection.Close();

            }
  



            return todos;
        }



        public List<Aniversariantes> ListarTodosPorData()   
        {
            List<Aniversariantes> todos = new List<Aniversariantes>();


            //COnectar ao banco de dados, deve-se criar uma conexao
            using (var connection = new SqlConnection(this.ConnectionStirng))
            {
                //abrir a conexao com o banco de dados
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                //deve-se mandar um comando para o banco de dados
                SqlCommand sqlcommand = connection.CreateCommand();

                //Colocar o comando SQL
                sqlcommand.CommandText = @"SELECT *
                                            FROM Aniversariantes
                                            WHERE DATEPART(DAYOFYEAR,convert(date,DataAniversario,103)) - DATEPART(DAYOFYEAR,GETDATE()) >= 0
                                            ORDER BY ABS(DATEPART(DAYOFYEAR,convert(date,DataAniversario,103)) - DATEPART(DAYOFYEAR,GETDATE()))";
                    
                    
                    //@"SELECT Id, Nome, DataAniversario,abs(DATEDIFF(DAYOFYEAR,DATEPART(DAYOFYEAR,convert(date,DataAniversario,103)),DATEPART(DAYOFYEAR,GETDATE()))) FROM Aniversariantes 
                    //ORDER BY abs(DATEDIFF(DAYOFYEAR,DATEPART(DAYOFYEAR,convert(date,DataAniversario,103)),DATEPART(DAYOFYEAR,GETDATE()))) ASC";

                    //@"SELECT Id, Nome, DataAniversario FROM Aniversariantes 
                    //ORDER BY abs(DATEDIFF(DAYOFYEAR,DATEPART(DAYOFYEAR,convert(date,DataAniversario,103)),GETDATE())) ASC";


                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    Aniversariantes aniversariante = new Aniversariantes()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        nome = reader["Nome"].ToString().Split(" ").First(),
                        sobrenome = reader["Nome"].ToString().Split(" ").Last(),
                        DataNascimento = DateTime.Parse(reader["DataAniversario"].ToString())
                    };
                    todos.Add(aniversariante);
                }


                connection.Close();

            }
            return todos;
        }






    }
}
