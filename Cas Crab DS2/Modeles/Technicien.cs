using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2.Modeles
{
    public class Technicien
    {
        #region Attributs

        public static List<Technicien> CollClasse = new List<Technicien>();

        private int _Matricule;
        private string _Nom;
        private string _Prenom;

        #endregion

        #region Constructeur

        public Technicien(int Matricule, string Mom, string Prenom)
        {
            _Matricule = Matricule;
            _Nom = Nom;
            _Prenom = Prenom;

            Technicien.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int Matricule { get => _Matricule; set => _Matricule = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }

        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}