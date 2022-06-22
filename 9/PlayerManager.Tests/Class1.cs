using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayersManagerLib;
using Moq;
using NUnit.Framework;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class Class1
    {
        public IPlayerMapper playerMapper { get; set; }
        [OneTimeSetUp]
        public void Init()
        {
            playerMapper = new PlayerMapper();
        }

        [TestCase]
        public void Test()
        {
            var mockRepo = new Mock<PlayerMapper>();
            mockRepo.Setup(x => x.IsPlayerNameExistsInDb("Hello")).Returns(false);
            Assert.That(mockRepo.Object.IsPlayerNameExistsInDb("Hello"), Is.EqualTo(false));
            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("hello", playerMapper));
            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("", playerMapper));

        }
    }
}
