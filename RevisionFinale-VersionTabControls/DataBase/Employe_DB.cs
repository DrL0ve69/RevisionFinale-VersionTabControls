using RevisionFinale_VersionTabControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.DataBase;

public class Employe_DB
{
    public static ObservableCollection<Employe> DB_Employes = new ObservableCollection<Employe>()
    {
        new Animateur { Nom = "Dupont", Prenom = "Jean", Poste = "Animateur", Experience = 5 },
        new Moniteur { Nom = "Martin", Prenom = "Sophie", Poste = "Moniteur", Experience = 3 },
        new Employe { Nom = "Durand", Prenom = "Pierre", Poste = "Surveillant", Experience = 2 },
        new Animateur { Nom = "Leroy", Prenom = "Marie", Poste = "Animateur", Experience = 4 },
        new Moniteur { Nom = "Moreau", Prenom = "Lucie", Poste = "Moniteur", Experience = 1 }
    };
    public static ObservableCollection<Employe> GetAll_Employes() 
    {
        return DB_Employes;
    }
    public static void Add_Employe(Employe employe)
    {
        DB_Employes.Add(employe);
    }
    public static void Remove_Employe(Employe employe)
    {
        DB_Employes.Remove(employe);
    }
    public static void Update_Employe(Employe employe)
    {
        var existingEmploye = DB_Employes.FirstOrDefault(e => e.Nom == employe.Nom && e.Prenom == employe.Prenom);
        if (existingEmploye != null)
        {
            existingEmploye.Poste = employe.Poste;
            existingEmploye.Experience = employe.Experience;
        }
    }
    public static void Clear_Employes()
    {
        DB_Employes.Clear();
    }
}
