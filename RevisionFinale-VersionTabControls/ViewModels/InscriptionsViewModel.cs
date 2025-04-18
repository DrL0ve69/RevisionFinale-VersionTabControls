﻿using RevisionFinale_VersionTabControls.Command;
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

public class InscriptionsViewModel : BaseViewModel
{
    public ObservableCollection<Employe> ListeEmployes { get; set; }
    public Employe SelectedEmploye { get; set; }
    public ObservableCollection<Campeur> ListeCampeurs { get; set; }
    public Campeur SelectedCampeur { get; set; }
    public ICommand UpdateCommand => new RelayCommand(Update, CanUpdate);
    public InscriptionsViewModel()
    {
        ListeEmployes = Employe_DB.GetAll_Employes();
        ListeCampeurs = Campeur_DB.GetAll_Campeurs();
        SelectedEmploye = new Employe();
        SelectedCampeur = new Campeur();
    }
    private void Update() => ListeCampeurs = Campeur_DB.GetAll_Campeurs();
    private bool CanUpdate() => SelectedCampeur != null;
}
