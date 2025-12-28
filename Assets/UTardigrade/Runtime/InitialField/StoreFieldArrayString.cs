using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayString
    {
        public string Name;
        public string[] Value;

        public StoreFieldArrayString(string name, string[] value)
        {
            Name = name;
            Value = value;
        }
    }
}