using RevisionFinale_VersionTabControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.DataBase;

public class Groupe_DB
{
    public static ObservableCollection<Groupe> DB_Groupe = new ObservableCollection<Groupe>()
    {
        new Groupe("Les petits", "4-5 ans"),
        new Groupe("Les moyens", "6-7 ans"),
        new Groupe("Les grands", "8-9 ans"),
        new Groupe("Les ados", "10-12 ans"),
    };
    public static ObservableCollection<Groupe> GetAll_Groupe()
    {
        return DB_Groupe;
    }
    public static void Add_Groupe(Groupe groupe)
    {
        DB_Groupe.Add(groupe);
    }
    public static void Remove_Groupe(Groupe groupe)
    {
        DB_Groupe.Remove(groupe);
    }
    public static void Clear_Groupe()
    {
        DB_Groupe.Clear();
    }
}
