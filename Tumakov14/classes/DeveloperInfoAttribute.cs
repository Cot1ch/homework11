using System;

namespace Tumakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DeveloperInfoAttribute : Attribute
    {
        #region Fields
        public string _DevName;
        public DateTime _Date;
        #endregion

        #region Constructor
        public DeveloperInfoAttribute()
        {
            _DevName = null;
            _Date = DateTime.Now;
        }
        
        public DeveloperInfoAttribute(string devName, string strDate)
        {
            _DevName = devName;
            if (!DateTime.TryParse(strDate, out _Date))
                _Date = DateTime.Now;
        }
        #endregion
    }
}
