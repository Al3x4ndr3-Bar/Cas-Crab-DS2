using System;
using System.Collections.Generic;
using System.Linq;
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

        #endregion

        #region Constructeur
        public Visite(string Etat, TimeSpan DureeTotal)
        {
            _Etat = Etat;
            _DureeTotale = DureeTotal;

            Visite.CollClasse.Add(this);

            #endregion

            #region Getters/Setters
            #endregion

            #region Methodes
            #endregion
        }
    }
