using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayFloat
    {
        public string Name;
        public float[] Value;

        public StoreFieldArrayFloat(string name, float[] value)
        {
            Name = name;
            Value = value;
        }
    }
}