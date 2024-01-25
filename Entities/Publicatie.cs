using System.Drawing;
using System.Text.Json.Serialization;

namespace examen.Entities
{
    //rezolvare relatie many to many
    public class Publicatie
    {
        public int id { get; set; }
        public Carte? carte {  get; set; }
        public int carte_id { get; set; }
        public Autor? autor { get; set; }
        public int autor_id {  get; set; }

    }
}
