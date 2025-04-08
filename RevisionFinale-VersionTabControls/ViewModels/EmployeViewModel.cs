using RevisionFinale_VersionTabControls.DataBase;
using RevisionFinale_VersionTabControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.ViewModels;

public class EmployeViewModel : BaseViewModel
{
    public ObservableCollection<Employe> ListeEmployes { get; set; }
    public Employe SelectedEmploye { get; set; }
    public EmployeViewModel()
    {
        ListeEmployes = Employe_DB.GetAll_Employes();
        SelectedEmploye = new Employe();
    }
}
