using ase_bank;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        /// <summary>
        /// Test method to test credit with valid amount
        /// </summary>
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
          
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 16.54;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Credit(creditAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
        /// <summary>
        /// test for credit with zero amount
        /// </summary>
        [TestMethod]
        public void Credit_WithZeroAmount_DoesNotUpdateBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = 0.0;
            double expected = beginningBalance;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Credit(creditAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The expected exception was not thrown.")]
        public void Credit_WithNegativeAmount_ThrowsException()
        {
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = -3.52;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Credit(creditAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "The expected exception was not thrown.")]
        public void Credit_FrozenAccount_ThrowsException()
        {
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = -3.52;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.FreezeAccount();

            // act
            account.Credit(creditAmount);
        }
        /// <summary>
        /// Test to check if account was debited with valid amount
        /// </summary>
        /// <exception cref="NotImplementedException">error code when a wrong implementation is made</exception>
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
            //throw new NotImplementedException();
        }

        [TestMethod]
        public void Debit_WithZeroAmount_DoesNotUpdateBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 0.0;
            double expected = beginningBalance;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly.");
            //throw new NotImplementedException();
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException), "The expected exception was not thrown.")]
        public void Debit_WithNegativeAmount_ThrowsException()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = -3.52;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);
            //throw new NotImplementedException();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "The expected exception was not thrown.")]
        public void Debit_FrozenAccount_ThrowsException()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = -3.52;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.FreezeAccount();

            // act
            account.Debit(debitAmount);
            //throw new NotImplementedException();
        }
    }
}
