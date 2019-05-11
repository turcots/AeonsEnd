
namespace SQLiteAeonsEnd.Entity
{
    public class Partie
    {
        public int partieId { get; set; }
        public string partieName { get; set; }
        public int versionId { get; set; }
        public int nemesisId { get; set; }
        public int nemesisVie { get; set; }
        public int mageId1 { get; set; }
        public int mageVie1 { get; set; }
        public int mageId2 { get; set; }
        public int mageVie2 { get; set; }
        public int mageId3 { get; set; }
        public int mageVie3 { get; set; }
        public int mageId4 { get; set; }
        public int mageVie4 { get; set; }
        public int repliqueId1 { get; set; }
        public int repliqueId2 { get; set; }
        public int gemId1 { get; set; }
        public int gemId2 { get; set; }
        public int gemId3 { get; set; }
        public int sortId1 { get; set; }
        public int sortId2 { get; set; }
        public int sortId3 { get; set; }
        public int sortId4 { get; set; }
        public bool partieGagne { get; set; }
        public int nbCycle { get; set; }
        public int graveholdVie { get; set; }
        public string commentaire { get; set; }
    }
}
