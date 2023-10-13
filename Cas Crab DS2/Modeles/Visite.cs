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

        #endregion

        #region Constructeur
        public Visite(string Etat, TimeSpan DureeTotal)
        {
            _Etat = Etat;
            _DureeTotale = DureeTotal;
            _LesBornes = new List<Borne>();

            Visite.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public string Etat{get => _Etat; set => _Etat = value;}
        public TimeSpan DureeTotale{get => _DureeTotale; set => _DureeTotale = value;}
        public List<Borne> LesBornes { get => _LesBornes;}
        #endregion

        #region Methodes
        #endregion
    }
}