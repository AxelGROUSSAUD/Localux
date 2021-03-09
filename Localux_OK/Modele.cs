using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    class Modele
    {
        private int _id;
        private string _libelle;
        private double _tarifKmSupplementaire;

        public Modele(int unId, string unLibelle, double unTarifKmSupp)
        {
            _id = unId;
            _libelle = unLibelle;
            _tarifKmSupplementaire = unTarifKmSupp;
        }

        public double GetTarifKmSupplementaire()
        {
            return _tarifKmSupplementaire;
        }
    }
}
