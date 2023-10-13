using Cas_Crab_DS2.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2
{
    internal class Station
    {
        #region Attributs

        public static List<Station> CollClasse = new List<Station>();

        private int _IdStation;
        private string _LibelleEmplacement;
        private List<Borne> _LesBornes;

        #endregion

        #region Constructeur

        public Station(int IdStation, string LibelleEmplacement)
        {
            _IdStation = IdStation;
            _LibelleEmplacement = LibelleEmplacement;
            _LesBornes = new List<Borne>();

            Station.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int IdStation { get => _IdStation; set => _IdStation = value; }
        public string LibelleEmplacement { get => _LibelleEmplacement; set => _LibelleEmplacement = value; }
        public List<Borne> LesBornes { get => _LesBornes; }
        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}