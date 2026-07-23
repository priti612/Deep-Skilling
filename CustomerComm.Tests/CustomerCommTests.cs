using Moq;
using NUnit.Framework;
using CustomerCommLib;

[TestFixture]
public class CustomerCommTests
{
    Mock<IMailSender> mock;

    [OneTimeSetUp]
    public void Init()
    {
        mock = new Mock<IMailSender>();
    }

    [TestCase]
    public void TestMail()
    {
        mock.Setup(x => x.SendMail(It.IsAny<string>(),
                                   It.IsAny<string>()))
            .Returns(true);

        CustomerComm obj = new CustomerComm(mock.Object);

        bool result = obj.SendMailToCustomer();

        Assert.That(result, Is.True);
    }
}