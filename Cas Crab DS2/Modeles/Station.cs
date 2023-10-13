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

        private int _idStation;
        private String _LibelleEmplacement;

        #endregion

        #region Constructeur
        public Station(int IdStation, string LibelleEmplacement)
        {
            _idStation = IdStation;
            _LibelleEmplacement = LibelleEmplacement;

            Station.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        #endregion

        #region Methodes
        #endregion
    }
}
