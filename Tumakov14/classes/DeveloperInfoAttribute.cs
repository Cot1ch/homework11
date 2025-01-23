using System;

namespace Tumakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string _DevName;
        public DateTime _Date;

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
    }
}
