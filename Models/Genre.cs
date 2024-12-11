

using System.ComponentModel.DataAnnotations;

namespace Professions.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Display (Name = "Nome")]
        public string Name { get; set; }
        public string NivelEscolaridade { get; set; }
        public string MediaSalarial { get; set; }
        public string AreaAtuacao { get; set; }


        // public ICollection<Nome> Nomes { get; set; } = new List<Nome>();

        public Genre() { }

        public Genre(int Id, string Nome) 
        
        { 
        
        }


    }
}
