using System;
using System.Collections.Generic;


namespace Tumakov13
{
    internal class BankAccount
    {
        #region Fields
        private Guid _Id;
        private decimal _Balance;
        private Account _Account;
        private Queue<BankTransaction> _Queue;
        #endregion

        #region Properties
        public Guid Id
        {
            get { return _Id; }
        }

        public decimal Balance
        {
            get { return _Balance; }
        }

        public Account Acc
        {
            get { return _Account; }
        }

        public Queue<BankTransaction> Queue
        {
            get { return _Queue; }
        }

        #endregion

        #region Constructors
        public BankAccount(decimal balance, Account account)
        {
            _Account = account;
            _Balance = balance;
            _Id = Guid.NewGuid();
            _Queue = new Queue<BankTransaction>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Добавляет введённую сумму к сумме на счету. 
        /// </summary>
        /// <returns>-</returns>
        public void Put(decimal moneyy)
        {
            BankTransaction bt = new BankTransaction(moneyy);
            _Queue.Enqueue(bt);

            _Balance += moneyy;
        }

        /// <summary>
        /// Проверяет, можно ли снять введённую сумму.
        /// Если да, то вычитает её со счёта, 
        /// в противном случае уведомляет пользователя о невозможности операции.
        /// </summary>
        /// <returns>Значение типа bool</returns>
        public bool Remove(decimal moneyy)
        {
            if (moneyy <= _Balance)
            {
                BankTransaction bt = new BankTransaction(-moneyy);
                _Queue.Enqueue(bt);

                _Balance -= moneyy;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод переводит (вычитает и прибавляет) сумму с одного счёта на другой
        /// </summary>
        /// <returns></returns>
        public bool MoneyTransfer(BankAccount bankAccount, decimal moneyy)
        {
            if (moneyy < 0)
            {
                return false;
            }
            if (bankAccount.Remove(moneyy))
            {
                Put(moneyy);
                return true;
            }
            return false;
        }
        #endregion

        #region Enum
        public enum Account
        {
            Текущий, Сберегательный
        }
        #endregion
    }
}