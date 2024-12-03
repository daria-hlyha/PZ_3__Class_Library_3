using Class_Library_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Class_Library_3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MistoTest()
        {
            // Arrange
            Misto misto = new Misto("Kyiv", 50.4501, 30.5234); 

            // Act
            string nazva = misto.Nazva_Mista;
            double shyrota = misto.Shyrota;
            double dovgota = misto.Dovgota;

            // Assert
            Assert.AreEqual("Kyiv", nazva);
            Assert.AreEqual(50.4501, shyrota);
            Assert.AreEqual(30.5234, dovgota);
        }

        [TestMethod]
        public void Chasovyi_PoyasTest()
        {
            // Arrange
            Misto misto1 = new Misto("Kyiv", 50.4501, 30.5234); 
            Misto misto2 = new Misto("Los Angeles", 34.0522, -118.2437);
            Misto misto3 = new Misto("Tokyo", 35.6762, 139.6503);

            // Act
            string chasovyiPoyas1 = misto1.Chasovyi_Poyas();
            string chasovyiPoyas2 = misto2.Chasovyi_Poyas();
            string chasovyiPoyas3 = misto3.Chasovyi_Poyas();

            // Assert
            Assert.AreEqual("GMT+3", chasovyiPoyas1);
            Assert.AreEqual("GMT-8", chasovyiPoyas2);
            Assert.AreEqual("GMT+10", chasovyiPoyas3);
        }

        [TestMethod]
        public void PivkulyaTest()
        {
            // Arrange
            Misto misto1 = new Misto("Kyiv", 50.4501, 30.5234); 
            Misto misto2 = new Misto("Sydney", -33.8688, 151.2093); 
            Misto misto3 = new Misto("Quito", 0, -78.4672);

            // Act
            string pivkulya1 = misto1.Pivkulya();
            string pivkulya2 = misto2.Pivkulya();
            string pivkulya3 = misto3.Pivkulya();

            // Assert
            Assert.AreEqual("Пiвнiчна куля", pivkulya1);
            Assert.AreEqual("Пiвденна куля", pivkulya2);
            Assert.AreEqual("На екваторі широта = 0", pivkulya3);
        }
    }
}


