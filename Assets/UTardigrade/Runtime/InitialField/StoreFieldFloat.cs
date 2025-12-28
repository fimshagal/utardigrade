using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldFloat
    {
        public string Name;
        public float Value;

        public StoreFieldFloat(string name, float value)
        {
            Name = name;
            Value = value;
        }
    }
}