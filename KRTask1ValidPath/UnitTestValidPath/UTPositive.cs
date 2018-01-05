using Microsoft.VisualStudio.TestTools.UnitTesting;
using KRTask1ValidPath;

namespace UnitTestValidPath
{
  [TestClass]
  public class UTPositive
  {
    [TestMethod]
    public void TestSearchUnacceptableSymbols()
    {
      Assert.AreEqual(true, new PathValidator(@"C:\Users\Kate\Desktop\file.txt").SearchUnacceptableSymbols());
    }

    [TestMethod]
    public void TestUnacceptableNames()
    {
      Assert.AreEqual(true, new PathValidator(@"C:\Users\Kate\Desktop\CON56.txt").SearchUnacceptableNames());
    }

    [TestMethod]
    public void TestBeginningRelativePathWithTwoPoint()
    {
      Assert.AreEqual(true, new PathValidator(@"..\Users\Kate\Desktop\file.txt").CheckBeginningRelativePath());
    }

    [TestMethod]
    public void TestBeginningRelativePathWithOnePoint()
    {
      Assert.AreEqual(true, new PathValidator(@".\Users\Kate\Desktop\file.txt").CheckBeginningRelativePath());
    }

    [TestMethod]
    public void TestBeginningAbsolutePath()
    {
      Assert.AreEqual(true, new PathValidator(@"C:\Users\Kate\Desktop\file.txt").CheckBeginningAbsolutePath());
    }

    [TestMethod]
    public void TestBeginningAbsolutePathWithoutBackslashe()
    {
      Assert.AreEqual(true, new PathValidator(@"C:File").CheckBeginningAbsolutePath());
    }

    [TestMethod]
    public void TestPathConsistsOfOneLetter()
    {
      Assert.AreEqual(true, new PathValidator("Z").CheckAbsolutePathWithOneLetter());
    }

    [TestMethod]
    public void TestAbsolutePathWithOneColon()
    {
      Assert.AreEqual(true, new PathValidator(@"C:").CheckBeginningAbsolutePath());
    }
  }
}
