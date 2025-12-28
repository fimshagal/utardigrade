using System;
using UnityEngine;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldVector2
    {
        public string Name;
        public Vector2 Value;

        public StoreFieldVector2(string name, Vector2 value)
        {
            Name = name;
            Value = value;
        }
    }
}