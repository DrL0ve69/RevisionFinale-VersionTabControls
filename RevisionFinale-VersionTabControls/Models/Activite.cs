using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models;

public class Activite
{
    public string Nom { get; set; }
    public string Description { get; set; }
    public string Horaire { get; set; }
    public ObservableCollection<Campeur> CampeursInscrits { get; set; } = new ObservableCollection<Campeur>();
    public Employe EmployeResponsable { get; set; }
}
