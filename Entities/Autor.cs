using System.Text.Json.Serialization;

namespace examen.Entities
{
    public class Autor
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public ICollection<Publicatie> Publicatii { get; }
        public Editura? editura {  get; set; }
        public int editura_id { get; set; }

    }
}
