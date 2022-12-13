using System;
using Blog.Modelo;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog{
    class Program{


        private const string stringConexao = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

        static void Main(string[]args){

            var conexao = new SqlConnection(stringConexao);
            conexao.Open();
            LerUsuarios(conexao);
            LerFuncao(conexao);
            //LerUsuario();
            //CadastrarUsuario();
            //AtualizarUsuario();
            //ExcluirUsuario();
            conexao.Close();
        }

       
     public static void LerUsuarios( SqlConnection conexao){

        var repositorio = new RepositorioUsuarios(conexao);
        var usuarios =  repositorio.Ler();
        foreach(var usuario in usuarios){
          Console.WriteLine(usuario.Nome);
        }
        
        }

     public static void LerFuncao( SqlConnection conexao){

        var repositorio = new RepositorioFuncao(conexao);
        var funcaos =  repositorio.Ler();
        foreach(var funcao in funcaos){
          Console.WriteLine(funcao.Nome);
        }
        
        }

    }

}
