using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpOgUnitTests;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOgUnitTestsTests
{
    [TestClass()]
    public class CykelTests
    {
        private Cykel _cykel;

        //Opretter et testobjekt, jeg kan anvende til tests. 
        [TestInitialize]
        public void Init()
        {
            _cykel = new Cykel(1, "Tobaksbrun", 42069, 18);
        }
        //Test af hele konstruktøren
        [TestMethod()]
        public void CykelTestConstructor()
        {
            Assert.AreEqual(1, _cykel.Id);
            Assert.AreEqual("Tobaksbrun", _cykel.Farve);
            Assert.AreEqual(42069, _cykel.Pris);
            Assert.AreEqual(18, _cykel.Gear);
        }
        //ID Cykeltest
        [TestMethod()]
        public void IdTest()
        {
            Assert.AreEqual(1, _cykel.Id);
            Assert.AreEqual(0,_cykel.Id);
            Assert.AreEqual(-1,_cykel.Id);
        }
        //Farve Cykeltest
        [TestMethod()]
        public void FarveTest()
        {
            Assert.AreEqual("Tobaksbrun", _cykel.Farve);
            _cykel.Farve = "";
        }
        //Gear Cykeltest
        [TestMethod()]
        public void PrisTest()
        {
            Assert.AreEqual(42069, _cykel.Pris);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Pris = 0);
        }
        //Gear Cykeltest
        [TestMethod()]
        public void GearTest()//Gear: 3 <= gear <= 32
        {
            Assert.AreEqual(18,_cykel.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 33);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = -69);
        }


        [TestMethod()]
        public void ToStringTest()
        {
        }
    }
}