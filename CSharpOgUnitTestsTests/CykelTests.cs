using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpOgUnitTests;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOgUnitTestsTests
{
[TestClass()]
public class BicycleTests
{
    private Cykel _cykel;

    [TestMethod]
    public void TestConstructor()
    {
        Cykel cy1 = new Cykel();
        Cykel cy2 = new Cykel(1, "Lime", 44495.95, 12);

        Assert.AreNotEqual(null, cy1);
        Assert.AreNotEqual(null, cy2);
    }

    [TestInitialize]
    public void Init()
    {
        _cykel = new Cykel();
    }

    [TestMethod]
    public void PrisTest()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Pris = -69);

        _cykel.Pris = 0;

        Assert.AreEqual(0, _cykel.Pris);
    }

    [TestMethod]
    public void FarveTest()
    {
        Assert.ThrowsException<ArgumentNullException>(() => _cykel.Farve = null);

        Assert.ThrowsException<ArgumentException>(() => _cykel.Farve = "");

        _cykel.Farve = "G";

        Assert.AreEqual("G", _cykel.Farve);
    }

    [TestMethod]
    public void GearTest()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 2);

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 33);

        _cykel.Gear = 3;

        Assert.AreEqual(3, _cykel.Gear);
    }

    [TestMethod]
    public void TestToString()
    {
        Assert.AreEqual("Id: 0, Farve: Grøn, Pris: 0, Gear: 22", _cykel.ToString());
    }
}
}