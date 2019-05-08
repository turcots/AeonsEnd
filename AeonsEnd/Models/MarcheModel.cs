
using System.Collections.Generic;

namespace AeonsEnd.Models
{
    public class MarcheModel
    {
        public NemesisModel Nemesis { get; set; }
        public List<NemesisModel> ListeNemesis { get; set; }
        public List<MageModel> ListeMages { get; set; }
        public List<GemModel> ListeGems { get; set; }
        public List<RelicModel> ListeRelics { get; set; }
        public List<SortModel> ListeSorts { get; set; }
        public List<VersionModel> ListeVersions { get; set; }
    }
}