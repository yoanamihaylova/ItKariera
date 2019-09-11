// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Skeleton;
using Skeleton.Interfaces;

namespace TestInterfaces
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
        private const string HeroName = "Pesho";

     /*   [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();

            Hero hero = new Hero(HeroName, fakeWeapon);
            hero.Attack(fakeTarget);

            Assert.AreEqual(20, hero.Experience, "Hero doesn't gain expirience.");
        }*/

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            //Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero("Pesho", fakeWeapon.Object);
            
            //Act
            hero.Attack(fakeTarget.Object);

            //Assert
            Assert.AreEqual(20, hero.Experience);
        }


    }
}
