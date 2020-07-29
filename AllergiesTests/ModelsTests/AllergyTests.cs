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
     public void GetDifference_IsDifference20_True()
    {
      Assert.AreEqual(Allergy.GetDifference(52) == 20, true);
    }

    [TestMethod]
     public void GetHighestDoubleOnDifference_IsHighestDouble16_True()
    {
      Assert.AreEqual(Allergy.GetHighestDoubleOnDifference(52) == 16, true);
    }

  }
}