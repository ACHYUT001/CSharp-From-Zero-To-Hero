using System;
using System.Collections.Generic;


namespace BootCamp.Chapter
{
    public class Person
    {
        private  string _name;
        private List<float> _balancesheet = new List<float>();

        private float _historicbalanceccount;
        private float _biggestloss;
        private float _currentbalance;
        

        //constructor
        public Person(string name, List<float> balancesheet)
        {
             _name = name;
             _balancesheet = balancesheet;
             setCurrentBalance();
             setHistoricalBalanceCount();
             setBiggestLoss();
        }


        //getters and setters
        public string getName()
        {
            return _name;
        }

        public List<float> getBalanceSheet()
        {
            return _balancesheet;
        }

        public float getCurrentBalance()
        {
            return _currentbalance;
        }

        void setCurrentBalance()
        {
            _currentbalance = _balancesheet[-1];
        }

        public float getHistoricalBalanceCount()
        {
            return _historicbalanceccount;
        }

        void setHistoricalBalanceCount()
        {
            _historicbalanceccount = _balancesheet.Count;
        }

        public float getBiggestLoss()
        {
            return _biggestloss;
        }

        void setBiggestLoss()
        {
            _biggestloss = _balancesheet[0] - _balancesheet[-1];
        }
    }
}