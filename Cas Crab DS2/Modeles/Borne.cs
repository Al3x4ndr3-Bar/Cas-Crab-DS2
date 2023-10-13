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
        private TypeBorne _LeType;

        #endregion

        #region Constructeur
        public Borne(int IdBorne, DateTime DateDerniereRevision, int IndiceCompteurUnites, TypeBorne LeType)
        {
            _IdBorne = IdBorne;
            _DateDerniereRevesion = DateDerniereRevision;
            _IndiceCompteurUnites = IndiceCompteurUnites;
            _LeType = LeType;

            Borne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public int IdBorne { get => _IdBorne; set => _IdBorne = value; }
        public DateTime DureeTotale { get => _DateDerniereRevesion; set => _DateDerniereRevesion = value; }
        public int IndiceCompteurUnites { get => _IndiceCompteurUnites; set => _IndiceCompteurUnites = value; }
        public TypeBorne LeType { get => _LeType; set => _LeType = value; }

        #endregion

        #region Methodes
        public TypeBorne GetMonTypeBorne()
        {
            TypeBorne resultat = null;

            resultat = this.LeType;

            return resultat;
        }

        public int GetCodeTypeBorne()
        {
            int resultat = 0;
            resultat = this.LeType.CodeTypeBorne;
            return resultat;
        }
        #endregion
    }
}
