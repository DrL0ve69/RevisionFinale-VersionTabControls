using RevisionFinale_VersionTabControls.Command;
using RevisionFinale_VersionTabControls.DataBase;
using RevisionFinale_VersionTabControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RevisionFinale_VersionTabControls.ViewModels;

public class CampeurViewModel : BaseViewModel
{
    public ObservableCollection<Campeur> ListeCampeurs { get; set; }
    public ObservableCollection<Groupe> ListeGroupes { get; set; }
    private Campeur _selectedCampeur;
    public Campeur SelectedCampeur
    {
        get => _selectedCampeur;
        set
        {
            _selectedCampeur = value;
            OnPropertyChanged(nameof(SelectedCampeur));
            OnPropertyChanged(nameof(ListeCampeurs));
        }
    }
    public ICommand AddCampeurCommand => new RelayCommand(AddCampeur, CanAddCampeur);
    public ICommand DeleteCampeurCommand => new RelayCommand(DeleteCampeur, CanDeleteCampeur);
    public CampeurViewModel()
    {
        ListeCampeurs = Campeur_DB.GetAll_Campeurs();
        ListeGroupes = Groupe_DB.GetAll_Groupe();
        SelectedCampeur = new Campeur();
    }
    private void AddCampeur()
    {
        if (SelectedCampeur != null)
        {
            Campeur_DB.Add_Campeur(SelectedCampeur);
            SelectedCampeur = new Campeur();
        }
    }
    private bool CanAddCampeur()
    {
        return !string.IsNullOrWhiteSpace(SelectedCampeur.Nom) &&
               !string.IsNullOrWhiteSpace(SelectedCampeur.Prenom) &&
               SelectedCampeur.Age > 0;
    }

    private void DeleteCampeur()
    {
        if (SelectedCampeur != null)
        {
            Campeur_DB.Remove_Campeur(SelectedCampeur);
            SelectedCampeur = new Campeur();
        }
    }
    private bool CanDeleteCampeur()
    {
        return !string.IsNullOrWhiteSpace(SelectedCampeur.Nom) &&
       !string.IsNullOrWhiteSpace(SelectedCampeur.Prenom);
    }
}
