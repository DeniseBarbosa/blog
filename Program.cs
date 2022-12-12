using System;
using Blog.Modelo;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog{
    class Program{


        private const string stringConeccao = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

        static void Main(string[]args){
            LerUsuarios();
        }

        public static void LerUsuarios(){

            using(var coneccao = new SqlConnection(stringConeccao)){
                
                var usuarios = coneccao.GetAll<Usuario>();//listar todos os meus usuario na base de dados
                foreach(var usuario in usuarios){
                    Console.WriteLine(usuario.Nome);
                }
            }

        }
    }
}
