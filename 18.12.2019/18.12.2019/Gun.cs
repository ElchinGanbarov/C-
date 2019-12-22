using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._2019
{
    class Gun
    {
        private int _totalPistolCount { get; set; }
        public int TotalPistolCount => _totalPistolCount;

        private int _pistolCapacity { get; set; }
        public int PistolCapacity => _pistolCapacity;

        private int _currentPistolCount { get; set; }
        public int CurrentPistolCount => _currentPistolCount;

        private bool _issingle { get; set; }
        public bool Issingle => _issingle;

       public Gun(int totalpistolcount,int pistolcapasity,bool Single)
        {
            _totalPistolCount = totalpistolcount;
            _pistolCapacity = pistolcapasity;
            _issingle = Single;
            
        }
        public bool Shot()
        {
            if (_currentPistolCount == 0) { return false; }
            if (_issingle == true)
            {
                _currentPistolCount -= 1;
            }
            else
            {
                _currentPistolCount -= 2;
                
            }
            return true;
        }
        public bool Reload()
        {
            if (_totalPistolCount == 0) { return false; }
            int diff = _pistolCapacity - _currentPistolCount;
            _currentPistolCount = _pistolCapacity;
            _totalPistolCount -= diff;
            return true;
        }
        public void ChangeMood()
        {
            _issingle = !_issingle;
        }
        public void AddTotal(int addTotalCount)
        {
            _totalPistolCount += addTotalCount;
        }
    }
}
