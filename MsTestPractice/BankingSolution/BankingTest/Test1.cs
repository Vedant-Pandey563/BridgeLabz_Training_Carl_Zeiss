using BankingApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingTest
{
    [TestClass]
    public class BankAccountTests
    {
        private BankAccount _account;

        [TestInitialize]
        public void Setup()
        {
            _account = new BankAccount();
        }

        //new account 0 bal
        [TestMethod]
        public void NewAccount_ShouldHaveZeroBalance()
        {
            Assert.AreEqual(0m, _account.Balance);
        }

        //deposit tests

        [TestMethod]
        [TestCategory("Deposit")]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            _account.Deposit(100m);
            Assert.AreEqual(100m,_account.Balance);
        }

        [TestMethod]
        [TestCategory("Deposit")]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                _account.Deposit(-50m));
        }

        //multiple deposits
        [TestMethod]
        [DataRow(50.0)]
        [DataRow(100.0)]
        [DataRow(999.99)]
        public void Deposit_MultipleValidAmounts_UpdatesBalance(double amount)
        {
            _account.Deposit((decimal)amount);
            Assert.AreEqual((decimal)amount, _account.Balance);
        }


        //withdraw
        [TestMethod]
        [TestCategory("WithDraw")]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            _account.Deposit(200m);
            _account.Withdraw(50m);

            Assert.AreEqual(150m, _account.Balance);
        }
        [TestMethod]
        [TestCategory("Withdraw")]
        public void Withdraw_MoreThanBalance_ThrowsInvalidOperationException()
        {
            _account.Deposit(100m);

            Assert.Throws<InvalidOperationException>(() =>
                _account.Withdraw(200m));
        }

        //isolation tests 
        [TestMethod]
        public void EachTest_ShouldStartWithFreshBalance()
        {
            Assert.AreEqual(0m, _account.Balance);
        }
    }
}