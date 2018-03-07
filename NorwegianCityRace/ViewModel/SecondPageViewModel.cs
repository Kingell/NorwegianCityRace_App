using System;
using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using MvvmHelpers;
using NorwegianCityRace.Models;
using Xamarin.Forms;

namespace NorwegianCityRace.ViewModel
{
    public class SecondPageViewModel : BaseViewModel
    {


      
        public SecondPageViewModel()
        {
           

            PerkList = new ObservableRangeCollection<PerkModel>()
            {
                
                new PerkModel(){
                   
                    PerkName = "Lærerns Favoritt",PerkDetail="",PerkPhoto= ImageSource.FromFile("Perk_1.png")
                },
                new PerkModel(){
                    PerkName = "Juksemaker",PerkDetail="",PerkPhoto= ImageSource.FromFile("Perk_2.png")
                },
                new PerkModel(){
                    PerkName = "Monopol",PerkDetail="",PerkPhoto= ImageSource.FromFile("Perk_3.png")
                },
                new PerkModel(){
                    PerkName =  "Skjold",PerkDetail="",PerkPhoto= ImageSource.FromFile("Perk_4.png")
                },
                new PerkModel(){
                    PerkName = "Dreven Tyv",PerkDetail="",PerkPhoto= ImageSource.FromFile("Perk_5.png")
                },


            };

           
        }

    


         #region Group Information

        string _name { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        ImageSource _picture { get; set; }
        public ImageSource Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
                OnPropertyChanged(nameof(Picture));
            }
        }
            #endregion

        PerkModel _perks { get; set; }
        public PerkModel Perks{
            get{
                return _perks;
            }
            set{
                _perks = value;
                OnPropertyChanged(nameof(Perks));
            }
        } 


        ObservableRangeCollection<PerkModel> _perklist { get; set; }
        public ObservableRangeCollection<PerkModel> PerkList { 
            get{
                return _perklist;
            }
            set{
                _perklist = value;
                OnPropertyChanged(nameof(PerkList));
            }
        }


        string _PerkName { get; set; }
        public string Perkname
        {
            get{
                return _PerkName;
            }
            set{
                _PerkName = value;
                OnPropertyChanged(nameof(Perkname));
            }
        }

       public RelayCommand NewCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Debug.WriteLine("Valgt Perk");
                });
            }
        }



    }
}
