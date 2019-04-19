using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    interface IVersion
    {
        VersionModel ObtenirVersionHasard();
        VersionModel ObtenirVersions(int id);
        List<VersionModel> ObtenirVersionsTous();
    }
}
