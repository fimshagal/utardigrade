using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayDouble
    {
        public string Name;
        public double[] Value;

        public StoreFieldArrayDouble(string name, double[] value)
        {
            Name = name;
            Value = value;
        }
    }
}