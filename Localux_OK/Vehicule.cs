using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    class Vehicule
    {
        private string _immatriculation;
        private DateTime _dateAchat;
        private Modele _leModele;
        private List<LocationSansChauffeur> _mesLocationsSansChauffeur;

        public Vehicule(string uneImmat, DateTime uneDate, Modele unModele)
        {
            _immatriculation = uneImmat;
            _dateAchat = uneDate;
            _leModele = unModele;
            _mesLocationsSansChauffeur = new List<LocationSansChauffeur>();
        }

        public Modele GetLeModele()
        {
            return _leModele;
        }

        public void AddLocationSansChauffeur(LocationSansChauffeur uneLocationSansChauffeur)
        {
            _mesLocationsSansChauffeur.Add(uneLocationSansChauffeur);
        }

        public double GetTotalDepasForfait()
        {
            double somme = 0;

            foreach (LocationSansChauffeur LSC in _mesLocationsSansChauffeur)
            {
                somme = somme + LSC.GetMontantDepasForfait();
            }
            return somme;
        }
    }
}
