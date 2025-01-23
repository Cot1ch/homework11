using System;


namespace Tumakov14
{
    internal class BankTransaction
    {
        #region Fields
        DateTime _Time;
        decimal _Amount;
        #endregion

        #region Properties
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        #endregion

        #region Constructors
        public BankTransaction(decimal amount)
        {
            _Amount = amount;
            _Time = DateTime.Now;
        }
        #endregion
    }
}