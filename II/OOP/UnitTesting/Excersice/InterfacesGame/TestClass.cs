// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
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

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();

            Hero hero = new Hero(HeroName, fakeWeapon);
            hero.Attack(fakeTarget);

            Assert.AreEqual(20, hero.Experience, "Hero doesn't gain expirience.");
        }

    }
}
