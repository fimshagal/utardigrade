using System;
using UnityEngine;

namespace UTardigrade.Runtime
{
    [Serializable]
    public struct StoreFieldArrayVector3
    {
        public string Name;
        public Vector3[] Value;

        public StoreFieldArrayVector3(string name, Vector3[] value)
        {
            Name = name;
            Value = value;
        }
    }
}