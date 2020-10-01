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

        #region Constructor
        public Cykel(int id, string farve, double pris, int gear)
        {
            Id = id;
            Farve = farve;
            Pris = pris;
            Gear = gear;
        }
        //Dummy konstruktør
        public Cykel()
        {
        }
        #endregion

        #region Properties

        //Id, et tal
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

        //Farve, tekst-streng, min 1 tegn langt
        public string Farve
        {
            get => _farve;
            set
            {
                if (value.Length < 1)
                    throw new ArgumentException();
                _farve = value;
            }
        }

        //Pris, tal, pris > 0
        public double Pris
        {
            get => _pris;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                _pris = value;
            }
        }

        //Gear, 3 <= gear<= 32
        public int Gear
        {
            get => _gear;
            set
            {
                if (value < 3 || value > 32)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _gear = value;
            }
        }
        #endregion
        
        //ToString
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Farve)}: {Farve}, {nameof(Pris)}: {Pris}, {nameof(Gear)}: {Gear}";
        }
    }
}

