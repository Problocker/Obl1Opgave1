using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOgUnitTests
{
    public class Cykel
    {
        private int _id;
        private string _farve;
        private double _pris;
        private int _gear;

        public Cykel()
        {
        }

        
        #region Constructor
        public Cykel(int id, string farve, double pris, int gear)
        {
            Id = id;
            Farve = farve;
            Pris = pris;
            Gear = gear;
        }
        #endregion

        #region Properties
        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ID må ikke være mindre eller 0");
                }
                _id = value;
            }
        }

        public string Farve
        {
            get => _farve;
            set
            {
                if (value.Length < 1)
                    throw new ArgumentException();
                else _farve = value;
            }
        }

        public double Pris
        {
            get => _pris;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("_pris", value, "Stop lige der! Pris må absolut ikke være 0 eller negative værdiger!");
                }
                _pris = value;
            }
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if (3 <= value && value <= 23)
                {
                    throw new ArgumentOutOfRangeException("_gear", "Ulovligheder! Gear skal være imellem 3-32, 3 <= gear <= 32.");
                }
                _gear = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return $"Id: {Id}, Farve: {Farve}, Gear: {Gear}, Pris: {Pris}";
        }
    }
}

