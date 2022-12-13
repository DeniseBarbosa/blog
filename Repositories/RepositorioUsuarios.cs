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
         {    usuario.Id = 0;
            _conexao.Insert<Usuario>(usuario);
         }
            
         public  void Atualizar(Usuario usuario)
           {   if (usuario.Id != 0)
              _conexao.Update<Usuario>(usuario);
           }
         
          public  void Deletar(Usuario usuario)
           {   if (usuario.Id != 0)
              _conexao.Delete<Usuario>(usuario);
           }
        
        public  void Deletar(int id )
           {   if (id != 0)
               return;
               var usuario = _conexao.Get<Usuario>(id);
              _conexao.Delete<Usuario>(usuario);
           }
    }
}