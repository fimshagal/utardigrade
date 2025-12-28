using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldDecimal
    {
        public string Name;
        public decimal Value;

        public StoreFieldDecimal(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}