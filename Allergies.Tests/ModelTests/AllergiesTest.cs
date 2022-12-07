using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTest
  {
    [TestMethod]
    public void getScore_DisplayScore_128()
    {
      Allergens allergies = new Allergens(128);
      Assert.AreEqual(true, allergies.getScore() == 128);
    }

    [TestMethod]
    public void getAllergen_DisplayAllergyBasedOnScore_cats()
    {
      Allergens allergies = new Allergens(128);
      Assert.AreEqual(true, allergies.getAllergies() == "cats");
    }

  }
}