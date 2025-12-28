using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayLong
    {
        public string Name;
        public long[] Value;

        public StoreFieldArrayLong(string name, long[] value)
        {
            Name = name;
            Value = value;
        }
    }
}