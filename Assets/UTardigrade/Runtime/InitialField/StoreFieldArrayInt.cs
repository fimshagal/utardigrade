using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayInt
    {
        public string Name;
        public int[] Value;

        public StoreFieldArrayInt(string name, int[] value)
        {
            Name = name;
            Value = value;
        }
    }
}