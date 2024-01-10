using Moq;
using NUnit.Framework;

namespace TuranoTests;

[TestFixture]
public class test()
{
    private Class1 _sut;

    [SetUp]
    public void SetUp()
    {
        _sut = new Class1();
    }
    [Test]
    public void TestMethod()
    {
        var result = _sut.BusinessMethod(true, "AAA", "admin", false, "IL");
        Assert.That(result, Is.EqualTo(100));
    }
    
    [Test]
    public void TestMethodfalse()
    {
        var result = _sut.BusinessMethod(true, "AAA", "false", false, "IL");
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void TestMethodMock()
    {
        var result = _sut.BusinessMethod(It.IsAny<bool>(), It.IsAny<string>(), "admin", It.IsAny<bool>() , It.IsAny<string>());
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void TestMethodMock2()
    {
        var result = _sut.BusinessMethod(true, It.IsAny<string>(), "admin", It.IsAny<bool>(), It.IsAny<string>());
        Assert.That(result, Is.EqualTo(100));
    }

    public void TestMethodMock3()
    {
        var result = _sut.BusinessMethod(false, It.IsAny<string>(), "admin", It.IsAny<bool>(), It.IsAny<string>());
        Assert.That(result, Is.EqualTo(100));
    }
    [Test]
    public void TestMethodMock4()
    {
        var result = _sut.BusinessMethod(true, "BBB", "admin", false, "NY");
        Assert.That(result, Is.EqualTo(100));
    }
    [Test]
    public void TestMethodMock5()
    {
        var result = _sut.BusinessMethod(true, "AAA", "admin", true, "IL");
        Assert.That(result, Is.EqualTo(2));
    }
    
    
    
    
}