using System;
using System.Collections.Generic;


namespace Tumakov13
{
    internal class BankAccount2
    {
        #region Fields
        private Guid _Id;
        private decimal _Balance;
        private Account _Account;
        private List<BankTransaction2> _TransactionsList;
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

        public List<BankTransaction2> TSList
        {
            get { return _TransactionsList; }
        }

        #endregion

        #region Constructors
        public BankAccount2(decimal balance, Account account)
        {
            _Account = account;
            _Balance = balance;
            _Id = Guid.NewGuid();
            _TransactionsList = new List<BankTransaction2>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Добавляет введённую сумму к сумме на счету. 
        /// </summary>
        /// <returns>-</returns>
        public void Put(decimal moneyy)
        {
            BankTransaction2 bt = new BankTransaction2(moneyy);
            _TransactionsList.Add(bt);

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
                BankTransaction2 bt = new BankTransaction2(-moneyy);
                _TransactionsList.Add(bt);

                _Balance -= moneyy;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод переводит (вычитает и прибавляет) сумму с одного счёта на другой
        /// </summary>
        /// <returns></returns>
        public bool MoneyTransfer(BankAccount2 bankAccount, decimal moneyy)
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

        #region Indexator
        public BankTransaction2 this[int index]
        {
            get
            {
                if (0 <= index && index < _TransactionsList.Count)
                {
                    return _TransactionsList[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (0 <= index && index < _TransactionsList.Count)
                {
                    _TransactionsList[index] = value;
                }
            }
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