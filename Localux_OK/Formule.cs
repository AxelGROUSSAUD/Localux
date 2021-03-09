using System;

namespace Localux_OK
{
    abstract public class Formule
    {
        private int _id;
        private string _libelle;


        public Formule(int unId, string unLibelle)
        {
            _id = unId;
            _libelle = unLibelle;
        }

        public string GetLibelle()
        {
            return _libelle;
        }
    }
}
