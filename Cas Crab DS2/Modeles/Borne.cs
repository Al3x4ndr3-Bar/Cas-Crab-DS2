using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2.Modeles
{
    internal class Borne
    {
        #region Attributs
        public static List<Borne> CollClasse = new List<Borne>();

        private int _IdBorne;
        private DateTime _DateDerniereRevesion;
        private int _IndiceCompteurUnites;

        #endregion

        #region Constructeur
        public Borne(int IdBorne, DateTime DateDerniereRevision, int IndiceCompteurUnites)
        {
            _IdBorne = IdBorne;
            _DateDerniereRevesion = DateDerniereRevision;
            _IndiceCompteurUnites = IndiceCompteurUnites;

            Borne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        #endregion

        #region Methodes
        #endregion
    }
}
