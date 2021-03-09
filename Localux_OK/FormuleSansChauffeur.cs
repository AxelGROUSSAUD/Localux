using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    public class FormuleSansChauffeur : Formule
    {
        private int _duree;
        private double _nbKmInclus;

        public FormuleSansChauffeur(int unId, string unLibelle, int uneDuree, double unNbKmInclus) : base(unId, unLibelle)
        {
            this._duree = uneDuree;
            this._nbKmInclus = unNbKmInclus;
        }

        public double GetNbKmInclus()
        {
            return _nbKmInclus;

        }

        public int GetDuree()
        {
            return _duree;
        }

        public double GetTarif(Modele unModele)
        {
            double tarif = 0;
            return tarif;
        }
    }
}
