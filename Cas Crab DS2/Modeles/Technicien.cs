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
        List<Visite> _LesVisites;

        #endregion

        #region Constructeur
        public Technicien(int Matricule, string Nom, string PreNom)
        {
            _Matricule = Matricule;
            _Nom = Nom;
            _PreNom = PreNom;
            _LesVisites = new List<Visite>();

            Technicien.CollClasse.Add(this);
        }
        #endregion

        #region Getters/Setters
        public int Matricule { get => _Matricule; set => _Matricule = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string PreNom { get => _PreNom; set => _PreNom = value; }
        public List<Visite> LesVisites { get => _LesVisites; }

        #endregion

        #region Methodes
        #endregion
    }
}
