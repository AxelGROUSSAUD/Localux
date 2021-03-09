using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    public class FormuleAvecChauffeur : Formule
    {
        private string _lieu;
        private double _tarif;

        public FormuleAvecChauffeur(int unId, string unLibelle, string unLieu, double unTarif) : base(unId, unLibelle)
        {
            this._lieu = unLieu;
            this._tarif = unTarif;
        }

        public string GetLieu()
        {
            return _lieu;
        }

        public double GetTarif()
        {
            return _tarif;
        }
    }
}
