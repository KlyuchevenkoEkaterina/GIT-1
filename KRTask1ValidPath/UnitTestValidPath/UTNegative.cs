using Microsoft.VisualStudio.TestTools.UnitTesting;
using KRTask1ValidPath;

namespace UnitTestValidPath
{
  [TestClass]
  public class UTNegative
  {
    [TestMethod]
    public void TestSearchUnacceptableSymbols()
    {
      Assert.AreEqual(false, new PathValidator(@"C:\Users\Kate\Des*ktop\file.txt").SearchUnacceptableSymbols());
    }

    [TestMethod]
    public void TestUnacceptableNames()
    {
      Assert.AreEqual(false, new PathValidator(@"C:\Users\Kate\Desktop\CON").SearchUnacceptableNames());
    }

    [TestMethod]
    public void TestSpaceInTheEndOfTheFilename()
    {
      Assert.AreEqual(false, new PathValidator(@"C:\Users\Kate\Desktop\file.txt ").SearchSpacePeriodInTheEndOfTheFilename());
    }

    [TestMethod]
    public void TestPeriodInTheEndOfTheFilename()
    {
      Assert.AreEqual(false, new PathValidator(@"C:\Users\Kate\Desktop\file.txt.").SearchSpacePeriodInTheEndOfTheFilename());
    }
    [TestMethod]
    public void TestBeginningAbsolutePath()
    {
      Assert.AreEqual(false, new PathValidator(@"Cc:\Users\Kate\Desktop\file.txt").CheckBeginningAbsolutePath());
    }

    [TestMethod]
    public void TestBeginningAbsolutePathWithRussianLetter()
    {
      Assert.AreEqual(true, new PathValidator(@"Щ").CheckBeginningAbsolutePath());
    }

    [TestMethod]
    public void TestSpaceAfterDiskname()
    {
      Assert.AreEqual(false, new PathValidator(@"C :\Desktop").CheckSpaceAfterDiskname());
    }

    [TestMethod]
    public void TestAbsolutePathWithTwoColons()
    {
      Assert.AreEqual(false, new PathValidator(@"C::").CheckBeginningAbsolutePath());
    }
  }
}