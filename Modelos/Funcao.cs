using Dapper.Contrib.Extensions;

namespace Blog.Modelo{
    [Table("[Funcao]")]
    public class Funcao{
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }
    }
}