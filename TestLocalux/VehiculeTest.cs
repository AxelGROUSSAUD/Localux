using Microsoft.VisualStudio.TestTools.UnitTesting;

using Localux_OK;


namespace TestLocalux
{
    [TestClass]
    public class VehiculeTest
    {
        [TestMethod]
        public void TestGetMontantDepasForfait()
        {
            Modele leModele = new Modele(1, "Renault Espace", 3);
            Vehicule leVehicule = new Vehicule("LA-039-LP", new System.DateTime(2016, 12, 28), leModele);
            FormuleSansChauffeur laFormule = new FormuleSansChauffeur(1, "Forfait 24h", 24, 300);
            LocationSansChauffeur laLocation = new LocationSansChauffeur(1, new System.DateTime(2018, 02, 15), 240, 25000, leVehicule, laFormule);

            laLocation.SetNbKmRetour(25400);
            double test = laLocation.GetMontantDepasForfait();
            Assert.AreEqual(300, test, "Erreur : mauvais résultat");
        }

        
    }
}
