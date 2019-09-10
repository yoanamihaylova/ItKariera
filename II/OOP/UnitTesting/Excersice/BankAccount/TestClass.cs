// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using BankAccounts;
using System;

namespace NUnit.Tests1
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
        [Test]
        public void AcountInitializeWithPositiveValue()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(2000m);
            //Add

            //Assert
            Assert.AreEqual(2000m, bankAccount.Amount);
        }
        [Test]
         public void DepositShouldAddMoney()
         {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Add
            bankAccount.Deposit(50);
            //Assert
            Assert.IsTrue(bankAccount.Amount == 50);
         }
        [Test]
        public void WithdrawShouldReturnMoneyInsuficientAvailability()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Add
            var ex = Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(1000));
            //Assert
            Assert.That(ex.Message == "Insufficient availability!");
        }
        [Test]
        public void WithdrawShouldDecreaseMoney()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(30);
            //Add
            bankAccount.Withdraw(10);
            //Assert
            Assert.IsTrue(bankAccount.Amount == 20);
        }
    }

    

}
