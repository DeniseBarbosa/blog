using System;
using Blog.Modelo;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog{
    class Program{


        private const string stringConeccao = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

        static void Main(string[]args){
            //LerUsuarios();
            //LerUsuario();
            //CadastrarUsuario();
            //AtualizarUsuario();
            ExcluirUsuario();
        }

       
     public static void LerUsuarios(){

        var repositorio = new RepositorioUsuarios();
        var usuarios =  repositorio.Ler();
        foreach(var usuario in usuarios){
          Console.WriteLine(usuario.Nome);
        }
            

        }

    public static void LerUsuario(){

            using(var coneccao = new SqlConnection(stringConeccao)){
                
                var usuario = coneccao.Get<Usuario>(1);//listar todos os meus usuario na base de dados
               
                    Console.WriteLine(usuario.Nome);
                
            }

        }
    
     public static void CadastrarUsuario(){

        var usuario = new Usuario(){
            Bio = "Estudante de Analise e Desenvolvimento de Sistemas",
            Email = "estuda@gmail.com",
            Image = "https://...",
            Nome = "Luana Stella",
            SenhaHash = "HASH",
            Slug = "Estudante de TI"
        };

            using(var coneccao = new SqlConnection(stringConeccao)){
                
                coneccao.Insert<Usuario>(usuario);//Cadastrar um usuario novo
               
                    Console.WriteLine("Cadastro realizado com sucesso");
                
            }

        }
    
    public static void AtualizarUsuario(){

        var usuario = new Usuario(){
            Id = 1,
            Bio = "Ama tecnologia, gosta de ler e assistir anime",
            Email = "deniseluvoir@gmail.com",
            Image = "https://...",
            Nome = "Denise Pereira",
            SenhaHash = "HASH",
            Slug = "ADS"
        };

            using(var coneccao = new SqlConnection(stringConeccao)){
                
                coneccao.Update<Usuario>(usuario);//Atualizar usuario
               
                    Console.WriteLine("Atualização realizada com sucesso");
                
            }

        }


       public static void ExcluirUsuario(){

    
            using(var coneccao = new SqlConnection(stringConeccao)){
                var usuario = coneccao.Get<Usuario>(2);
                coneccao.Delete<Usuario>(usuario);//Excluir usuario
               
                    Console.WriteLine("Usuario excluido com sucesso");
                
            }

        }

    
    }

}
