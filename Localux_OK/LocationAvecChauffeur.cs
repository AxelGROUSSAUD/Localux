using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    class LocationAvecChauffeur : Location
    {
        private FormuleAvecChauffeur _laFormuleAvecChauffeur;

        public LocationAvecChauffeur(int unNumLoc, DateTime uneDate, double unMontantRegle, Vehicule unVehicule, FormuleAvecChauffeur uneFormuleAvecChauffeur) : base(unNumLoc, uneDate, unMontantRegle, unVehicule)
        {
            this._laFormuleAvecChauffeur = uneFormuleAvecChauffeur;
        }
    }
}
