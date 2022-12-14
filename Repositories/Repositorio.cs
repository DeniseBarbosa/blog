using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{
    public class Repositorio<Todos> where Todos: class{
        private readonly SqlConnection _conexao;
        public Repositorio(SqlConnection conexao)
              => _conexao = conexao;

         public  IEnumerable<Todos> Ler()
            => _conexao.GetAll<Todos>();//listar todos os meus usuario na base de dados

        

    }
}