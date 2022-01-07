using NUnit.Framework;

public class AlwaySucceedTest
{
    [Test]
    public void ReturnTrue() {
        Assert.AreEqual(123, 123);
    }
    
}
