using System;

namespace Tumakov13
{
    internal class BuildList
    {
        #region Fields
        private Building2[] _Buildings;
        #endregion

        #region Properties
        public Building2[] Buildings
        {
            get { return _Buildings; }
            set { _Buildings = value; }
        }
        #endregion

        #region Constructors
        public BuildList()
        {
            _Buildings = new Building2[10];
        }
        #endregion

        #region Indexator
        public Building2 this[int index]
        {
            get 
            {
                if (0 <= index && index < _Buildings.Length)
                {
                    return _Buildings[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (0 <= index && index < _Buildings.Length)
                {
                    _Buildings[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        #endregion
    }
}
