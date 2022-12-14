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
            LerFuncaos(conexao);
            LerTags(conexao);
            //LerUsuario();
            //CadastrarUsuario();
            //AtualizarUsuario();
            //ExcluirUsuario();
            conexao.Close();
        }

       
     public static void LerUsuarios( SqlConnection conexao){

        var repositorio = new Repositorio<Usuario>(conexao);
        var items =  repositorio.Ler();

        
        foreach(var item in items){
          Console.WriteLine(item.Nome);
        }
        
        }

        public static void LerFuncaos( SqlConnection conexao){

        var repositorio = new Repositorio<Funcao>(conexao);
        var items =  repositorio.Ler();

        
        foreach(var item in items){
          Console.WriteLine(item.Nome);
        }
        
        }


        public static void LerTags( SqlConnection conexao){

        var repositorio = new Repositorio<Tag>(conexao);
        var items =  repositorio.Ler();

        
        foreach(var item in items){
          Console.WriteLine(item.Nome);
        }
        
        }

    }

}
