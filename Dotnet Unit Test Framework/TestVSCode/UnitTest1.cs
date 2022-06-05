namespace TestVSCode;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int a = 5;
        int b = 5;
        int c = a + b;
        Assert.AreEqual(10, c);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int a = 5;
        int b = 2;
        int c = a + b;
        Assert.AreEqual(10, c);
    }
}