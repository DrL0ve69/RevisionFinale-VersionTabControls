using RevisionFinale_VersionTabControls.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models
{
    public class Employe : Personne, IEncadrant
    {
        public string Poste { get; set; }
        public int Experience { get; set; }
        public ObservableCollection<Activite> ActivitesEncadrees { get; set; } = new ObservableCollection<Activite>();

        public string AnimerActivite()
        {
            return ($"L'employé {Nom} anime l'activité.");
        }

        public string SurveillerCampeurs()
        {
            return ($"L'employé {Nom} surveille les campeurs.");
        }
        public override string ToString()
        {
            return $"{NomComplet} ({Poste}) - {Experience} ans d'expérience";
        }
    }
}
