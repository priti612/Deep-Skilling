using Moq;
using NUnit.Framework;
using PlayersManagerLib;
using System;

[TestFixture]
public class PlayerTests
{
    Mock<IPlayerMapper> mock;

    [OneTimeSetUp]
    public void Init()
    {
        mock = new Mock<IPlayerMapper>();
    }

    [Test]
    public void RegisterPlayer_Test()
    {
        mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>()))
            .Returns(false);

        Player p = Player.RegisterNewPlayer("Virat", mock.Object);

        Assert.That(p.Name, Is.EqualTo("Virat"));
        Assert.That(p.Age, Is.EqualTo(23));
        Assert.That(p.Country, Is.EqualTo("India"));
        Assert.That(p.NoOfMatches, Is.EqualTo(30));
    }
}