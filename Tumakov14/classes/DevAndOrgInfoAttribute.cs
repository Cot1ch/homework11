using System;


namespace Tumakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DevAndOrgInfoAttribute : Attribute
    {
        #region Fields
        private string _DevName;
        private string _DevOrganization;
        #endregion

        #region Propeties
        public string DevName
        {
            get { return _DevName; }
            set { _DevName = value; }
        }
        public string DevOrg
        {
            get { return _DevOrganization; }
            set { _DevOrganization = value; }
        }
        #endregion

        #region Constructors
        public DevAndOrgInfoAttribute(string devName, string devOrganization)
        {
            _DevName = devName;
            _DevOrganization = devOrganization;
        }
        #endregion
    }
}
