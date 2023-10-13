using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2.Modeles
{
    internal class Technicien
    {
        #region Attributs
        public static List<Technicien> CollClasse = new List<Technicien>();

        private int _Matricule;
        private string _Nom;
        private string _PreNom;

        #endregion

        #region Constructeur
        public Technicien(int Matricule, string Nom, string PreNom)
        {
            _Matricule = Matricule;
            _Nom = Nom;
            _PreNom = PreNom;

            Technicien.CollClasse.Add(this);
            #endregion

            #region Getters/Setters
            #endregion

            #region Methodes
            #endregion
        }
    }
}
