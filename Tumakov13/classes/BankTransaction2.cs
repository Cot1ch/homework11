using System;


namespace Tumakov13
{
    internal class BankTransaction2
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
        public BankTransaction2(decimal amount)
        {
            _Amount = amount;
            _Time = DateTime.Now;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Метод возвращает информацию об операции со счётом:  
        /// Операция : сумма. Время проведения операции
        /// </summary>
        /// <returns>Строка string</returns>
        public override string ToString()
        {
            return $"{(_Amount < 0 ? "Снято" : "Положено")}: {Math.Abs(_Amount)} рублей.\nВремя: {_Time}\n";
        }
        #endregion
    }
}