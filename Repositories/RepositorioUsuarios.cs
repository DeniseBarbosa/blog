using Blog.Modelo;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{
    public class RepositorioUsuarios{
         public  IEnumerable<Usuario> Ler(){



            using(var coneccao = new SqlConnection("")){
                
                return coneccao.GetAll<Usuario>();//listar todos os meus usuario na base de dados
                
            }

        }
    }
}