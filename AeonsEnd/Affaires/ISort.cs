using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    interface ISort
    {
        List<SortModel> ObtenirSorts(int numberRandom, int versionId);
        SortModel ObtenirSorts(int id);
        List<SortModel> ObtenirSortsTous();
        List<SortModel> ObtenirSortsTous(int versionId);
    }
}
