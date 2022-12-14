using Dapper.Contrib.Extensions;

namespace Blog.Modelo{

    [Table("Categoria")]

    public class Categoria{
        public int Id { get; set; }
        
        public string Nome { get; set; }
   
        public string Slug { get; set; }
    }
}