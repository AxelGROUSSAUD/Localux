using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    class LocationSansChauffeur : Location
    {
        private double _nbKmDepart;
        private double _nbKmRetour;
        private FormuleSansChauffeur _laFormuleSansChauffeur;

        public LocationSansChauffeur(int unNumLoc, DateTime uneDate, double unMontantRegle, double unNbKmDepart, Vehicule unVehicule, FormuleSansChauffeur uneFormuleSansChauffeur) : base(unNumLoc, uneDate, unMontantRegle, unVehicule)
        {
            _nbKmDepart = unNbKmDepart;
            _nbKmRetour = 0;
            _laFormuleSansChauffeur = uneFormuleSansChauffeur;
        }

        public double GetMontantDepasForfait()
        {
            double resultat = _nbKmRetour - _nbKmDepart;
            resultat = resultat - this._laFormuleSansChauffeur.GetNbKmInclus();
            if (resultat > 0)
            {
                resultat = resultat * this.GetLeVehicule().GetLeModele().GetTarifKmSupplementaire();

            }
            return resultat;
        }
    }
}
