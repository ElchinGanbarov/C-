using System;
using System.Collections.Generic;
using System.Text;

namespace _17122019
{
    class Car
    {
        private float _fuelUsage { get; set; }
        private float _fuelCapacity { get; set; }
        public float FuelCapacity => _fuelCapacity;
        private float _localKm { get; set; }
        public float LocalKm => _localKm;
        private float _globalKm { get; set; }
        public float GlobalKm => _globalKm;
        private float _currentFuel { get; set; }
        public float CurrentFuel => _currentFuel;
        public Car(float FuelCapacity,float Fuelusage)
        {
            this._fuelCapacity = FuelCapacity;
            this._fuelUsage = Fuelusage;
        }
      
        public bool Drive(float km)
        {
            float usagefordrive = _fuelUsage / 100 * km;
            if (usagefordrive > _currentFuel)
            {
                return false;
            }
           this._localKm += km;
           this._globalKm += km;
          this._currentFuel -= usagefordrive;
            return true;
        }
        public bool AdFuel(float litr)
        {
            if (litr > _fuelCapacity - _currentFuel)
            {
                return false;
            }
            _currentFuel += litr;
            return true;
        }
        public void LocalResent()
        {
            _localKm = 0;
        }
    }
}
