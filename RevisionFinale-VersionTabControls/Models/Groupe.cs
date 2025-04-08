using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models;

public class Groupe
{
    public string Nom { get; set; }
    public string TrancheAge { get; set; }
    public ObservableCollection<Campeur> Campeurs { get; set; } = new ObservableCollection<Campeur>();
    public Moniteur MoniteurAttitre { get; set; }
    public string VoirCampeurs
    {
        get
        {
            if (Campeurs.Count == 0)
                return "Aucun campeur dans le groupe";
            else
                return string.Join(", ", Campeurs.Select(c => c.Nom));
        }
    }
    public string VoirMoniteur
    {
        get
        {
            if (MoniteurAttitre == null)
                return "Aucun moniteur assigné";
            else
                return MoniteurAttitre.Nom + $", {MoniteurAttitre.Prenom}";
        }
    }
    public Groupe() { }
    public Groupe(string nom, string trancheAge)
    {
        Nom = nom;
        TrancheAge = trancheAge;
    }
    public override string ToString()
    {
        return Nom;
    }
}
