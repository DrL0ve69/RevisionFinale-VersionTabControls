using RevisionFinale_VersionTabControls.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RevisionFinale_VersionTabControls.Models;

public abstract class Personne : BaseViewModel
{
    private string _nom;
    public string Nom 
    {
        get => _nom;
        set 
        {
            _nom = value;
            OnPropertyChanged(nameof(Nom));
            OnPropertyChanged(nameof(NomComplet));
        } 
    }
    private string _prenom;
    public string Prenom 
    {
        get => _prenom;
        set 
        {
            _prenom = value;
            OnPropertyChanged(nameof(Prenom));
            OnPropertyChanged(nameof(NomComplet));
        } 
    }
    private int _age;
    public int Age 
    {
        get => _age;
        set 
        {
            _age = value;
            OnPropertyChanged(nameof(Age));
        } 
    }
    public string NomComplet => $"{Nom}, {Prenom}";
    public override string ToString()
    {
        return NomComplet + $" Âge: {Age}ans";
    }
}
