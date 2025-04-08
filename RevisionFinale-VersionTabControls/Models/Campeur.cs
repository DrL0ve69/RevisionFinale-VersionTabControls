using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models;

public class Campeur : Personne
{
    private string _allergies;
    public string Allergies 
    {
        get => _allergies;
        set 
        {
            _allergies = value;
            OnPropertyChanged(nameof(Allergies));
        } 
    }
    private Groupe _groupeAssigné;
    public Groupe GroupeAssigné 
    {
        get => _groupeAssigné;
        set 
        {
            _groupeAssigné = value;
            OnPropertyChanged(nameof(GroupeAssigné));
        } 
    }
    public ObservableCollection<Activite> Activites { get; set; } = new ObservableCollection<Activite>();
    public string VoirActivites
    {
        get
        {
            if (Activites.Count == 0)
                return "Aucune activité inscrite";
            else
                return string.Join(", ", Activites.Select(a => a.Nom));
        }
    }
}
