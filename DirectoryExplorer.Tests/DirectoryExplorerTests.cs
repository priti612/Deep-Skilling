using Moq;
using NUnit.Framework;
using MagicFilesLib;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class DirectoryExplorerTests
{
    Mock<IDirectoryExplorer> mock;

    private readonly string file1 = "file.txt";
    private readonly string file2 = "file2.txt";

    [OneTimeSetUp]
    public void Init()
    {
        mock = new Mock<IDirectoryExplorer>();
    }

    [Test]
    public void TestFiles()
    {
        mock.Setup(x => x.GetFiles(It.IsAny<string>()))
            .Returns(new List<string>
            {
                file1,
                file2
            });

        var files = mock.Object.GetFiles("D:\\");

        Assert.That(files, Is.Not.Null);
        Assert.That(files.Count, Is.EqualTo(2));
        Assert.That(files.Contains(file1), Is.True);
    }
}