using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayDecimal
    {
        public string Name;
        public decimal[] Value;

        public StoreFieldArrayDecimal(string name, decimal[] value)
        {
            Name = name;
            Value = value;
        }
    }
}