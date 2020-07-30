using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace AllergiesTests{
  [TestClass]
  public class AllergyTests{
    [TestMethod]
    public void GetHighestDouble_IsHighestDouble32_True()
    {
      Assert.AreEqual(Allergy.GetHighestDouble(52) == 32, true);
    }
    [TestMethod]
     public void GetHighestDouble_IsHighestDouble1_True()
    {
      Assert.AreEqual(Allergy.GetHighestDouble(1) == 1, true);
    }
      [TestMethod]
      public void GetHighestDouble_IsHighestDouble4_True()
    {
      Assert.AreEqual(Allergy.GetHighestDouble(4), 4);
    }

    [TestMethod]
     public void GetDifference_IsDifference20_True()
    {
      Assert.AreEqual(Allergy.GetDifference(52) == 20, true);
    }

    [TestMethod]
     public void GetHighestDoubleOnDifference_IsHighestDouble16_True()
    {
      Assert.AreEqual(Allergy.GetHighestDoubleOnDifference(52) == 16, true);
    }

     [TestMethod]
     public void GetStringFromHighestDouble_IsChocolate_True()
    {
      Assert.AreEqual(Allergy.GetStringFromHighestDouble(52) == "chocolate", true);
    }

      [TestMethod]
     public void GetStringArrayFromHighestDoubleAndDifference_IsChocolateAndTomatoes_True()
    {
      CollectionAssert.AreEqual(Allergy.GetStringArrayFromHighestDoubleAndDifference(52), new string[]{"chocolate","tomatoes"});
    }

      [TestMethod]
     public void  GetAllergyStringArray_IsChocolateAndTomatoesandShellFish_True()
    {
      CollectionAssert.AreEqual(Allergy.GetAllergyStringArray(52), new string[]{"chocolate","tomatoes","shellfish"});
    }


  }
}