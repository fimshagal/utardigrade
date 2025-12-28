using System;
using UnityEngine;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldVector3
    {
        public string Name;
        public Vector3 Value;

        public StoreFieldVector3(string name, Vector3 value)
        {
            Name = name;
            Value = value;
        }
    }
}