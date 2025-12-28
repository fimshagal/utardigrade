using System;
using UnityEngine;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayVector2
    {
        public string Name;
        public Vector2[] Value;

        public StoreFieldArrayVector2(string name, Vector2[] value)
        {
            Name = name;
            Value = value;
        }
    }
}