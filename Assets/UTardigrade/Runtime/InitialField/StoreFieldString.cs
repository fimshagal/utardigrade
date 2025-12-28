using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldString
    {
        public string Name;
        public string Value;

        public StoreFieldString(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}