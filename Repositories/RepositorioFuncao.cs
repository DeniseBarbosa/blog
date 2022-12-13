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
    }
}