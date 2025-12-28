using System;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldInt
    {
        public string Name;
        public int Value;

        public StoreFieldInt(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}