using System.Drawing;
using System.Text.Json.Serialization;

namespace examen.Entities
{
    public class Editura
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public ICollection<Autor> autori { get; }
    }
}
