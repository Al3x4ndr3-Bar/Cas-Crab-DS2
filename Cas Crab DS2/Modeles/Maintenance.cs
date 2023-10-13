using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2.Modeles
{
    internal class Maintenance
    {
        #region Attributs

        public static List<Maintenance> CollClasse = new List<Maintenance>();
        private List<Station> _LesStations;
        private List<Visite> _LesVisites;
        private List<Technicien> _LesTechniciens;

        // Attributs de la classe Maintenance - À modifier selon vos besoins
        // Exemple d'attribut
        // Ajoutez d'autres attributs ici...

        #endregion

        #region Constructeur

        public Maintenance()  // Exemple de constructeur
        {

            Maintenance.CollClasse.Add(this);
            _LesStations = new List<Station>();
            _LesVisites = new List<Visite>();
            _LesTechniciens = new List<Technicien>();
        }

        // Vous pouvez ajouter d'autres constructeurs si nécessaire...

        #endregion

        #region Getters/Setters

        // Ajoutez d'autres getters/setters ici...
        public List<Station> LesStations { get => _LesStations; }
        public List<Visite> LesVisites { get => _LesVisites; }
        public List<Technicien> LesTechniciens { get => _LesTechniciens; }


        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}