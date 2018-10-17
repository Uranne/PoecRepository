using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    [TestClass()]
    public class vehiculeTests
    {
        [TestMethod()]
        public void AccelererTest()
        {  
            double[] accelerations = { 10, 11, 12, 13, 14 };
            double[] attendu = { 16,17,18,19,20 };

            //for (int i = 0;i<accelerations.Length;i++)
            foreach(double item in accelerations)
            {
                vehicule testingVehicule = new vehicule();
                testingVehicule.Accelerer();
                testingVehicule.Accelerer(item);
                Assert.AreEqual(attendu[Array.IndexOf(accelerations, item)], testingVehicule.Vitesse);
            }

        }
    }
}