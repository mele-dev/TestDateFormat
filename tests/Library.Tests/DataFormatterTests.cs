using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }


    // ejemplo TESTS
    [Test]
    //[TestCase("10/11/1997", "1997-11-10")]
    public void TestDateWithFormatOk()
    {
        const string input = "10/11/1997";
        const string expected = "1997-11-10";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    //[TestCase("1997-11-10", "wrongDate")]
    public void TestDateWithWrongFormat()
    {
        const string input = "1997-11-10";
        const string expected = "wrongDate";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    //[TestCase("", "wrongDate")]
    public void TestDateEmptyInput()
    {
        const string input = "";
        const string expected = "wrongDate";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}