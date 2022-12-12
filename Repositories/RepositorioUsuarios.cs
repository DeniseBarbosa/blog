using Blog.Modelo;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{
    public class RepositorioUsuarios{

        private SqlConnection _coneccao = new SqlConnection("");
         public  IEnumerable<Usuario> Ler()
            
            => _coneccao.GetAll<Usuario>();//listar todos os meus usuario na base de dados

         public  Usuario Ler(int id)
            => _coneccao.Get<Usuario>(id);//listar todos os meus usuario na base de dados
                
         public  void Cadastrar(Usuario usuario)
           => _coneccao.Insert<Usuario>(usuario);//listar todos os meus usuario na base de dados
                
        
    }
}