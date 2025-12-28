using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldLong
    {
        public string Name;
        public long Value;

        public StoreFieldLong(string name, long value)
        {
            Name = name;
            Value = value;
        }
    }
}