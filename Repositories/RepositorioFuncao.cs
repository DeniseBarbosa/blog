using Blog.Modelo;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{
    public class RepositorioFuncao{

        private readonly SqlConnection _conexao;

        public RepositorioFuncao(SqlConnection conexao)
              => _conexao = conexao;
        
         public  IEnumerable<Funcao> Ler()
            
            => _conexao.GetAll<Funcao>();//listar todos os meus usuario na base de dados

         public  Funcao Ler(int id)
            => _conexao.Get<Funcao>(id);//listar todos os meus usuario na base de dados
                
         public  void Cadastrar(Funcao funcao)
           => _conexao.Insert<Funcao>(funcao);//listar todos os meus usuario na base de dados

            public  void Cadastrarr(Funcao funcao)
         {    funcao.Id = 0;
            _conexao.Insert<Funcao>(funcao);
         }
            
         public  void Atualizar(Funcao funcao)
           {   if (funcao.Id != 0)
              _conexao.Update<Funcao>(funcao);
           }
         
          public  void Deletar(Funcao funcao)
           {   if (funcao.Id != 0)
              _conexao.Delete<Funcao>(funcao);
           }
        
        public  void Deletar(int id )
           {   if (id != 0)
               return;
               var funcao = _conexao.Get<Funcao>(id);
              _conexao.Delete<Funcao>(funcao);
           }
    }
}