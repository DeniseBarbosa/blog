using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{
    public class Repositorio<Todos> where Todos: class{
        private readonly SqlConnection _conexao;
        public Repositorio(SqlConnection conexao)
              => _conexao = conexao;

         public  IEnumerable<Todos> Ler()
            => _conexao.GetAll<Todos>();//listar todos os meus usuario na base de dados

         public  Todos Ler(int id)
            => _conexao.Get<Todos>(id);//listar todos os meus usuario na base de dados
                
         public  void Cadastrar(Todos modelo)
         
           => _conexao.Insert<Todos>(modelo);
         
            
         public  void Atualizar(Todos modelo)
           
            =>  _conexao.Update<Todos>(modelo);
           
         
          public  void Deletar(Todos modelo)
           
            =>  _conexao.Delete<Todos>(modelo);
           
        
        public  void Deletar(int id )
           {   
               var modelo = _conexao.Get<Todos>(id);
              _conexao.Delete<Todos>(modelo);
           }
        

    }
}