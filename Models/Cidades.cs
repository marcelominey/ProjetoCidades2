using System.Collections.Generic;

namespace WebServicesCidades.Models
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public int Habitantes { get; set; }
        public List<Cidades> Listar(){
            return new List<Cidades>(){
                new Cidades{Id=10,Nome="Leme",Estado="SP",Habitantes=15},
                new Cidades{Id=30,Nome="Campinas",Estado="SP",Habitantes=125}
            };
        }
    }
}