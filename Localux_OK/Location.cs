using System;
using System.Collections.Generic;
using System.Text;

namespace Localux_OK
{
    abstract public class Location
    {
        private int _numLocation;
        private DateTime _dateLocation;
        private double _montantRegle;
        private Vehicule _leVehicule;

        public Location(int unNumLoc, DateTime uneDate, double unMontantRegle, Vehicule unVehicule)
        {
            this._numLocation = unNumLoc;
            this._dateLocation = uneDate;
            this._montantRegle = unMontantRegle;
            this._leVehicule = unVehicule;
        }

        public Vehicule GetLeVehicule()
        {
            return _leVehicule;
        }

        public double GetMontantRegle()
        {
            return _montantRegle;
        }
    }
}
