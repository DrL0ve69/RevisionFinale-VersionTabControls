using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models;

public class Animateur : Employe
{
    public new string AnimerActivite()
    {
        return ($"L'animateur {Nom} anime l'activité.");
    }
    public new string SurveillerCampeurs()
    {
        return ($"L'animateur {Nom} surveille les campeurs.");
    }
}
