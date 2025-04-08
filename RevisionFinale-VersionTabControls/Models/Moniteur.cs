using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models;

public class Moniteur : Employe
{
    public new string AnimerActivite()
    {
        return ($"Le moniteur {Nom} anime l'activité.");
    }
    public new string SurveillerCampeurs()
    {
        return ($"Le moniteur {Nom} surveille les campeurs.");
    }
}
