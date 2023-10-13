using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Crab_DS2.Modeles
{
    internal class TypeBorne
    {
        #region Attributs

        public static List<TypeBorne> CollClasse = new List<TypeBorne>();

        private int _CodeTypeBorne;
        private TimeSpan _DureeRevision;  // Assuming it's a duration
        private int _NbJoursEntreRevisions;
        private int _NbUnitesEntreRevisions;

        #endregion

        #region Constructeur

        public TypeBorne(int CodeTypeBorne, TimeSpan DureeRevision, int NbJoursEntreRevisions, int NbUnitesEntreRevisions)
        {
            _CodeTypeBorne = CodeTypeBorne;
            _DureeRevision = DureeRevision;
            _NbJoursEntreRevisions = NbJoursEntreRevisions;
            _NbUnitesEntreRevisions = NbUnitesEntreRevisions;

            TypeBorne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int CodeTypeBorne { get => _CodeTypeBorne; set => _CodeTypeBorne = value; }
        public TimeSpan DureeRevision { get => _DureeRevision; set => _DureeRevision = value; }
        public int NbJoursEntreRevisions { get => _NbJoursEntreRevisions; set => _NbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _NbUnitesEntreRevisions; set => _NbUnitesEntreRevisions = value; }

        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }

}