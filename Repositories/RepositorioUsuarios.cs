using Blog.Modelo;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{
    public class RepositorioUsuarios{

        private readonly SqlConnection _conexao;

        public RepositorioUsuarios(SqlConnection conexao)
              => _conexao = conexao;
        
         public  IEnumerable<Usuario> Ler()
            
            => _conexao.GetAll<Usuario>();//listar todos os meus usuario na base de dados

         public  Usuario Ler(int id)
            => _conexao.Get<Usuario>(id);//listar todos os meus usuario na base de dados
                
         public  void Cadastrar(Usuario usuario)
           => _conexao.Insert<Usuario>(usuario);//listar todos os meus usuario na base de dados
                
        
    }
}