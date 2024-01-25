using System.Drawing;
using System.Text.Json.Serialization;

namespace examen.Entities
{
    public class Carte
    {
        public int id { get; set; }
        public string titlu { get; set; }
        [JsonIgnore]
        public ICollection<Publicatie> Edituri { get; }

    }
}
