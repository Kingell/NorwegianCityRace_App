using System;
using Xamarin.Forms;
namespace NorwegianCityRace.Models
{
    public class PerkModel
    {

        public string PerkName { get; set; }
        public ImageSource PerkPhoto { get; set; }
        public string PerkDetail { get; set; }



        public PerkModel()
        {
        }

        public PerkModel(string name, string detail, ImageSource img){
            this.PerkName = name;
            this.PerkPhoto = img;
            this.PerkDetail = detail;
        }
    }
}
