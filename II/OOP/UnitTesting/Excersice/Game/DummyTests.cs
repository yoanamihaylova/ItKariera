// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace DummyTest
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
        [Test]
        public void DummyShouldLosesHealthAfterAttack()
        {
            //Arrange
            Dummy dummy = new Dummy(30, 10);
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);
            //Assert
            Assert.AreEqual(20, dummy.Health, "Dummy's health doesn't change after attack");

        }
        [Test]
        public void DeadDummyThrowExeptionIfAttack()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);
            Axe axe = new Axe(10, 10);
            //Act
            //axe.Attack(dummy);
            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
            //Трябва да се изхвърлило екс в акт
        }
        [Test]
        public void DeadDummyCanGiveExperience()
        {
            //Arrange
            Dummy dummy = new Dummy(1, 10);
            Hero hero = new Hero("Hercules");
            //Act
            hero.Attack(dummy);

            //Assert
            Assert.AreEqual(10, hero.Experience, "Hero's experience doesn't change after attack. ");
        }
        public void AliveDummyCantGiveExperience()
        {
            //Arrange
            Dummy dummy = new Dummy(20, 10);
            Hero hero = new Hero("Hercules");
            //Act
            hero.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }

    }
}
