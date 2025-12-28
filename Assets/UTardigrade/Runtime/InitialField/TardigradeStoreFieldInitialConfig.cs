using System;
using UnityEngine;

namespace UTardigrade.Runtime
{
    [Serializable]
    public class TardigradeStoreFieldInitialConfig
    {
        [SerializeField] public FieldType type;
        
        [SerializeField] public StoreFieldInt valueInt;
        [SerializeField] public StoreFieldLong valueLong;
        [SerializeField] public StoreFieldFloat valueFloat;
        [SerializeField] public StoreFieldDouble valueDouble;
        [SerializeField] public StoreFieldDecimal valueDecimal;
        [SerializeField] public StoreFieldString valueString;
        [SerializeField] public StoreFieldVector2 valueVector2;
        [SerializeField] public StoreFieldVector3 valueVector3;
        [SerializeField] public StoreFieldArrayInt valueArrayInt;
        [SerializeField] public StoreFieldArrayLong valueArrayLong;
        [SerializeField] public StoreFieldArrayFloat valueArrayFloat;
        [SerializeField] public StoreFieldArrayDouble valueArrayDouble;
        [SerializeField] public StoreFieldArrayDecimal valueArrayDecimal;
        [SerializeField] public StoreFieldArrayString valueArrayString;
        [SerializeField] public StoreFieldArrayVector2 valueArrayVector2;
        [SerializeField] public StoreFieldArrayVector3 valueArrayVector3;
    }
}