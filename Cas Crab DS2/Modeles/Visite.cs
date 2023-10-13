using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2.Modeles
{
    internal class Visite
    {
        #region Attributs

        public static List<Visite> CollClasse = new List<Visite>();

        private string _Etat;
        private TimeSpan _DureeTotale;
        private List<Borne> _LesBornes;
        private Station _LaStation;

        #endregion

        #region Constructeur

        public Visite(string Etat, TimeSpan DureeTotale, Station LaStation)
        {
            _Etat = Etat;
            _DureeTotale = DureeTotale;
            _LesBornes = new List<Borne>();
            _LaStation = LaStation;
            Visite.CollClasse.Add(this);

        }

        #endregion

        #region Getters/Setters

        public string Etat { get => _Etat; set => _Etat = value; }
        public TimeSpan DureeTotale { get => _DureeTotale; set => _DureeTotale = value; }
        public Station LaStation { get => _LaStation; set => _LaStation = value; }
        public List<Borne> LesBornes { get => _LesBornes; }


        #endregion

        #region Methodes

        // Je veux savoir si la borne 12 fait partie de la visite
        public bool GetBornePrecise(int param)
        {
            bool resultat = false;
            foreach (Borne uneBorne in this.LesBornes)
            {
                if (uneBorne.IdBorne == param)
                {
                    resultat = true;
                    return resultat;
                }
            }

            return resultat;

        }

        #endregion
    }
}