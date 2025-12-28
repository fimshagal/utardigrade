using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldDouble
    {
        public string Name;
        public double Value;

        public StoreFieldDouble(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}