using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ho
{
    class Mehsul
    {
        private int _pistolStockCount { get; set; }
        public int PistolStockCount => _pistolStockCount;
       
        private float _price { get; set; }
        public float Price => _price;

        private int _salingcount { get;set; }
        public int Salingcount => _salingcount;
        public Mehsul(int pistolstockcount,float price)
        {
            _pistolStockCount = pistolstockcount;
           
            _price = price;
        }
        public float GetDiscount(float NewPrice)
        {
            float saleing = 100 - (NewPrice * 100 / _price);
            return _price = saleing;

        }
        public int GetStockCount()
        {
            return _pistolStockCount;
        }
        public bool Sale(int saleCount)
            
        {
            _salingcount = saleCount;
            if (_pistolStockCount == 0) { return false; }
            if (saleCount > _pistolStockCount) { return false; }
            _pistolStockCount -= saleCount;
            return true;

        }
        public bool Return (int returnCount)
        {
            if (returnCount > _salingcount) { return false; }
            _pistolStockCount += returnCount;
            return true;
        }
        public int AddStock(int count)
        {
            return _pistolStockCount += count;
        }
    }
}
