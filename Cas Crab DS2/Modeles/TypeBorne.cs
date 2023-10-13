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
        private TimeSpan _DureeRevision;
        private int _NbJoursEntreRevision;
        private int _NbUnitesEntreRevision;

        #endregion

        #region Constructeur
        public TypeBorne(int CodeTypeBorne, TimeSpan DureeRevision, int NbJoursEntreRevision, int NbUnitesEntreRevision)
        {
            _CodeTypeBorne = CodeTypeBorne;
            _DureeRevision = DureeRevision;
            _NbJoursEntreRevision = NbJoursEntreRevision;
            _NbUnitesEntreRevision = NbUnitesEntreRevision;

            TypeBorne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        #endregion

        #region Methodes
        #endregion
    }
