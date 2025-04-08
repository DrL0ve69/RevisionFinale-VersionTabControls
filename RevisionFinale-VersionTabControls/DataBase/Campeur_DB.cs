using RevisionFinale_VersionTabControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.DataBase;

public static class Campeur_DB
{
    public static ObservableCollection<Campeur> DB_Campeurs = new ObservableCollection<Campeur>()
    {
        new Campeur { Nom = "Dupont", Prenom = "Jean", Allergies = "Aucune" },
        new Campeur { Nom = "Martin", Prenom = "Sophie", Allergies = "Fruits de mer" },
        new Campeur { Nom = "Durand", Prenom = "Pierre", Allergies = "Arachides" },
        new Campeur { Nom = "Leroy", Prenom = "Marie", Allergies = "Lactose" },
        new Campeur { Nom = "Moreau", Prenom = "Lucie", Allergies = "Gluten" }
    };
    public static ObservableCollection<Campeur> GetAll_Campeurs()
    {
        return DB_Campeurs;
    }
    public static void Add_Campeur(Campeur campeur)
    {
        DB_Campeurs.Add(campeur);
    }
    public static void Remove_Campeur(Campeur campeur)
    {
        DB_Campeurs.Remove(campeur);
    }
    public static void Update_Campeur(Campeur campeur)
    {
        var existingCampeur = DB_Campeurs.FirstOrDefault(c => c.Nom == campeur.Nom && c.Prenom == campeur.Prenom);
        if (existingCampeur != null)
        {
            existingCampeur.Allergies = campeur.Allergies;
            existingCampeur.GroupeAssigné = campeur.GroupeAssigné;
            existingCampeur.Activites = campeur.Activites;
        }
    }
    public static void Clear_Campeurs()
    {
        DB_Campeurs.Clear();
    }
}
